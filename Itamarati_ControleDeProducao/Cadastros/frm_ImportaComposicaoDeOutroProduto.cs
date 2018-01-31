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
    public partial class frm_ImportaComposicaoDeOutroProduto : Form
    {
        private static int int_CodigoDoProduto;
        private IList<string> lst_InsumosNaListaCorrente = new List<string>();
        private DataView lst_ComposicaoDoProduto;
        private ProdutoModel obj_ProdutoModel = new ProdutoModel();
        private ItemDaComposicaoModel obj_ItemDaComposicaoModel = new ItemDaComposicaoModel();

        public frm_ImportaComposicaoDeOutroProduto(IList<string> lst_InsumosNaListaCorrente)
        {
            InitializeComponent();
            Int_CodigoDoProduto = 0;
            this.lst_InsumosNaListaCorrente = lst_InsumosNaListaCorrente;
        }

        public int CodigoDoProduto { get; set; }

        public static int Int_CodigoDoProduto
        {
            get
            {
                return int_CodigoDoProduto;
            }

            set
            {
                int_CodigoDoProduto = value;
            }
        }

        //Limpa Campos
        private void LimpaCampos()
        {
            txt_CodigoDoProduto.Text = "";
            txt_DescricaoDoProduto.Text = "";

            grd_ComposicaoDoProduto.DataSource = null;
            grd_ComposicaoDoProduto.Rows.Clear();
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

        private void txt_DescricaoDoProduto_Validating(object sender, CancelEventArgs e)
        {
            if (ValidaProdutoSelecionado() == false)
                e.Cancel = true;
        }

        private Boolean ValidaProdutoSelecionado()
        {
            if (txt_DescricaoDoProduto.Text != "")
            {
                //Valida Produto Selecionado
                ProdutoDTO obj_ProdutoDTO = new ProdutoDTO();
                obj_ProdutoDTO = new ProdutoModel().BuscaProdutoPorDescricao(txt_DescricaoDoProduto.Text);

                if (obj_ProdutoDTO.DescricaoDoProduto == null)
                {
                    MessageBox.Show("Produto inexistente.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LimpaCampos();
                    return false;
                }
                else
                {
                    txt_CodigoDoProduto.Text = obj_ProdutoDTO.CodigoDoProduto.ToString("000000");
                    CarregaInformacoesDaComposicaoDoProduto(Convert.ToInt32(txt_CodigoDoProduto.Text));
                }
            }
            else
            {
                LimpaCampos();
            }
            return true;
        }

        private void btn_ImportaComposicao_Click(object sender, EventArgs e)
        {
            if(txt_CodigoDoProduto.Text == "")
            {
                MessageBox.Show("Selecione um produto para a importação.", "Produto não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DescricaoDoProduto.Focus();
                return;
            }
            else if(grd_ComposicaoDoProduto.Rows.Count <= 0)
            {
                MessageBox.Show("O produto selecionado não possui Composição.", "Produto sem composição", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DescricaoDoProduto.Focus();
                return;
            }

            Int_CodigoDoProduto = Convert.ToInt32(txt_CodigoDoProduto.Text);
            this.Close();
        }

        private void frm_ImportaComposicaoDeOutroProduto_Load(object sender, EventArgs e)
        {
            //AutoComplete Produto
            txt_DescricaoDoProduto.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_DescricaoDoProduto.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(obj_ProdutoModel.BuscaDescriçãoDoProdutoParaAutocompletar().ToArray());
            txt_DescricaoDoProduto.AutoCompleteCustomSource = autoComplete;
        }

        private void txt_DescricaoDoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_ImportarComposicao.Focus();
        }
    }
}
