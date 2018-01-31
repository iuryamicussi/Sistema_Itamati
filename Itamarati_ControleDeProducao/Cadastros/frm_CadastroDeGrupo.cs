using Itamarati_ControleDeProducao.Controller;
using Itamarati_ControleDeProducao.DTO;
using Itamarati_ControleDeProducao.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace Itamarati_ControleDeProducao.Cadastros
{
    public partial class frm_CadastroDeGrupo : Form
    {

        //Objetos
        private DataView lst_GruposCadastrados;
        private GrupoDTO obj_GrupoDTO;
        private GrupoModel obj_GrupoModel = new GrupoModel();

        //Variáveis de controle
        private Boolean bol_HabilitaValidacaoPorTeclado = false;
        private int retornoDaFuncao;

        public frm_CadastroDeGrupo()
        {
            InitializeComponent();
        }

        //Rotina de inicialização de Função
        private void InicializaCampos(string modo)
        {
            int int_GuardaLinhaSelecionada;

            switch (modo)
            {
                case "Incluir":
                    LimpaCampos();
                    txt_CodigoDoGrupo.Enabled = true;
                    HabilitarCampos(true);
                    msk_DataHoraDeCadastroDoGrupo.Text = DateTime.Now.ToString();
                    grd_Grupos.Enabled = false;
                    btn_ExcluirRegistro.Enabled = false;
                    btn_PesquisarRegistro.Enabled = false;
                    txt_Pesquisa.Visible = false;

                    txt_CodigoDoGrupo.Focus();
                    LimpaErrosEncontrados();
                    break;

                case "SalvarNovo":
                    obj_GrupoDTO = new GrupoDTO();

                    try
                    {
                        //Carrega o objeto com os campos digitados
                        obj_GrupoDTO.CodigoDoGrupo = Convert.ToInt32(txt_CodigoDoGrupo.Text);
                        obj_GrupoDTO.NomeDoGrupo = txt_NomeDoGrupo.Text;
                        obj_GrupoDTO.DataHoraDeCadastroDoGrupo = Convert.ToDateTime(msk_DataHoraDeCadastroDoGrupo.Text);

                        //Insere as informações no Banco
                        retornoDaFuncao = obj_GrupoModel.IncluirNovoGrupo(obj_GrupoDTO);

                        if (retornoDaFuncao > 0)
                        {
                            MessageBox.Show("Grupo cadastrado com sucesso!", "Grupo Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O grupo não foi cadastrado!");
                        }

                        grd_Grupos.Enabled = true;

                        //Recarrega a Tabela de Grupos e seleciona o registro criado
                        bol_HabilitaValidacaoPorTeclado = false;
                        CarregaGruposNoGrid();
                        grd_Grupos.Rows[grd_Grupos.Rows.Count - 1].Selected = true;
                        CarregaInformacoesDoGrupo();
                        bol_HabilitaValidacaoPorTeclado = true;
                        HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa();
                        btn_ExcluirRegistro.Enabled = true;
                        btn_PesquisarRegistro.Enabled = true;
                        txt_Pesquisa.Visible = true;
                        HabilitarCampos(true);
                        LimpaErrosEncontrados();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Salvar":

                    obj_GrupoDTO = new GrupoDTO();

                    try
                    {
                        //Carrega o objeto com os campos digitados
                        obj_GrupoDTO.NomeDoGrupo = txt_NomeDoGrupo.Text;
                        obj_GrupoDTO.DataHoraDeCadastroDoGrupo = Convert.ToDateTime(msk_DataHoraDeCadastroDoGrupo.Text);

                        //Insere as informações no Banco
                        retornoDaFuncao = obj_GrupoModel.AtualizaInformacoesDoGrupo(obj_GrupoDTO, Convert.ToInt32(grd_Grupos.CurrentRow.Cells[0].Value));

                        if (retornoDaFuncao > 0)
                        {
                            MessageBox.Show("Informações salvas com sucesso!", "Grupo Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O grupo não foi salvo!", "Erro no salvamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        //Recarrega a Tabela de Grupos e seleciona o registro criado
                        bol_HabilitaValidacaoPorTeclado = false;
                        int_GuardaLinhaSelecionada = grd_Grupos.SelectedRows[0].Index;
                        CarregaGruposNoGrid();
                        CarregaInformacoesDoGrupo();
                        bol_HabilitaValidacaoPorTeclado = true;
                        btn_ExcluirRegistro.Enabled = true;
                        btn_PesquisarRegistro.Enabled = true;
                        txt_Pesquisa.Visible = true;
                        HabilitarCampos(true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Cancelar":

                    if (grd_Grupos.Rows.Count > 0)
                    {
                        CarregaInformacoesDoGrupo();
                        txt_NomeDoGrupo.Focus();
                    }
                    else
                    {
                        LimpaCampos();
                        HabilitarCampos(false);
                    }

                    txt_CodigoDoGrupo.Enabled = false;
                    grd_Grupos.Enabled = true;
                    HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa();
                    LimpaErrosEncontrados();
                    break;

                case "Excluir":

                    obj_GrupoDTO = new GrupoDTO();

                    try
                    {
                        //Carrega o objeto com os campos digitados
                        obj_GrupoDTO.CodigoDoGrupo = Convert.ToInt32(grd_Grupos.SelectedRows[0].Cells[0].FormattedValue);
                        obj_GrupoDTO.NomeDoGrupo = txt_NomeDoGrupo.Text;
                        obj_GrupoDTO.DataHoraDeCadastroDoGrupo = Convert.ToDateTime(msk_DataHoraDeCadastroDoGrupo.Text);


                        retornoDaFuncao = obj_GrupoModel.ExcluiInformacoesDoGrupo(obj_GrupoDTO);

                        if (retornoDaFuncao > 0)
                        {
                            MessageBox.Show("Grupo removido com sucesso!", "Grupo Removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O Grupo não foi removido!", "Erro ao Remover Grupo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }                       

                        grd_Grupos.Enabled = true;

                        //Recarrega a Tabela de Grupos e seleciona o registro criado
                        bol_HabilitaValidacaoPorTeclado = false;
                        CarregaGruposNoGrid();

                        if (grd_Grupos.Rows.Count > 0)
                        {
                            CarregaInformacoesDoGrupo();
                            txt_NomeDoGrupo.Focus();
                        }
                        else
                        {
                            LimpaCampos();
                            HabilitarCampos(false);
                        }

                        bol_HabilitaValidacaoPorTeclado = true;
                        HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa();
                        LimpaErrosEncontrados();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao excluir o Grupo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Pesquisar":

                    lst_GruposCadastrados.RowFilter = "NomeDoGrupo Like '" + txt_Pesquisa.Text.Trim() + "%'";
                    grd_Grupos.Refresh();
                    grd_Grupos.Focus();

                    break;
            }
        }

        #region Métodos de Controle
        //Carregar Grupos no Grid
        private void CarregaGruposNoGrid()
        {
            try
            {
                grd_Grupos.DataSource = null;
                grd_Grupos.Rows.Clear();
                grd_Grupos.Refresh();

                lst_GruposCadastrados = new DataView();
                lst_GruposCadastrados = obj_GrupoModel.BuscaListaDeGruposCadastrados();

                grd_Grupos.AutoGenerateColumns = false;

                grd_Grupos.DataSource = lst_GruposCadastrados;
                grd_Grupos.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Carregar informações do Grid nos campos
        private void CarregaInformacoesDoGrupo()
        {
            txt_CodigoDoGrupo.Enabled = false;
            txt_CodigoDoGrupo.Text = grd_Grupos.SelectedRows[0].Cells[0].FormattedValue.ToString();
            txt_NomeDoGrupo.Text = grd_Grupos.SelectedRows[0].Cells[1].FormattedValue.ToString();
            msk_DataHoraDeCadastroDoGrupo.Text = grd_Grupos.SelectedRows[0].Cells[2].FormattedValue.ToString();
        }

        //Limpa os campos para um novo registro
        private void LimpaCampos()
        {
            txt_CodigoDoGrupo.Text = "";
            txt_NomeDoGrupo.Text = "";
            msk_DataHoraDeCadastroDoGrupo.Text = "";
        }

        //Reseta Erros da tela
        private void LimpaErrosEncontrados()
        {
            err_ValidaGrupo.SetError(txt_CodigoDoGrupo, "");
            err_ValidaGrupo.SetError(txt_NomeDoGrupo, "");
        }

        //Habilita/Desabilita campo
        private void HabilitarCampos(Boolean bol_Modo)
        {
            txt_NomeDoGrupo.Enabled = bol_Modo;
        }

        //Desabilita botoes quando não existem registros
        private void HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa()
        {
            if (grd_Grupos.Rows.Count > 0)
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

        //Pesquisa Na tabela o campo digita
        private void PesquisaGrupoNoGrid()
        {
            if (txt_Pesquisa.Text.Trim() != "")
            {
                InicializaCampos("Pesquisar");
            }
            else
            {
                lst_GruposCadastrados.RowFilter = null;
                grd_Grupos.Refresh();
            }
        }
        #endregion

        #region Métodos de Validação
        //Validações dos Campos
        private void ValidaCodigoDoGrupo()
        {
            //Validação dos campos
            err_ValidaGrupo.SetError(txt_CodigoDoGrupo, ValidacaoGenericaDeCampos.VerificaSeOCampoEstaVazio(txt_CodigoDoGrupo.Text, "o Código do Grupo"));

            if (err_ValidaGrupo.GetError(txt_CodigoDoGrupo) == "")
            {
                txt_CodigoDoGrupo.Text = txt_CodigoDoGrupo.Text.PadLeft(3, '0');
                err_ValidaGrupo.SetError(txt_CodigoDoGrupo, obj_GrupoModel.VerificaSeOCodigoDigitadoJaEstaSendoUsado(Convert.ToInt32(txt_CodigoDoGrupo.Text)));
            }
        }

        private void ValidaNomeDoGrupo()
        {
            //Valida se o campo está vazio
            err_ValidaGrupo.SetError(txt_NomeDoGrupo, ValidacaoGenericaDeCampos.VerificaSeOCampoEstaVazio(txt_NomeDoGrupo.Text, "o Nome do Grupo"));
        }
        #endregion

        #region Funções de componentes da Tela

        private void btn_NovoRegistro_Click(object sender, EventArgs e)
        {
            //Incluir
            InicializaCampos("Incluir");
        }

        private void btn_SalvarRegistro_Click(object sender, EventArgs e)
        {
            //Validação dos campos
            if (grd_Grupos.Enabled == false)
            {
                ValidaCodigoDoGrupo();
            }
            ValidaNomeDoGrupo();

            //Verificação se existem campos incorretos
            if (err_ValidaGrupo.GetError(txt_CodigoDoGrupo) != "")
            {
                MessageBox.Show(err_ValidaGrupo.GetError(txt_CodigoDoGrupo), "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_CodigoDoGrupo.Focus();
                return;
            }

            if (err_ValidaGrupo.GetError(txt_NomeDoGrupo) != "")
            {
                MessageBox.Show(err_ValidaGrupo.GetError(txt_NomeDoGrupo), "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NomeDoGrupo.Focus();
                return;
            }

            //Salva o Registro
            if (grd_Grupos.Enabled == false)
            {
                InicializaCampos("SalvarNovo");
            }
            else
            {
                InicializaCampos("Salvar");
            }
        }

        private void btn_CancelarAlteracao_Click(object sender, EventArgs e)
        {
            //Cancelar
            InicializaCampos("Cancelar");
        }

        private void btn_ExcluirRegistro_Click(object sender, EventArgs e)
        {
            //Excluir Registro
            if (MessageBox.Show("Confirma a exclusão do Grupo " + txt_CodigoDoGrupo.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            InicializaCampos("Excluir");
        }

        private void frm_CadastroDeGrupo_Load(object sender, EventArgs e)
        {
            //Inicializa a Tela
            CarregaGruposNoGrid();

            //Se não houver nenhum no bancon, bloqueia os campos
            if (grd_Grupos.RowCount <= 0)
            {
                HabilitarCampos(false);
            }
            else
            {
                CarregaInformacoesDoGrupo();
            }
            HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa();
        }

        private void grd_Grupos_SelectionChanged(object sender, EventArgs e)
        {
            if (bol_HabilitaValidacaoPorTeclado == true && grd_Grupos.SelectedRows.Count > 0)
                CarregaInformacoesDoGrupo();
        }

        private void frm_CadastroDeGrupo_Shown(object sender, EventArgs e)
        {
            bol_HabilitaValidacaoPorTeclado = true;
        }

        private void btn_PesquisarRegistro_Click(object sender, EventArgs e)
        {
            PesquisaGrupoNoGrid();
        }

        private void txt_Pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PesquisaGrupoNoGrid();
            }
        }

        private void frm_CadastroDeGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txt_CodigoDoGrupo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidaCodigoDoGrupo();
        }

        private void txt_NomeDoGrupo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidaNomeDoGrupo();
        }

        private void txt_CodigoDoGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
