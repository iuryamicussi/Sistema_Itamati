using Itamarati_ControleDeProducao.Controller;
using Itamarati_ControleDeProducao.DTO;
using Itamarati_ControleDeProducao.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itamarati_ControleDeProducao.Cadastros
{
    public partial class frm_CadastroDeProduto : Form
    {
        //Objetos
        private DataView lst_ProdutosCadastrados;
        private DataView lst_ComposicaoDoProduto;
        private DataView lst_ComposicaoDoProdutoParaImportar;
        private ProdutoDTO obj_ProdutoDTO;
        private ProdutoModel obj_ProdutoModel = new ProdutoModel();
        private GrupoModel obj_GrupoModel = new GrupoModel();
        private InsumoModel obj_InsumoModel = new InsumoModel();
        private ItemDaComposicaoModel obj_ItemDaComposicaoModel = new ItemDaComposicaoModel();

        //Variáveis de controle
        private Boolean bol_HabilitaValidacaoPorTeclado = false;
        private int retornoDaFuncao;
        private float flt_TotalDoProduto;

        public frm_CadastroDeProduto()
        {
            InitializeComponent();
        }

        private void frm_CadastroDeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        //Rotina de inicialização de Função
        private void InicializaCampos(string modo)
        {
            int int_GuardaLinhaSelecionada;
            ItemDaComposicaoDTO obj_ItemDaComposicaoDTO;

            switch(modo)
            {
                case "Incluir":
                    CarregaInformacoesDoGrupoNoCombo();
                    LimpaCampos();
                    txt_CodigoDoProduto.Enabled = true;
                    HabilitarCampos(true);
                    msk_DataHoraDeCadastroDoInsumo.Text = DateTime.Now.ToString();
                    grd_Produto.Enabled = false;
                    btn_ExcluirRegistro.Enabled = false;
                    btn_PesquisarRegistro.Enabled = false;
                    txt_PesquisaProduto.Visible = false;
                    flt_TotalDoProduto = 0;

                    if (cmb_GrupoDoProduto.Items.Count > 0)
                    {
                        cmb_GrupoDoProduto.SelectedIndex = 0;
                    }

                    txt_CodigoDoProduto.Focus();
                    LimpaErrosEncontrados();
                    break;

                case "SalvarNovo":

                    obj_ProdutoDTO = new ProdutoDTO();

                    try
                    {
                        //Carrega o objeto com os campos digitados
                        obj_ProdutoDTO.CodigoDoProduto = Convert.ToInt32(txt_CodigoDoProduto.Text);
                        obj_ProdutoDTO.DescricaoDoProduto = txt_DescricaoDoProduto.Text;
                        obj_ProdutoDTO.DataHoraDeCadastroDoProduto = Convert.ToDateTime(msk_DataHoraDeCadastroDoInsumo.Text);
                        obj_ProdutoDTO.LarguraDoProduto = Convert.ToSingle(txt_LarguraDoProduto.Text);
                        obj_ProdutoDTO.ComprimentoDoProduto = Convert.ToSingle(txt_ComprimentoDoProduto.Text);
                        obj_ProdutoDTO.EspessuraDoProduto = Convert.ToSingle(txt_EspessuraDoProduto.Text);
                        obj_ProdutoDTO.PesoTotalDoProduto = Convert.ToSingle(txt_PesoDoProduto.Text);
                        obj_ProdutoDTO.GrupoDoProduto = obj_GrupoModel.BuscaGrupoPorCodigo(Convert.ToInt32(cmb_GrupoDoProduto.Text.Substring(0,3)));

                        //Insere os itens na lista do produto
                        if (grd_ComposicaoDoProduto.RowCount > 1)
                        {
                            foreach (DataGridViewRow row_ItemDaComposicaoDoProduto in grd_ComposicaoDoProduto.Rows)
                            {
                                if (row_ItemDaComposicaoDoProduto.Cells[0].Value != null)
                                {
                                    obj_ItemDaComposicaoDTO = new ItemDaComposicaoDTO();
                                    obj_ItemDaComposicaoDTO.Insumo.CodigoDoInsumo = Convert.ToInt32(row_ItemDaComposicaoDoProduto.Cells[0].Value);
                                    obj_ItemDaComposicaoDTO.QuantidadeDoItem = Convert.ToSingle(row_ItemDaComposicaoDoProduto.Cells[3].Value);
                                    obj_ItemDaComposicaoDTO.TotalDoItem = Convert.ToSingle(row_ItemDaComposicaoDoProduto.Cells[5].Value);

                                    obj_ProdutoDTO.InsereItemDaComposicao(obj_ItemDaComposicaoDTO);
                                }
                            }
                        }

                        //Insere as informações no Banco
                        retornoDaFuncao = obj_ProdutoModel.IncluirNovoProduto(obj_ProdutoDTO);

                        if (retornoDaFuncao > 0)
                        {
                            MessageBox.Show("Produto cadastrado com sucesso!", "Produto Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O Produto não foi cadastrado!");
                        }

                        grd_Produto.Enabled = true;

                        //Recarrega a Tabela de Usuários e seleciona o registro criado
                        bol_HabilitaValidacaoPorTeclado = false;
                        CarregaProdutosNoGrid();
                        grd_Produto.Rows[grd_Produto.Rows.Count - 1].Selected = true;
                        CarregaInformacoesDoProduto();
                        bol_HabilitaValidacaoPorTeclado = true;
                        HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Salvar":

                    obj_ProdutoDTO = new ProdutoDTO();

                    try
                    {
                        //Carrega o objeto com os campos digitados
                        obj_ProdutoDTO.CodigoDoProduto = Convert.ToInt32(txt_CodigoDoProduto.Text);
                        obj_ProdutoDTO.DescricaoDoProduto = txt_DescricaoDoProduto.Text;
                        obj_ProdutoDTO.DataHoraDeCadastroDoProduto = Convert.ToDateTime(msk_DataHoraDeCadastroDoInsumo.Text);
                        obj_ProdutoDTO.LarguraDoProduto = Convert.ToSingle(txt_LarguraDoProduto.Text);
                        obj_ProdutoDTO.ComprimentoDoProduto = Convert.ToSingle(txt_ComprimentoDoProduto.Text);
                        obj_ProdutoDTO.EspessuraDoProduto = Convert.ToSingle(txt_EspessuraDoProduto.Text);
                        obj_ProdutoDTO.PesoTotalDoProduto = Convert.ToSingle(txt_PesoDoProduto.Text);
                        obj_ProdutoDTO.GrupoDoProduto = obj_GrupoModel.BuscaGrupoPorCodigo(Convert.ToInt32(cmb_GrupoDoProduto.Text.Substring(0, 3)));

                        //Insere os itens na lista do produto
                        foreach (DataGridViewRow row_ItemDaComposicaoDoProduto in grd_ComposicaoDoProduto.Rows)
                        {
                            if (row_ItemDaComposicaoDoProduto.Cells[0].FormattedValue.ToString() != "")
                            {
                                obj_ItemDaComposicaoDTO = new ItemDaComposicaoDTO();
                                obj_ItemDaComposicaoDTO.Insumo.CodigoDoInsumo = Convert.ToInt32(row_ItemDaComposicaoDoProduto.Cells[0].Value);
                                obj_ItemDaComposicaoDTO.QuantidadeDoItem = Convert.ToSingle(row_ItemDaComposicaoDoProduto.Cells[3].Value);
                                obj_ItemDaComposicaoDTO.TotalDoItem = Convert.ToSingle(row_ItemDaComposicaoDoProduto.Cells[5].Value);

                                obj_ProdutoDTO.InsereItemDaComposicao(obj_ItemDaComposicaoDTO);
                            }
                        }

                        //Insere as informações no Banco
                        retornoDaFuncao = obj_ProdutoModel.AtualizaInformacoesDoProduto(obj_ProdutoDTO, Convert.ToInt32(grd_Produto.CurrentRow.Cells[0].FormattedValue));

                        if (retornoDaFuncao > 0)
                        {
                            MessageBox.Show("Informações salvas com sucesso!", "Usuário Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O Produto não foi salvo!");
                        }

                        //Recarrega a Tabela de Produto e seleciona o registro criado
                        bol_HabilitaValidacaoPorTeclado = false;
                        int_GuardaLinhaSelecionada = grd_Produto.SelectedRows[0].Index;
                        CarregaProdutosNoGrid();
                        grd_Produto.Rows[int_GuardaLinhaSelecionada].Selected = true;
                        CarregaInformacoesDoProduto();
                        bol_HabilitaValidacaoPorTeclado = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Cancelar":

                    CarregaInformacoesDoGrupoNoCombo();
                    if (grd_Produto.Rows.Count > 0)
                    {
                        CarregaInformacoesDoProduto();
                        txt_DescricaoDoProduto.Focus();
                    }
                    else
                    {
                        LimpaCampos();
                        HabilitarCampos(false);
                    }

                    txt_CodigoDoProduto.Enabled = false;
                    grd_Produto.Enabled = true;
                    HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa();
                    LimpaErrosEncontrados();

                    break;

                case "Excluir":

                    obj_ProdutoDTO = new ProdutoDTO();

                    try
                    {
                        //Carrega o objeto com os campos digitados
                        obj_ProdutoDTO.CodigoDoProduto = Convert.ToInt32(txt_CodigoDoProduto.Text);
                        obj_ProdutoDTO.DescricaoDoProduto = txt_DescricaoDoProduto.Text;
                        obj_ProdutoDTO.DataHoraDeCadastroDoProduto = Convert.ToDateTime(msk_DataHoraDeCadastroDoInsumo.Text);
                        obj_ProdutoDTO.LarguraDoProduto = Convert.ToSingle(txt_LarguraDoProduto.Text);
                        obj_ProdutoDTO.ComprimentoDoProduto = Convert.ToSingle(txt_ComprimentoDoProduto.Text);
                        obj_ProdutoDTO.EspessuraDoProduto = Convert.ToSingle(txt_EspessuraDoProduto.Text);
                        obj_ProdutoDTO.PesoTotalDoProduto = Convert.ToSingle(txt_PesoDoProduto.Text);

                        //Insere os itens na lista do produto
                        foreach (DataGridViewRow row_ItemDaComposicaoDoProduto in grd_ComposicaoDoProduto.Rows)
                        {
                            obj_ItemDaComposicaoDTO = new ItemDaComposicaoDTO();
                            obj_ItemDaComposicaoDTO.Insumo.CodigoDoInsumo = Convert.ToInt32(row_ItemDaComposicaoDoProduto.Cells[0].Value);
                            obj_ItemDaComposicaoDTO.QuantidadeDoItem = Convert.ToSingle(row_ItemDaComposicaoDoProduto.Cells[3].Value);
                            obj_ItemDaComposicaoDTO.TotalDoItem = Convert.ToSingle(row_ItemDaComposicaoDoProduto.Cells[5].Value);

                            obj_ProdutoDTO.InsereItemDaComposicao(obj_ItemDaComposicaoDTO);
                        }

                        //Exclui o usuário
                        retornoDaFuncao = obj_ProdutoModel.ExcluiInformacoesDoProduto(obj_ProdutoDTO);

                        if (retornoDaFuncao > 0)
                        {
                            MessageBox.Show("Produto removido com sucesso!", "Produto Removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O Produto não foi removido!", "Erro ao Remover Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        grd_Produto.Enabled = true;

                        //Recarrega a Tabela de Usuários e seleciona o registro criado
                        bol_HabilitaValidacaoPorTeclado = false;
                        CarregaProdutosNoGrid();

                        if (grd_Produto.Rows.Count > 0)
                        {
                            CarregaInformacoesDoProduto();
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

                    lst_ProdutosCadastrados.RowFilter = "DescricaoDoProduto Like '" + txt_PesquisaProduto.Text.Trim() + "%'";
                    grd_Produto.Refresh();
                    grd_Produto.Focus();

                    break;
            }
        }

        //Reseta Erros da tela
        private void LimpaErrosEncontrados()
        {
            err_ValidaProduto.SetError(txt_CodigoDoProduto, "");
            err_ValidaProduto.SetError(txt_DescricaoDoProduto, "");
            err_ValidaProduto.SetError(txt_LarguraDoProduto, "");
            err_ValidaProduto.SetError(txt_ComprimentoDoProduto, "");
            err_ValidaProduto.SetError(txt_EspessuraDoProduto, "");
            err_ValidaProduto.SetError(cmb_GrupoDoProduto, "");
        }

        //Carregar Usuários no ComboBox
        private void CarregaProdutosNoGrid()
        {
            try
            {
                grd_Produto.DataSource = null;
                grd_Produto.Rows.Clear();
                grd_Produto.Refresh();

                lst_ProdutosCadastrados = new DataView();
                lst_ProdutosCadastrados = obj_ProdutoModel.BuscaListaDeProdutosCadastrados();

                grd_Produto.AutoGenerateColumns = false;

                grd_Produto.DataSource = lst_ProdutosCadastrados;
                grd_Produto.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Carregar informações do Grid nos campos
        private void CarregaInformacoesDoProduto()
        {
            txt_CodigoDoProduto.Enabled = false;
            txt_CodigoDoProduto.Text = grd_Produto.SelectedRows[0].Cells[0].FormattedValue.ToString();
            txt_DescricaoDoProduto.Text = grd_Produto.SelectedRows[0].Cells[1].FormattedValue.ToString();
            msk_DataHoraDeCadastroDoInsumo.Text = grd_Produto.SelectedRows[0].Cells[7].FormattedValue.ToString();
            txt_LarguraDoProduto.Text = grd_Produto.SelectedRows[0].Cells[2].FormattedValue.ToString();
            txt_ComprimentoDoProduto.Text = grd_Produto.SelectedRows[0].Cells[3].FormattedValue.ToString();
            txt_EspessuraDoProduto.Text = grd_Produto.SelectedRows[0].Cells[4].FormattedValue.ToString();
            txt_PesoDoProduto.Text = grd_Produto.SelectedRows[0].Cells[5].FormattedValue.ToString();
            cmb_GrupoDoProduto.Text = grd_Produto.SelectedRows[0].Cells[8].FormattedValue.ToString();

            CarregaInformacoesDaComposicaoDoProduto(Convert.ToInt32(grd_Produto.SelectedRows[0].Cells[0].FormattedValue));

            //Carrega variável auxiliar para o cálculo do total do produto
            flt_TotalDoProduto = CalculaCustoTotalDoProduto();
            txt_CustoTotalDoProduto.Text = String.Format("{0:C3}", flt_TotalDoProduto);
        }

        //Carrega Grupos no Combobox
        private void CarregaInformacoesDoGrupoNoCombo()
        {
            cmb_GrupoDoProduto.DataSource = null;
            cmb_GrupoDoProduto.Items.Clear();
            cmb_GrupoDoProduto.DataSource = obj_GrupoModel.BuscaInformacoesDoGrupoParaCombo();
        }

        //Carrega Tabela de Composição
        private void CarregaInformacoesDaComposicaoDoProduto(int int_CodigoDoProduto)
        {
            try
            {
                grd_ComposicaoDoProduto.DataSource = null;
                grd_ComposicaoDoProduto.Rows.Clear();
                grd_ComposicaoDoProduto.Refresh();

                lst_ComposicaoDoProduto = new DataView();
                lst_ComposicaoDoProduto = obj_ItemDaComposicaoModel.BuscaListaDeItemDaComposicaoDoProduto(int_CodigoDoProduto);

                grd_ComposicaoDoProduto.AutoGenerateColumns = false;

                grd_ComposicaoDoProduto.DataSource = lst_ComposicaoDoProduto;
                grd_ComposicaoDoProduto.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Limpa os campos para um novo registro
        private void LimpaCampos()
        {
            txt_CodigoDoProduto.Text = "";
            txt_DescricaoDoProduto.Text = "";
            msk_DataHoraDeCadastroDoInsumo.Text = "";
            txt_LarguraDoProduto.Text = "0,000";
            txt_ComprimentoDoProduto.Text = "0,000";
            txt_EspessuraDoProduto.Text = "0,000";
            txt_PesoDoProduto.Text = "0,000";
            txt_CustoTotalDoProduto.Text = "R$ 0,000";
            cmb_GrupoDoProduto.SelectedIndex = -1;
            cmb_GrupoDoProduto.Text = "";

            grd_ComposicaoDoProduto.DataSource = null;
            grd_ComposicaoDoProduto.Rows.Clear();
            grd_ComposicaoDoProduto.Refresh();
        }

        //Habilita/Desabilita campo
        private void HabilitarCampos(Boolean bol_Modo)
        {
            txt_DescricaoDoProduto.Enabled = bol_Modo;
            txt_LarguraDoProduto.Enabled = bol_Modo;
            txt_ComprimentoDoProduto.Enabled = bol_Modo;
            txt_EspessuraDoProduto.Enabled = bol_Modo;
            grd_ComposicaoDoProduto.Enabled = bol_Modo;
            cmb_GrupoDoProduto.Enabled = bol_Modo;
        }

        //Desabilita botoes quando não existem registros
        private void HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa()
        {
            if (grd_Produto.Rows.Count > 0)
            {
                btn_ExcluirRegistro.Enabled = true;
                txt_PesquisaProduto.Visible = true;
                btn_PesquisarRegistro.Enabled = true;
            }
            else
            {
                btn_ExcluirRegistro.Enabled = false;
                txt_PesquisaProduto.Visible = false;
                btn_PesquisarRegistro.Enabled = false;
            }
        }

        //Pesquisa Na tabela o campo digita
        private void PesquisaProdutoNoGrid()
        {
            if (txt_PesquisaProduto.Text.Trim() != "")
            {
                InicializaCampos("Pesquisar");
            }
            else
            {
                lst_ProdutosCadastrados.RowFilter = null;
                grd_Produto.Refresh();
            }
        }

        //Cálculo do Peso total
        private void CalculaPesoDoProduto()
        {
            float flt_Total = Convert.ToSingle(txt_LarguraDoProduto.Text) * Convert.ToSingle(txt_ComprimentoDoProduto.Text) * Convert.ToSingle(txt_EspessuraDoProduto.Text);
            txt_PesoDoProduto.Text = String.Format("{0:C4}", flt_Total).Replace("R$", "").Trim();
        }

        //Cálculo do Total de Custo do produto
        private float CalculaCustoTotalDoProduto()
        {
            float flt_Total = 0;

            foreach(DataGridViewRow dtr_Insumo in grd_ComposicaoDoProduto.Rows)
            {
                if(dtr_Insumo.Cells[5].Value != null)
                {
                    flt_Total += Convert.ToSingle(dtr_Insumo.Cells[5].Value);
                }
            }
            return flt_Total;
        }

        //Cálculo do total do item da composição
        private void CalculaTotalDoItemDaComposicao(int int_NumeroDaLinha)
        {
            if (grd_ComposicaoDoProduto[3, int_NumeroDaLinha].FormattedValue.ToString() != "")
            {
                float flt_TotalDoItemDaComposicao = Convert.ToSingle(grd_ComposicaoDoProduto[3, int_NumeroDaLinha].Value) * Convert.ToSingle(grd_ComposicaoDoProduto[4, int_NumeroDaLinha].Value);
                grd_ComposicaoDoProduto[5, int_NumeroDaLinha].Value = String.Format("{0:C3}", flt_TotalDoItemDaComposicao).Replace("R$", "").Trim();
            }
        }

        //Importa Composição de um Produto
        private void ImportaComposicao(int int_CodigoDoProduto)
        {
            try
            { 
                lst_ComposicaoDoProdutoParaImportar = new DataView();
                lst_ComposicaoDoProdutoParaImportar = obj_ItemDaComposicaoModel.BuscaListaDeItemDaComposicaoDoProduto(int_CodigoDoProduto);

                foreach(DataRowView drv_ItemDaComposicao in lst_ComposicaoDoProdutoParaImportar)
                {
                    if(VerificaSeInsumoEstaNaComposicao(Convert.ToInt32(drv_ItemDaComposicao[0])) == false)
                    {
                        grd_ComposicaoDoProduto.Rows.Add();
                        grd_ComposicaoDoProduto.Rows[grd_ComposicaoDoProduto.Rows.Count - 2].Cells[0].Value = drv_ItemDaComposicao[0].ToString();
                        grd_ComposicaoDoProduto.Rows[grd_ComposicaoDoProduto.Rows.Count - 2].Cells[1].Value = drv_ItemDaComposicao[1].ToString();
                        grd_ComposicaoDoProduto.Rows[grd_ComposicaoDoProduto.Rows.Count - 2].Cells[2].Value = drv_ItemDaComposicao[2].ToString();
                        grd_ComposicaoDoProduto.Rows[grd_ComposicaoDoProduto.Rows.Count - 2].Cells[3].Value = String.Format("{0:C3}", drv_ItemDaComposicao[3]).Replace("R$", "").Trim();
                        grd_ComposicaoDoProduto.Rows[grd_ComposicaoDoProduto.Rows.Count - 2].Cells[4].Value = String.Format("{0:C3}", drv_ItemDaComposicao[4]).Replace("R$", "").Trim();
                        grd_ComposicaoDoProduto.Rows[grd_ComposicaoDoProduto.Rows.Count - 2].Cells[5].Value = String.Format("{0:C3}", drv_ItemDaComposicao[5]).Replace("R$", "").Trim();
                    }
                }

                txt_CustoTotalDoProduto.Text = String.Format("{0:C3}", CalculaCustoTotalDoProduto());;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um erro na importação da composição do Produto " + ex.Message, "Erro na importação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Verifica se um insumo já está na composição do produto
        private bool VerificaSeInsumoEstaNaComposicao(int int_CodigoDoInsumo)
        {

            foreach (DataGridViewRow dgr_ItemDaComposicao in grd_ComposicaoDoProduto.Rows)
            {
                if (dgr_ItemDaComposicao.Index != grd_ComposicaoDoProduto.Rows.Count - 1)
                {
                    if (int_CodigoDoInsumo == Convert.ToInt32(dgr_ItemDaComposicao.Cells[0].Value))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        //Verifica se Existem insumos com quantidade zero
        private bool VerificaSeExistemInsumosComQuantidadeZero()
        {
            foreach (DataGridViewRow dgr_ItemDaComposicao in grd_ComposicaoDoProduto.Rows)
            {
                if (dgr_ItemDaComposicao.Cells[3].FormattedValue.ToString() != "")
                {
                    if (Convert.ToSingle(dgr_ItemDaComposicao.Cells[3].Value) <= 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Retorna Lista de Códigos de Insumos da lista
        private IList<string> RetornaListaDeInsumosNaLista()
        {
            IList<string> lst_InsumosNaLista = new List<string>();

            foreach(DataGridViewRow dgr_ItemDaComposicao in grd_ComposicaoDoProduto.Rows)
            {
                if (dgr_ItemDaComposicao.Cells[0].FormattedValue.ToString() != "")
                {
                    lst_InsumosNaLista.Add(dgr_ItemDaComposicao.Cells[0].Value.ToString());
                }
            }
            return lst_InsumosNaLista;
        }

        #region Métodos de Validação
        private void ValidaCodigoDoProduto()
        {
            //Validação dos campos
            err_ValidaProduto.SetError(txt_CodigoDoProduto, ValidacaoGenericaDeCampos.VerificaSeOCampoEstaVazio(txt_CodigoDoProduto.Text, "o Código do Produto"));

            if (err_ValidaProduto.GetError(txt_CodigoDoProduto) == "")
            {
                txt_CodigoDoProduto.Text = txt_CodigoDoProduto.Text.PadLeft(6, '0');
                err_ValidaProduto.SetError(txt_CodigoDoProduto, obj_ProdutoModel.VerificaSeOCodigoDigitadoJaEstaSendoUsado(Convert.ToInt32(txt_CodigoDoProduto.Text)));
            }
        }

        private void ValidaDescricaoDoProduto()
        {
            //Validação dos campos
            err_ValidaProduto.SetError(txt_DescricaoDoProduto, ValidacaoGenericaDeCampos.VerificaSeOCampoEstaVazio(txt_DescricaoDoProduto.Text, "a Descrição do Produto"));
        }

        private void ValidaMedidasDoProduto()
        {
            //Largura
            if (txt_LarguraDoProduto.Text == "")
            {
                txt_LarguraDoProduto.Text = "0";
                err_ValidaProduto.SetError(txt_LarguraDoProduto, "A largura do produto não deve ter valor zero.");
            }
            else if (Convert.ToSingle(txt_LarguraDoProduto.Text) == 0)
            {
                err_ValidaProduto.SetError(txt_LarguraDoProduto, "A largura do produto não deve ter valor zero.");
            }
            else
            {
                err_ValidaProduto.SetError(txt_LarguraDoProduto, "");
            }
            txt_LarguraDoProduto.Text = String.Format("{0:C4}", Convert.ToSingle(txt_LarguraDoProduto.Text)).Replace("R$", "");

            //Comprimento
            if (txt_ComprimentoDoProduto.Text == "")
            {
                txt_ComprimentoDoProduto.Text = "0";
                err_ValidaProduto.SetError(txt_ComprimentoDoProduto, "O comprimento do produto não deve ter valor zero.");
            }
            else if (Convert.ToSingle(txt_ComprimentoDoProduto.Text) == 0)
            {
                err_ValidaProduto.SetError(txt_ComprimentoDoProduto, "O comprimento do produto não deve ter valor zero.");
            }
            else
            {
                err_ValidaProduto.SetError(txt_ComprimentoDoProduto, "");
            }
            txt_ComprimentoDoProduto.Text = String.Format("{0:C4}", Convert.ToSingle(txt_ComprimentoDoProduto.Text)).Replace("R$", "");

            //Espessura
            if (txt_EspessuraDoProduto.Text == "")
            {
                txt_EspessuraDoProduto.Text = "0";
                err_ValidaProduto.SetError(txt_EspessuraDoProduto, "A espessura do produto não deve ter valor zero.");
            }
            else if (Convert.ToSingle(txt_EspessuraDoProduto.Text) == 0)
            {
                err_ValidaProduto.SetError(txt_EspessuraDoProduto, "A espessura do produto não deve ter valor zero.");
            }
            else
            {
                err_ValidaProduto.SetError(txt_EspessuraDoProduto, "");
            }
            txt_EspessuraDoProduto.Text = String.Format("{0:C4}", Convert.ToSingle(txt_EspessuraDoProduto.Text)).Replace("R$", "");

            CalculaPesoDoProduto();
        }
        #endregion

        #region Funções da Tela

        private void btn_NovoRegistro_Click(object sender, EventArgs e)
        {
            //Incluir
            InicializaCampos("Incluir");
        }

        private void btn_SalvarRegistro_Click(object sender, EventArgs e)
        {
            //Valida Campos antes de salvar
            if (grd_Produto.Enabled == false)
            {
                ValidaCodigoDoProduto();
            }
            ValidaDescricaoDoProduto();
            ValidaMedidasDoProduto();

            //Verifica se existem campos incorretos
            if (err_ValidaProduto.GetError(txt_CodigoDoProduto) != "")
            {
                MessageBox.Show(err_ValidaProduto.GetError(txt_CodigoDoProduto), "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_CodigoDoProduto.Focus();
                return;
            }

            if (err_ValidaProduto.GetError(txt_DescricaoDoProduto) != "")
            {
                MessageBox.Show(err_ValidaProduto.GetError(txt_DescricaoDoProduto), "Descrição Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DescricaoDoProduto.Focus();
                return;
            }

            if (err_ValidaProduto.GetError(txt_LarguraDoProduto) != "")
            {
                MessageBox.Show(err_ValidaProduto.GetError(txt_LarguraDoProduto), "Largura Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LarguraDoProduto.Focus();
                return;
            }

            if (err_ValidaProduto.GetError(txt_ComprimentoDoProduto) != "")
            {
                MessageBox.Show(err_ValidaProduto.GetError(txt_ComprimentoDoProduto), "Compirmento Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ComprimentoDoProduto.Focus();
                return;
            }

            if (err_ValidaProduto.GetError(txt_EspessuraDoProduto) != "")
            {
                MessageBox.Show(err_ValidaProduto.GetError(txt_EspessuraDoProduto), "Espessura Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_EspessuraDoProduto.Focus();
                return;
            }

            if(grd_ComposicaoDoProduto.Rows.Count <= 1)
            {
                if(MessageBox.Show("O Produto " + txt_DescricaoDoProduto.Text + " está sem registros de composição. Confirma o salvamento do Produto?", "Produto sem Composição", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            else if(VerificaSeExistemInsumosComQuantidadeZero() == true)
            {
                MessageBox.Show("Existem Insumos na composição do Produto com quantidade zerada. Favor verificar.", "Insumos com Quantidade Zero", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Salvar Registro
            if (grd_Produto.Enabled == false)
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
            if (MessageBox.Show("Confirma a exclusão do Produto " + txt_CodigoDoProduto.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            InicializaCampos("Excluir");
        }

        private void frm_CadastroDeProduto_Load(object sender, EventArgs e)
        {
            //Inicializa a Tela
            CarregaProdutosNoGrid();
            CarregaInformacoesDoGrupoNoCombo();

            //Se não houver nenhum no bancon, bloqueia os campos
            if (grd_Produto.RowCount <= 0)
            {
                LimpaCampos();
                HabilitarCampos(false);
                flt_TotalDoProduto = 0;
            }
            else
            {
                CarregaInformacoesDoProduto();
            }
            HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa();
        }

        private void grd_Produto_SelectionChanged(object sender, EventArgs e)
        {
            if (bol_HabilitaValidacaoPorTeclado == true && grd_Produto.SelectedRows.Count > 0)
                CarregaInformacoesDoProduto();
        }

        private void frm_CadastroDeProduto_Shown(object sender, EventArgs e)
        {
            bol_HabilitaValidacaoPorTeclado = true;
        }

        private void btn_PesquisarRegistro_Click(object sender, EventArgs e)
        {
            PesquisaProdutoNoGrid();
        }

        private void txt_LarguraDoProduto_Validating(object sender, CancelEventArgs e)
        {
            if(txt_LarguraDoProduto.Text == "")
            {
                txt_LarguraDoProduto.Text = "0";
                err_ValidaProduto.SetError(txt_LarguraDoProduto, "A largura do produto não deve ter valor zero.");
            }
            else if(Convert.ToSingle(txt_LarguraDoProduto.Text) == 0)
            {
                err_ValidaProduto.SetError(txt_LarguraDoProduto, "A largura do produto não deve ter valor zero.");
            }
            else
            {
                err_ValidaProduto.SetError(txt_LarguraDoProduto, "");
            }
            txt_LarguraDoProduto.Text = String.Format("{0:C4}", Convert.ToSingle(txt_LarguraDoProduto.Text)).Replace("R$", "");
            CalculaPesoDoProduto();
        }

        private void txt_ComprimentoDoProduto_Validating(object sender, CancelEventArgs e)
        {
            if (txt_ComprimentoDoProduto.Text == "")
            {
                txt_ComprimentoDoProduto.Text = "0";
                err_ValidaProduto.SetError(txt_ComprimentoDoProduto, "O comprimento do produto não deve ter valor zero.");
            }
            else if (Convert.ToSingle(txt_ComprimentoDoProduto.Text) == 0)
            {
                err_ValidaProduto.SetError(txt_ComprimentoDoProduto, "O comprimento do produto não deve ter valor zero.");
            }
            else
            {
                err_ValidaProduto.SetError(txt_ComprimentoDoProduto, "");
            }
            txt_ComprimentoDoProduto.Text = String.Format("{0:C4}", Convert.ToSingle(txt_ComprimentoDoProduto.Text)).Replace("R$", "");
            CalculaPesoDoProduto();
        }
        
        private void grd_ComposicaoDoProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                if (e.RowIndex == grd_ComposicaoDoProduto.Rows.Count - 1)
                    return;

                if (grd_ComposicaoDoProduto.Rows[e.RowIndex].Cells[0].FormattedValue.ToString() != "")
                { 
                    flt_TotalDoProduto -= Convert.ToSingle(grd_ComposicaoDoProduto[5, grd_ComposicaoDoProduto.CurrentCell.RowIndex].Value);
                    txt_CustoTotalDoProduto.Text = String.Format("{0:C3}", flt_TotalDoProduto);
                }
                grd_ComposicaoDoProduto.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void grd_ComposicaoDoProduto_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //Busca autocomplete do código
            if (grd_ComposicaoDoProduto.CurrentCell.ColumnIndex == 1)
            {
                //AutoComplete Insumo
                AutoCompleteStringCollection aut_ListaDeCodigosDeInsumos = new AutoCompleteStringCollection();
                TextBox txt_AutoCompleteRegistro = e.Control as TextBox;
                txt_AutoCompleteRegistro.AutoCompleteMode = AutoCompleteMode.Suggest;
                txt_AutoCompleteRegistro.AutoCompleteSource = AutoCompleteSource.CustomSource;

                var autoComplete = new AutoCompleteStringCollection();
                autoComplete.AddRange(obj_InsumoModel.BuscaDescriçãoDoInsumoParaAutocompletar().ToArray());
                txt_AutoCompleteRegistro.AutoCompleteCustomSource = autoComplete;
            }
        }

        //Valida espessura
        private void txt_EspessuraDoProduto_Validating(object sender, CancelEventArgs e)
        {
            if (txt_EspessuraDoProduto.Text == "")
            {
                txt_EspessuraDoProduto.Text = "0";
                err_ValidaProduto.SetError(txt_EspessuraDoProduto, "A espessura do produto não deve ter valor zero.");
            }
            else if (Convert.ToSingle(txt_EspessuraDoProduto.Text) == 0)
            {
                err_ValidaProduto.SetError(txt_EspessuraDoProduto, "A espessura do produto não deve ter valor zero.");
            }
            else
            {
                err_ValidaProduto.SetError(txt_EspessuraDoProduto, "");
            }
            txt_EspessuraDoProduto.Text = String.Format("{0:C4}", Convert.ToSingle(txt_EspessuraDoProduto.Text)).Replace("R$", "");
            CalculaPesoDoProduto();
        }

        private void grd_ComposicaoDoProduto_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (grd_ComposicaoDoProduto.CurrentCell.EditedFormattedValue.ToString() == "")
            {
                if (grd_ComposicaoDoProduto.CurrentCell.RowIndex != grd_ComposicaoDoProduto.Rows.Count - 1)
                {
                    if (this.ActiveControl.Name == "grd_ComposicaoDoProduto")
                    {
                        e.Cancel = true;
                    }
                }
                return;
            }

            //Validae Produto Selecionado
            if (grd_ComposicaoDoProduto.CurrentCell.ColumnIndex == 1)
            {
                InsumoDTO obj_InsumoDTO = new InsumoDTO();
                obj_InsumoDTO = obj_InsumoModel.BuscaInsumoPorDescricao(grd_ComposicaoDoProduto.CurrentCell.EditedFormattedValue.ToString());

                if(obj_InsumoDTO.NomeDoInsumo ==  null)
                {
                    MessageBox.Show("Insumo inexistente.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
                else
                {
                    grd_ComposicaoDoProduto[0, grd_ComposicaoDoProduto.CurrentCell.RowIndex].Value = obj_InsumoDTO.CodigoDoInsumo.ToString("000000");
                    grd_ComposicaoDoProduto[2, grd_ComposicaoDoProduto.CurrentCell.RowIndex].Value = obj_InsumoDTO.UnidadeDeMedidaDoInsumo;
                    grd_ComposicaoDoProduto[4, grd_ComposicaoDoProduto.CurrentCell.RowIndex].Value = String.Format("{0:C3}",obj_InsumoDTO.ValorUnitarioDaUltimaCompraDoInsumo).Replace("R$", "");

                    if (grd_ComposicaoDoProduto[3, grd_ComposicaoDoProduto.CurrentCell.RowIndex].Value == null)
                    {
                        grd_ComposicaoDoProduto[3, grd_ComposicaoDoProduto.CurrentCell.RowIndex].Value = "0,000";
                        grd_ComposicaoDoProduto[5, grd_ComposicaoDoProduto.CurrentCell.RowIndex].Value = "0,000";
                    }
                    else if(grd_ComposicaoDoProduto[3, grd_ComposicaoDoProduto.CurrentCell.RowIndex].FormattedValue.ToString() == "")
                    {
                        grd_ComposicaoDoProduto[3, grd_ComposicaoDoProduto.CurrentCell.RowIndex].Value = "0,000";
                        grd_ComposicaoDoProduto[5, grd_ComposicaoDoProduto.CurrentCell.RowIndex].Value = "0,000";
                    }
                }

                CalculaTotalDoItemDaComposicao(grd_ComposicaoDoProduto.CurrentCell.RowIndex);
                grd_ComposicaoDoProduto.Refresh();
            }
        }

        private void grd_ComposicaoDoProduto_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (grd_ComposicaoDoProduto.CurrentCell.EditedFormattedValue.ToString() == "")
            {
                return;
            }

            if (grd_ComposicaoDoProduto.CurrentCell.ColumnIndex == 3)
            {
                if (grd_ComposicaoDoProduto.CurrentCell.EditedFormattedValue == null)
                    grd_ComposicaoDoProduto[3, grd_ComposicaoDoProduto.CurrentCell.RowIndex].Value = "0,000";

                if (grd_ComposicaoDoProduto.CurrentCell.EditedFormattedValue.ToString() == "")
                    grd_ComposicaoDoProduto[3, grd_ComposicaoDoProduto.CurrentCell.RowIndex].Value = "0,000";

                //Atualiza a variável do total do produto
                flt_TotalDoProduto -= Convert.ToSingle(grd_ComposicaoDoProduto[5, grd_ComposicaoDoProduto.CurrentCell.RowIndex].Value);
                grd_ComposicaoDoProduto[3, grd_ComposicaoDoProduto.CurrentCell.RowIndex].Value = String.Format("{0:C3}", Convert.ToSingle(grd_ComposicaoDoProduto.CurrentCell.EditedFormattedValue)).Replace("R$", "");
            

                CalculaTotalDoItemDaComposicao(grd_ComposicaoDoProduto.CurrentCell.RowIndex);

                //Atualiza a variável do total do produto
                flt_TotalDoProduto += Convert.ToSingle(grd_ComposicaoDoProduto[5, grd_ComposicaoDoProduto.CurrentCell.RowIndex].Value);
                txt_CustoTotalDoProduto.Text = String.Format("{0:C3}", flt_TotalDoProduto);

                grd_ComposicaoDoProduto.Refresh();
            }
        }

        private void txt_PesquisaProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PesquisaProdutoNoGrid();
            }
        }

        private void txt_LarguraDoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)  && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_ComprimentoDoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_EspessuraDoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_ImportaComposicao_Click(object sender, EventArgs e)
        {
            Form frm_FormularioDeImportacaoDeComposicao = new frm_ImportaComposicaoDeOutroProduto(RetornaListaDeInsumosNaLista());
            frm_FormularioDeImportacaoDeComposicao.ShowDialog();

            if(frm_ImportaComposicaoDeOutroProduto.Int_CodigoDoProduto > 0)
            {
                ImportaComposicao(frm_ImportaComposicaoDeOutroProduto.Int_CodigoDoProduto);
            }
        }

        private void txt_DescricaoDoProduto_Validating(object sender, CancelEventArgs e)
        {
            ValidaDescricaoDoProduto();
        }

        private void txt_CodigoDoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_CodigoDoProduto_Validating(object sender, CancelEventArgs e)
        {
            ValidaCodigoDoProduto();
        }
        #endregion
    }
}
