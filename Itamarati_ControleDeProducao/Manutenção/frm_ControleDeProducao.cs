using Itamarati_ControleDeProducao.DTO;
using Itamarati_ControleDeProducao.Model;
using Itamarati_ControleDeProducao.Relatório;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itamarati_ControleDeProducao.Manutenção
{
    public partial class frm_ControleDeProducao : Form
    {

        //Objetos
        private DataView lst_ProdutosCadastrados;
        private DataView lst_GruposCadastrados;
        private ProdutoModel obj_ProdutoModel = new ProdutoModel();
        private GrupoModel obj_GrupoModel = new GrupoModel();
        private ProducaoModel obj_ProducaoModel = new ProducaoModel();

        public frm_ControleDeProducao()
        {
            InitializeComponent();
        }

        private void frm_ControleDeProducao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        //Rotina de inicialização de Função
        private void InicializaCampos(string modo)
        {
            switch (modo)
            {
                case "Imprimir":

                    break;
                case "Pesquisar":
                    lst_ProdutosCadastrados.RowFilter = "DescricaoDoProduto Like '" + txt_Pesquisa.Text.Trim() + "%'";
                    grd_Produto.Refresh();
                    grd_Produto.Focus();
                    break;
            }
        }

        //Carregar Produtos no Grid
        private void CarregaProdutosNoGrid()
        {
            int intIndiceGrupo;

            try
            {
                grd_Produto.DataSource = null;
                grd_Produto.Rows.Clear();
                grd_Produto.Refresh();

                lst_ProdutosCadastrados = new DataView();

                //Atribui os indices
                intIndiceGrupo = (cmb_Grupo.SelectedIndex == cmb_Grupo.Items.Count - 1) ? -1 : cmb_Grupo.SelectedIndex;

                //Busca os produtos de acordo com o grupo
                lst_ProdutosCadastrados = obj_ProducaoModel.BuscaListaDeProdutosCadastradosPorGrupoParaImpressao
                (
                    (intIndiceGrupo == -1) ? -1 : Convert.ToInt32(lst_GruposCadastrados[intIndiceGrupo]["CodigoDoGrupo"])
                );

                grd_Produto.AutoGenerateColumns = false;

                grd_Produto.DataSource = lst_ProdutosCadastrados;
                grd_Produto.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Desabilita botoes quando não existem registros
        private void HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa()
        {
            if (grd_Produto.Rows.Count > 0)
            {
                btn_ImprimirRegistro.Enabled = true;
                btn_PesquisarRegistro.Enabled = true;
            }
            else
            {
                btn_ImprimirRegistro.Enabled = false;
                btn_PesquisarRegistro.Enabled = false;
            }
        }

        //Pesquisa Na tabela o campo digita
        private void PesquisaProdutoNoGrid()
        {
            if (txt_Pesquisa.Text.Trim() != "")
            {
                InicializaCampos("Pesquisar");
            }
            else
            {
                lst_ProdutosCadastrados.RowFilter = null;
                grd_Produto.Refresh();
            }
        }

        //Prepara a tela
        private void frm_ControleDeProducao_Shown(object sender, EventArgs e)
        {
            //Carrega grupos no combobox
            carregarGruposNoCombobox();

            //Carrega produtos no grid
            CarregaProdutosNoGrid();
        }

        //Executa a pesquisa no grid
        private void btn_PesquisarRegistro_Click(object sender, EventArgs e)
        {
            PesquisaProdutoNoGrid();
        }

        //Pesquisa no grid
        private void txt_Pesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PesquisaProdutoNoGrid();
            }
        }

        //Carrega grupos no combobox
        private void carregarGruposNoCombobox()
        {
            try
            {
                //Limpa combobox
                cmb_Grupo.Items.Clear();

                //Busca lista de grupos cadastrados
                lst_GruposCadastrados = obj_GrupoModel.BuscaListaDeGruposCadastrados();

                //Adiciona grupos no combobox
                foreach (DataRowView drv_Grupo in lst_GruposCadastrados)
                    cmb_Grupo.Items.Add(drv_Grupo["NomeDoGrupo"].ToString());

                //Adiciona grupo "todos"
                cmb_Grupo.Items.Add("Todos");
                cmb_Grupo.SelectedIndex = cmb_Grupo.Items.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Imprimir os produtos selecionados no grid
        private void btn_ImprimirRegistro_Click(object sender, EventArgs e)
        {
            imprimirProdutosSelecionados("Imprimir");
        }

        //Rotina de inicialização de Função
        private void imprimirProdutosSelecionados(string modo)
        {
            frmRelatorio obj_frmRelatorio;
            List<DataView> lst_Dados = new List<DataView>();
            List<int> lst_CodigosDosProdutosEscolhidos = new List<int>();

            switch (modo)
            {
                case "Imprimir":
                    try
                    {
                        //Pega quais produtos devem ser impressos
                        foreach (DataGridViewRow produto in grd_Produto.Rows)
                            if (produto.Cells[0].Value.ToString() == "T")
                                lst_CodigosDosProdutosEscolhidos.Add(Convert.ToInt32(produto.Cells[1].Value));

                        //Verifica se o usuario selecionou algum produto
                        if (lst_CodigosDosProdutosEscolhidos.Count == 0)
                            throw new Exception("NenhumProdutoSelecionado");

                        //Preenche lista com os dados para o relatorio
                        lst_Dados.Add(obj_ProducaoModel.dadosParaImpressaoDoRelatorioControleDeProducao(lst_CodigosDosProdutosEscolhidos));
                        
                        //Imprimi o relatório na tela
                        obj_frmRelatorio = new frmRelatorio();
                        obj_frmRelatorio.imprimir
                        (
                            "ControleDeProducao.rdlc",
                            lst_Dados
                        );
                    }
                    catch (Exception ex)
                    {
                        switch (ex.Message)
                        {
                            case "NenhumProdutoSelecionado": MessageBox.Show("Selecione os produtos a serem impressos!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); break;
                            default: MessageBox.Show("Falha ao imprimir o relatório!\n\nDetalhes:\n\n" + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); break;
                        }
                    }

                    break;
            }
        }

        //Carrega produtos no grid
        private void cmb_Grupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaProdutosNoGrid();
        }

        //Altera valor do checkbox
        private void grd_Produto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grd_Produto.Rows.Count > 0)
            {
                
            }
        }
    }
}
