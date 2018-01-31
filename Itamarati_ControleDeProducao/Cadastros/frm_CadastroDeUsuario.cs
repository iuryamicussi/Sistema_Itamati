using Itamarati_ControleDeProducao.Controller;
using Itamarati_ControleDeProducao.DTO;
using Itamarati_ControleDeProducao.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDI_ControleDeProducao.Cadastros
{
    public partial class frm_CadastroDeUsuario : Form
    {
        //Objetos
        private DataView lst_UsuariosCadastrados;
        private UsuarioDTO obj_UsuarioDTO;
        private UsuarioDTO obj_UsuarioLogado = new UsuarioDTO();
        private UsuarioModel obj_UsuarioModel = new UsuarioModel();

        //Variáveis de controle
        private int retornoDaFuncao;
        private Boolean bol_HabilitaValidacaoPorTeclado = false;

        public frm_CadastroDeUsuario()
        {
            InitializeComponent();
            this.obj_UsuarioLogado = InformacoesDoSistema.obj_UsuarioLogado;
        }

        //Rotina de inicialização de Função
        private void InicializaCampos(string modo)
        {
            int int_GuardaLinhaSelecionada;

            switch (modo)
            {
                case "Incluir":
                    LimpaCampos();
                    HabilitarCampos(true);
                    msk_DataHoraDeCadastro.Text = DateTime.Now.ToString();
                    grd_Usuarios.Enabled = false;
                    btn_ExcluirRegistro.Enabled = false;
                    btn_PesquisarRegistro.Enabled = false;
                    txt_PesquisaUsuario.Visible = false;

                    txt_NomeDoUsuario.Focus();
                    break;

                case "SalvarNovo":
                    obj_UsuarioDTO = new UsuarioDTO();

                    try
                    {
                        //Carrega o objeto com os campos digitados
                        obj_UsuarioDTO.NomeDoUsuario = txt_NomeDoUsuario.Text;
                        obj_UsuarioDTO.LoginDoUsuario = txt_LoginDoUsuario.Text;
                        obj_UsuarioDTO.DataHoraDeCadastro = Convert.ToDateTime(msk_DataHoraDeCadastro.Text);

                        if(rdb_StatusAtivo.Checked)
                        {
                            obj_UsuarioDTO.StatusDoUsuario = true;
                        }
                        else
                        {
                            obj_UsuarioDTO.StatusDoUsuario = false;
                        }

                        if(chk_UsuarioGerente.Checked)
                        {
                            obj_UsuarioDTO.UsuarioGerente = true;
                        }
                        else
                        {
                            obj_UsuarioDTO.UsuarioGerente = false;
                        }

                        obj_UsuarioDTO.FotoDoUsuario = pic_ImagemDoUsuario.Image;

                        //Insere as informações no Banco
                        retornoDaFuncao = obj_UsuarioModel.IncluirNovoUsuario(obj_UsuarioDTO);

                        if (retornoDaFuncao > 0)
                        {
                            MessageBox.Show("Usuário cadastrado com sucesso!", "Usuário Cadastrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O usuário não foi cadastrado!");
                        }

                        grd_Usuarios.Enabled = true;

                        //Recarrega a Tabela de Usuários e seleciona o registro criado
                        bol_HabilitaValidacaoPorTeclado = false;
                        CarregaUsuariosNoGrid();
                        grd_Usuarios.Rows[grd_Usuarios.Rows.Count - 1].Selected = true;
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

                    obj_UsuarioDTO = new UsuarioDTO();

                    try
                    {
                        //Carrega o objeto com os campos digitados
                        obj_UsuarioDTO.NomeDoUsuario = txt_NomeDoUsuario.Text;
                        obj_UsuarioDTO.LoginDoUsuario = txt_LoginDoUsuario.Text;
                        obj_UsuarioDTO.DataHoraDeCadastro = Convert.ToDateTime(msk_DataHoraDeCadastro.Text);

                        if (rdb_StatusAtivo.Checked)
                        {
                            obj_UsuarioDTO.StatusDoUsuario = true;
                        }
                        else
                        {
                            obj_UsuarioDTO.StatusDoUsuario = false;
                        }

                        if (chk_UsuarioGerente.Checked)
                        {
                            obj_UsuarioDTO.UsuarioGerente = true;
                        }
                        else
                        {
                            obj_UsuarioDTO.UsuarioGerente = false;
                        }

                        obj_UsuarioDTO.FotoDoUsuario = (Image)pic_ImagemDoUsuario.Image;

                        //Insere as informações no Banco
                        retornoDaFuncao = obj_UsuarioModel.AtualizaInformacoesDoUsuario(obj_UsuarioDTO, grd_Usuarios.CurrentRow.Cells[2].FormattedValue.ToString());

                        if (retornoDaFuncao > 0)
                        {
                            MessageBox.Show("Informações salvas com sucesso!", "Usuário Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O usuário não foi salvo!", "Erro no salvamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        //Recarrega a Tabela de Usuários e seleciona o registro criado
                        bol_HabilitaValidacaoPorTeclado = false;
                        int_GuardaLinhaSelecionada = grd_Usuarios.SelectedRows[0].Index;
                        CarregaUsuariosNoGrid();
                        grd_Usuarios.Rows[int_GuardaLinhaSelecionada].Selected = true;
                        CarregaInformacoesDoUsuario();
                        bol_HabilitaValidacaoPorTeclado = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Cancelar":

                    if(grd_Usuarios.Rows.Count > 0)
                    {
                        CarregaInformacoesDoUsuario();
                        txt_NomeDoUsuario.Focus();
                    }
                    else
                    {
                        LimpaCampos();
                        HabilitarCampos(false);
                    }
                    grd_Usuarios.Enabled = true;
                    HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa();

                    break;

                case "Excluir":

                    obj_UsuarioDTO = new UsuarioDTO();

                    try
                    {
                        //Carrega o objeto com os campos digitados
                        obj_UsuarioDTO.CodigoDoUsuario = Convert.ToInt32(grd_Usuarios.SelectedRows[0].Cells[0].FormattedValue);
                        obj_UsuarioDTO.NomeDoUsuario = txt_NomeDoUsuario.Text;
                        obj_UsuarioDTO.LoginDoUsuario = txt_LoginDoUsuario.Text;
                        obj_UsuarioDTO.DataHoraDeCadastro = Convert.ToDateTime(msk_DataHoraDeCadastro.Text);

                        if (rdb_StatusAtivo.Checked)
                        {
                            obj_UsuarioDTO.StatusDoUsuario = true;
                        }
                        else
                        {
                            obj_UsuarioDTO.StatusDoUsuario = false;
                        }

                        if (chk_UsuarioGerente.Checked)
                        {
                            obj_UsuarioDTO.UsuarioGerente = true;
                        }
                        else
                        {
                            obj_UsuarioDTO.UsuarioGerente = false;
                        }

                        obj_UsuarioDTO.FotoDoUsuario = pic_ImagemDoUsuario.Image;

                        //Exclui o usuário
                        retornoDaFuncao = obj_UsuarioModel.ExcluiInformacoesDoUsuario(obj_UsuarioDTO);

                        if (retornoDaFuncao > 0)
                        {
                            MessageBox.Show("Usuário removido com sucesso!", "Usuário Removido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("O usuário não foi removido!", "Erro ao Remover Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        grd_Usuarios.Enabled = true;

                        //Recarrega a Tabela de Usuários e seleciona o registro criado
                        bol_HabilitaValidacaoPorTeclado = false;
                        CarregaUsuariosNoGrid();

                        if (grd_Usuarios.Rows.Count > 0)
                        {
                            CarregaInformacoesDoUsuario();
                            txt_NomeDoUsuario.Focus();
                        }
                        else
                        {
                            LimpaCampos();
                            HabilitarCampos(false);
                        }

                        bol_HabilitaValidacaoPorTeclado = true;
                        HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao excluir o usuário.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;

                case "Pesquisar":

                    lst_UsuariosCadastrados.RowFilter = "LoginDoUsuario Like '" + txt_PesquisaUsuario.Text.Trim() + "%' Or NomeDoUsuario Like '" + txt_PesquisaUsuario.Text.Trim() + "%'";
                    grd_Usuarios.Refresh();
                    grd_Usuarios.Focus();

                    break;
            }
        }

        //Carregar Usuários no ComboBox
        private void CarregaUsuariosNoGrid()
        {
            try
            {
                grd_Usuarios.DataSource = null;
                grd_Usuarios.Rows.Clear();
                grd_Usuarios.Refresh();

                lst_UsuariosCadastrados = new DataView();
                lst_UsuariosCadastrados = obj_UsuarioModel.BuscaListaDeUsuariosCadastrados();

                grd_Usuarios.AutoGenerateColumns = false;

                grd_Usuarios.DataSource = lst_UsuariosCadastrados;
                grd_Usuarios.Refresh();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Carregar informações do Grid nos campos
        private void CarregaInformacoesDoUsuario()
        {
            txt_NomeDoUsuario.Text = grd_Usuarios.SelectedRows[0].Cells[3].FormattedValue.ToString();
            txt_LoginDoUsuario.Text = grd_Usuarios.SelectedRows[0].Cells[2].FormattedValue.ToString();

            if (Convert.ToBoolean(grd_Usuarios.SelectedRows[0].Cells[5].FormattedValue) == true)
            {
                rdb_StatusAtivo.Checked = true;
            }
            else
            {
                rdb_StatusInativo.Checked = true;
            }

            if (Convert.ToBoolean(grd_Usuarios.SelectedRows[0].Cells[6].FormattedValue) == true)
            {
                chk_UsuarioGerente.Checked = true;
            }
            else
            {
                chk_UsuarioGerente.Checked = false;
            }

            //msk_DataHoraDeCadastro.Text = grd_Usuarios.CurrentRow.Cells[6].FormattedValue.ToString();
            msk_DataHoraDeCadastro.Text = grd_Usuarios.SelectedRows[0].Cells[4].FormattedValue.ToString();

            using (MemoryStream mStream = new MemoryStream((byte[])grd_Usuarios.SelectedRows[0].Cells[1].Value))
            {
                pic_ImagemDoUsuario.Image = Image.FromStream(mStream);
            }
        }

        //Limpa os campos para um novo registro
        private void LimpaCampos()
        {

            txt_NomeDoUsuario.Text = "";
            txt_LoginDoUsuario.Text = "";
            rdb_StatusAtivo.Checked = true;
            msk_DataHoraDeCadastro.Text = "";
            chk_UsuarioGerente.Checked = false;
            pic_ImagemDoUsuario.Image = pic_ImagemDoUsuario.InitialImage;
        }

        //Habilita/Desabilita campo
        private void HabilitarCampos(Boolean bol_Modo)
        {
            txt_NomeDoUsuario.Enabled = bol_Modo;
            txt_LoginDoUsuario.Enabled = bol_Modo;
            rdb_StatusAtivo.Enabled = bol_Modo;
            rdb_StatusInativo.Enabled = bol_Modo;
            chk_UsuarioGerente.Enabled = bol_Modo;
            pic_ImagemDoUsuario.Enabled = bol_Modo;
        }

        //Desabilita botoes quando não existem registros
        private void HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa()
        {
            if(grd_Usuarios.Rows.Count > 0)
            {
                btn_ExcluirRegistro.Enabled = true;
                txt_PesquisaUsuario.Visible = true;
                btn_PesquisarRegistro.Enabled = true;
            }
            else
            {
                btn_ExcluirRegistro.Enabled = false;
                txt_PesquisaUsuario.Visible = false;
                btn_PesquisarRegistro.Enabled = false;
            }
        }

        //Pesquisa Na tabela o campo digita
        private void PesquisaUsuarioNoGrid()
        {
            if (txt_PesquisaUsuario.Text.Trim() != "")
            {
                InicializaCampos("Pesquisar");
            }
            else
            {
                lst_UsuariosCadastrados.RowFilter = null;
                grd_Usuarios.Refresh();
            }
        }

        #region Métodos de Validação
        private void ValidaNomeDoUsuaio()
        {
            err_ValidaUsuario.SetError(txt_NomeDoUsuario, ValidacaoGenericaDeCampos.VerificaSeOCampoEstaVazio(txt_NomeDoUsuario.Text, "o Nome do Usuário."));
        }

        private void ValidaLoginDoUsuaio()
        {
            err_ValidaUsuario.SetError(txt_LoginDoUsuario, ValidacaoGenericaDeCampos.VerificaSeOCampoEstaVazio(txt_LoginDoUsuario.Text, "o Login do Usuário."));

            //Verifica se já existe um Login igual ao digitado
            if ((grd_Usuarios.Enabled == false || txt_LoginDoUsuario.Text.Trim() != grd_Usuarios.SelectedRows[0].Cells[2].FormattedValue.ToString()) && err_ValidaUsuario.GetError(txt_LoginDoUsuario) == "")
            {
                err_ValidaUsuario.SetError(txt_LoginDoUsuario, obj_UsuarioModel.VerificaSeOLoginDigitadoJaEstaSendoUsado(txt_LoginDoUsuario.Text));
            }
        }
        #endregion

        #region Funções de componentes da Tela
        protected override void OnPaint(PaintEventArgs e)
        {
            //transforma o picturebox em elipse
            GraphicsPath formaDeElipse = new GraphicsPath();
            formaDeElipse.AddEllipse(0, 00, pic_ImagemDoUsuario.Width, pic_ImagemDoUsuario.Height);
            pic_ImagemDoUsuario.Region = new Region(formaDeElipse);
        }

        private void btn_NovoRegistro_Click(object sender, EventArgs e)
        {
            //Incluir
            InicializaCampos("Incluir");
            txt_NomeDoUsuario.Focus();
        }

        private void btn_SalvarRegistro_Click(object sender, EventArgs e)
        {
            //Valida Campos
            ValidaNomeDoUsuaio();
            ValidaLoginDoUsuaio();

            //Verifica se Existem registros incorretos
            if (err_ValidaUsuario.GetError(txt_NomeDoUsuario) != "")
            {
                MessageBox.Show("Informe o nome do usuário!", "Usuário não informado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NomeDoUsuario.Focus();
                return;
            }

            if (err_ValidaUsuario.GetError(txt_LoginDoUsuario) != "")
            {
                MessageBox.Show(err_ValidaUsuario.GetError(txt_LoginDoUsuario), "Senha não informada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LoginDoUsuario.Focus();
                return;
            }

            //Salvar Registro
            if (grd_Usuarios.Enabled == false)
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
            if (MessageBox.Show("Confirma a exclusão do Usuário " + txt_LoginDoUsuario.Text + "?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            InicializaCampos("Excluir");
        }
        
        private void frm_CadastroDeUsuario_Load(object sender, EventArgs e)
        {
            //Inicializa a Tela
            CarregaUsuariosNoGrid();

            //Se não houver nenhum no bancon, bloqueia os campos
            if (grd_Usuarios.RowCount <= 0)
            {
                HabilitarCampos(false);
            }
            else
            {
               CarregaInformacoesDoUsuario();
            }
            HabilitaOuDesabilitaBotoesDeExclusaoEPesquisa();
        }

        private void pic_ImagemDoUsuario_Click(object sender, EventArgs e)
        {
            //Busca imagem para inserir no picturebox
            dlg_PesquisaImagem.ShowDialog();
            pic_ImagemDoUsuario.ImageLocation = dlg_PesquisaImagem.FileName;
        }

        private void txt_NomeDoUsuario_Validating(object sender, CancelEventArgs e)
        {
            ValidaNomeDoUsuaio();
        }

        private void txt_LoginDoUsuario_Validating(object sender, CancelEventArgs e)
        {
            ValidaLoginDoUsuaio();
        }

        private void grd_Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            if(bol_HabilitaValidacaoPorTeclado == true && grd_Usuarios.SelectedRows.Count > 0)
                CarregaInformacoesDoUsuario();
        }

        private void frm_CadastroDeUsuario_Shown(object sender, EventArgs e)
        {
            bol_HabilitaValidacaoPorTeclado = true;
        }

        private void btn_PesquisarRegistro_Click(object sender, EventArgs e)
        {
            PesquisaUsuarioNoGrid();
        }

        private void txt_PesquisaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                PesquisaUsuarioNoGrid();
            }
        }
        #endregion

        private void frm_CadastroDeUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
