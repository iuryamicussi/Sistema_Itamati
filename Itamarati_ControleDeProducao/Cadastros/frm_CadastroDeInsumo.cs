using Itamarati_ControleDeProducao.Controller;
using Itamarati_ControleDeProducao.DTO;
using Itamarati_ControleDeProducao.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Itamarati_ControleDeProducao.Cadastros
{
    public partial class frm_CadastroDeInsumo : Form
    {

        //Objetos
        private DataView lst_InsumosCadastrados;
        private InsumoDTO obj_InsumoDTO;
        private InsumoModel obj_InsumoModel = new InsumoModel();

        //Variáveis de controle
        private Boolean bol_HabilitaValidacaoPorTeclado = false;
        private int retornoDaFuncao;

        public frm_CadastroDeInsumo()
        {
            InitializeComponent();
            this.grd_Insumos.Columns["ValorUnitarioDaUltimaCompraDoInsumo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btn_SalvarRegistro_Click(object sender, EventArgs e)
        {
            //Validação de Campos
            if (grd_Insumos.Enabled == false)
            {
                ValidaCodigoDoInsumo();
            }
            ValidaNomeDoInsumo();
            ValidaUnidadeDeMedidaDoInsumo();
            ValidaValorDaUltimaCompraDoInsumo();

            if (err_ValidaInsumo.GetError(txt_CodigoDoInsumo) != "")
            {
                MessageBox.Show(err_ValidaInsumo.GetError(txt_CodigoDoInsumo), "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_CodigoDoInsumo.Focus();
                return;
            }

            if (err_ValidaInsumo.GetError(txt_NomeDoInsumo) != "")
            {
                MessageBox.Show(err_ValidaInsumo.GetError(txt_NomeDoInsumo), "Descrição Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NomeDoInsumo.Focus();
                return;
            }

            if (err_ValidaInsumo.GetError(txt_UnidadeDeMedidaDoInsumo) != "")
            {
                MessageBox.Show(err_ValidaInsumo.GetError(txt_UnidadeDeMedidaDoInsumo), "Unidade de Medida Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_UnidadeDeMedidaDoInsumo.Focus();
                return;
            }

            if (err_ValidaInsumo.GetError(txt_ValorUnitarioDaUltimaCompraDoInsumo) != "")
            {
                MessageBox.Show(err_ValidaInsumo.GetError(txt_ValorUnitarioDaUltimaCompraDoInsumo), "Valor Unitário Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ValorUnitarioDaUltimaCompraDoInsumo.Focus();
                return;
            }

            //Salva o Registro
            if (grd_Insumos.Enabled == false)
            {
                InicializaCampos("SalvarNovo");
            }
            else
            {
                InicializaCampos("Salvar");
            }

        }

        //Carregar Insumos no Grid
        private void CarregaUsuariosNoGrid()
        {
            try
            {
                grd_Insumos.DataSource = null;
                grd_Insumos.Rows.Clear();
                grd_Insumos.Refresh();

                lst_InsumosCadastrados = new DataView();
                lst_InsumosCadastrados = obj_InsumoModel.BuscaListaDeInsumosCadastrados();

                grd_Insumos.AutoGenerateColumns = false;

                grd_Insumos.DataSource = lst_InsumosCadastrados;
                grd_Insumos.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frm_CadastroDeInsumo_Load(object sender, EventArgs e)
        {
            //Inicializa a Tela
            CarregaUsuariosNoGrid();

            //Se não houver nenhum no banco, bloqueia os campos
            if (grd_Insumos.RowCount <= 0)
            {
                HabilitarCampos(false);
            }
            else
            {
                CarregaInformacoesDoUsuario();
            }
            HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa();
        }

        //Habilita/Desabilita campo
        private void HabilitarCampos(Boolean bol_Modo)
        {
            txt_NomeDoInsumo.Enabled = bol_Modo;
            txt_UnidadeDeMedidaDoInsumo.Enabled = bol_Modo;
            txt_ValorUnitarioDaUltimaCompraDoInsumo.Enabled = bol_Modo;
        }

        //Carregar informações do Grid nos campos
        private void CarregaInformacoesDoUsuario()
        {
            txt_CodigoDoInsumo.Enabled = false;
            txt_CodigoDoInsumo.Text = grd_Insumos.SelectedRows[0].Cells[0].FormattedValue.ToString();
            txt_NomeDoInsumo.Text = grd_Insumos.SelectedRows[0].Cells[1].FormattedValue.ToString();
            txt_UnidadeDeMedidaDoInsumo.Text = grd_Insumos.SelectedRows[0].Cells[2].FormattedValue.ToString();
            msk_DataHoraDeCadastroDoInsumo.Text = grd_Insumos.SelectedRows[0].Cells[3].FormattedValue.ToString();
            txt_ValorUnitarioDaUltimaCompraDoInsumo.Text = obj_InsumoModel.consistirValor(grd_Insumos.SelectedRows[0].Cells[4].FormattedValue.ToString().Replace("R$", "").Trim());
        }

        //Rotina de inicialização de Função
        private void InicializaCampos(string modo)
        {
            int int_GuardaLinhaSelecionada;

            switch (modo)
            {
                case "Incluir":
                    LimpaCampos();
                    txt_CodigoDoInsumo.Enabled = true;
                    HabilitarCampos(true);
                    msk_DataHoraDeCadastroDoInsumo.Text = DateTime.Now.ToString();
                    grd_Insumos.Enabled = false;
                    btn_ExcluirRegistro.Enabled = false;
                    btn_PesquisarRegistro.Enabled = false;
                    txt_Pesquisa.Visible = false;

                    txt_CodigoDoInsumo.Focus();
                    LimpaErrosEncontrados();
                    break;

                case "SalvarNovo":
                    obj_InsumoDTO = new InsumoDTO();

                    try
                    {
                        //Carrega o objeto com os campos digitados
                        obj_InsumoDTO.CodigoDoInsumo = Convert.ToInt32(txt_CodigoDoInsumo.Text);
                        obj_InsumoDTO.NomeDoInsumo = txt_NomeDoInsumo.Text;
                        obj_InsumoDTO.UnidadeDeMedidaDoInsumo = txt_UnidadeDeMedidaDoInsumo.Text;
                        obj_InsumoDTO.ValorUnitarioDaUltimaCompraDoInsumo = Convert.ToSingle(txt_ValorUnitarioDaUltimaCompraDoInsumo.Text);
                        obj_InsumoDTO.DataHoraDeCadastroDoInsumo = Convert.ToDateTime(msk_DataHoraDeCadastroDoInsumo.Text);

                        //Insere as informações no Banco
                        retornoDaFuncao = obj_InsumoModel.IncluirNovoUsuario(obj_InsumoDTO);

                        if (retornoDaFuncao > 0)
                        {
                            MessageBox.Show("Insumo cadastrado com sucesso!", "Insumo Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O Insumo não foi cadastrado!");
                        }

                        grd_Insumos.Enabled = true;

                        //Recarrega a Tabela de Usuários e seleciona o registro criado
                        bol_HabilitaValidacaoPorTeclado = false;
                        CarregaUsuariosNoGrid();
                        grd_Insumos.Rows[grd_Insumos.Rows.Count - 1].Selected = true;
                        CarregaInformacoesDoUsuario();
                        bol_HabilitaValidacaoPorTeclado = true;
                        HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Salvar":

                    obj_InsumoDTO = new InsumoDTO();

                    try
                    {
                        //Carrega o objeto com os campos digitados
                        obj_InsumoDTO.NomeDoInsumo = txt_NomeDoInsumo.Text;
                        obj_InsumoDTO.UnidadeDeMedidaDoInsumo = txt_UnidadeDeMedidaDoInsumo.Text;
                        obj_InsumoDTO.ValorUnitarioDaUltimaCompraDoInsumo = Convert.ToSingle(txt_ValorUnitarioDaUltimaCompraDoInsumo.Text);
                        obj_InsumoDTO.DataHoraDeCadastroDoInsumo = Convert.ToDateTime(msk_DataHoraDeCadastroDoInsumo.Text);

                        //Insere as informações no Banco
                        retornoDaFuncao = obj_InsumoModel.AtualizaInformacoesDoInsumo(obj_InsumoDTO, Convert.ToInt32(grd_Insumos.CurrentRow.Cells[0].FormattedValue.ToString()));

                        if (retornoDaFuncao > 0)
                        {
                            MessageBox.Show("Informações salvas com sucesso!", "Insumo Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O Insumo não foi salvo!", "Erro no salvamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        //Recarrega a Tabela de Insumos e seleciona o registro criado
                        bol_HabilitaValidacaoPorTeclado = false;
                        int_GuardaLinhaSelecionada = grd_Insumos.SelectedRows[0].Index;
                        CarregaUsuariosNoGrid();
                        CarregaInformacoesDoUsuario();
                        bol_HabilitaValidacaoPorTeclado = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Cancelar":

                    if (grd_Insumos.Rows.Count > 0)
                    {
                        CarregaInformacoesDoUsuario();
                        txt_NomeDoInsumo.Focus();
                    }
                    else
                    {
                        LimpaCampos();
                        HabilitarCampos(false);
                    }
                    txt_CodigoDoInsumo.Enabled = false;
                    grd_Insumos.Enabled = true;
                    HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa();
                    LimpaErrosEncontrados();
                    break;

                case "Excluir":
                    obj_InsumoDTO = new InsumoDTO();

                    try
                    {
                        //Carrega o objeto com os campos digitados
                        obj_InsumoDTO.CodigoDoInsumo = Convert.ToInt32(txt_CodigoDoInsumo.Text);
                        obj_InsumoDTO.NomeDoInsumo = txt_NomeDoInsumo.Text;
                        obj_InsumoDTO.UnidadeDeMedidaDoInsumo = txt_UnidadeDeMedidaDoInsumo.Text;
                        obj_InsumoDTO.ValorUnitarioDaUltimaCompraDoInsumo = Convert.ToSingle(txt_ValorUnitarioDaUltimaCompraDoInsumo.Text);
                        obj_InsumoDTO.DataHoraDeCadastroDoInsumo = Convert.ToDateTime(msk_DataHoraDeCadastroDoInsumo.Text);

                        //Exclui o usuário
                        retornoDaFuncao = obj_InsumoModel.ExcluiInformacoesDoInsumo(obj_InsumoDTO);

                        if (retornoDaFuncao > 0)
                        {
                            MessageBox.Show("Insumo removido com sucesso!", "Insumo Removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O insumo não foi removido!", "Erro ao Remover Insumo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        grd_Insumos.Enabled = true;

                        //Recarrega a Tabela de Usuários e seleciona o registro criado
                        bol_HabilitaValidacaoPorTeclado = false;
                        CarregaUsuariosNoGrid();

                        if (grd_Insumos.Rows.Count > 0)
                        {
                            CarregaInformacoesDoUsuario();
                        }

                        bol_HabilitaValidacaoPorTeclado = true;
                        HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa();
                        LimpaErrosEncontrados();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao excluir o usuário.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Pesquisar":

                    lst_InsumosCadastrados.RowFilter = "NomeDoInsumo Like '" + txt_Pesquisa.Text.Trim() + "%'";
                    grd_Insumos.Refresh();
                    grd_Insumos.Focus();

                    break;
            }
        }

        //Limpa os campos para um novo registro
        private void LimpaCampos()
        {
            txt_CodigoDoInsumo.Text = "";
            txt_NomeDoInsumo.Text = "";
            txt_UnidadeDeMedidaDoInsumo.Text = "";
            txt_ValorUnitarioDaUltimaCompraDoInsumo.Text = "0";
            msk_DataHoraDeCadastroDoInsumo.Text = "";
        }

        //Reseta Erros da tela
        private void LimpaErrosEncontrados()
        {
            err_ValidaInsumo.SetError(txt_CodigoDoInsumo, "");
            err_ValidaInsumo.SetError(txt_NomeDoInsumo, "");
            err_ValidaInsumo.SetError(txt_UnidadeDeMedidaDoInsumo, "");
            err_ValidaInsumo.SetError(txt_ValorUnitarioDaUltimaCompraDoInsumo, "");
        }

        //Desabilita botoes quando não existem registros
        private void HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa()
        {
            if (grd_Insumos.Rows.Count > 0)
            {
                btn_ExcluirRegistro.Enabled = true;
                txt_Pesquisa.Visible = true;
                btn_PesquisarRegistro.Enabled = true;
            }
            else
            {
                btn_ExcluirRegistro.Enabled = false;
                txt_Pesquisa.Visible = false;
                btn_PesquisarRegistro.Enabled = false;
            }
        }

        #region Métodos de Validação
        private void ValidaCodigoDoInsumo()
        {
            //Validação dos campos
            err_ValidaInsumo.SetError(txt_CodigoDoInsumo, ValidacaoGenericaDeCampos.VerificaSeOCampoEstaVazio(txt_CodigoDoInsumo.Text, "o Código do Insumo"));

            if (err_ValidaInsumo.GetError(txt_CodigoDoInsumo) == "")
            {
                txt_CodigoDoInsumo.Text = txt_CodigoDoInsumo.Text.PadLeft(6, '0');
                err_ValidaInsumo.SetError(txt_CodigoDoInsumo, obj_InsumoModel.VerificaSeOCodigoDigitadoJaEstaSendoUsado(Convert.ToInt32(txt_CodigoDoInsumo.Text)));
            }
        }

        private void ValidaNomeDoInsumo()
        {
            //Validação dos campos
            err_ValidaInsumo.SetError(txt_NomeDoInsumo, ValidacaoGenericaDeCampos.VerificaSeOCampoEstaVazio(txt_NomeDoInsumo.Text, "o Nome do Insumo"));
        }

        private void ValidaUnidadeDeMedidaDoInsumo()
        {
            //Validação dos campos
            err_ValidaInsumo.SetError(txt_UnidadeDeMedidaDoInsumo, ValidacaoGenericaDeCampos.VerificaSeOCampoEstaVazio(txt_UnidadeDeMedidaDoInsumo.Text, "a Unidade de Medida do Insumo"));
        }

        private void ValidaValorDaUltimaCompraDoInsumo()
        {
            if (txt_ValorUnitarioDaUltimaCompraDoInsumo.Text == "")
            {
                txt_ValorUnitarioDaUltimaCompraDoInsumo.Text = "0";
                err_ValidaInsumo.SetError(txt_ValorUnitarioDaUltimaCompraDoInsumo, "O preço unitário do Insumo não deve ter valor zero.");
            }
            else if (Convert.ToSingle(txt_ValorUnitarioDaUltimaCompraDoInsumo.Text) == 0)
            {
                err_ValidaInsumo.SetError(txt_ValorUnitarioDaUltimaCompraDoInsumo, "O preço unitário do Insumo não deve ter valor zero.");
            }
            else
            {
                err_ValidaInsumo.SetError(txt_ValorUnitarioDaUltimaCompraDoInsumo, "");
            }
            txt_ValorUnitarioDaUltimaCompraDoInsumo.Text = String.Format("{0:C3}", Convert.ToSingle(txt_ValorUnitarioDaUltimaCompraDoInsumo.Text)).Replace("R$", "");
        }
        #endregion

        private void btn_NovoRegistro_Click(object sender, EventArgs e)
        {
            //Incluir
            InicializaCampos("Incluir");
        }

        private void grd_Insumos_SelectionChanged(object sender, EventArgs e)
        {
            if (bol_HabilitaValidacaoPorTeclado == true && grd_Insumos.SelectedRows.Count > 0)
                CarregaInformacoesDoUsuario();
        }

        private void btn_CancelarAlteracao_Click(object sender, EventArgs e)
        {
            //Cancelar
            InicializaCampos("Cancelar");
        }

        private void frm_CadastroDeInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Alternar pro proximo campo
            if (e.KeyChar == (char)Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void frm_CadastroDeInsumo_Shown(object sender, EventArgs e)
        {
            bol_HabilitaValidacaoPorTeclado = true;
        }

        private void txt_ValorUnitarioDaUltimaCompraDoInsumo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidaValorDaUltimaCompraDoInsumo();
        }

        private void btn_ExcluirRegistro_Click(object sender, EventArgs e)
        {
            //Excluir Registro
            if (MessageBox.Show("Confirma a exclusão do Insumo " + txt_CodigoDoInsumo.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            InicializaCampos("Excluir");
        }

        private void btn_PesquisarRegistro_Click(object sender, EventArgs e)
        {
            PesquisaUsuarioNoGrid();
        }

        //Pesquisa Na tabela o campo digita
        private void PesquisaUsuarioNoGrid()
        {
            if (txt_Pesquisa.Text.Trim() != "")
            {
                InicializaCampos("Pesquisar");
            }
            else
            {
                lst_InsumosCadastrados.RowFilter = null;
                grd_Insumos.Refresh();
            }
        }

        private void txt_Pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PesquisaUsuarioNoGrid();
            }
        }

        private void txt_CodigoDoInsumo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_CodigoDoInsumo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidaCodigoDoInsumo();
        }

        private void txt_NomeDoInsumo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidaNomeDoInsumo();
        }

        private void txt_UnidadeDeMedidaDoInsumo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidaUnidadeDeMedidaDoInsumo();
        }
    }
}
