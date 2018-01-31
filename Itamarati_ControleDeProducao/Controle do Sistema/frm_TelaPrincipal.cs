using CDI_ControleDeProducao.Cadastros;
using Itamarati_ControleDeProducao.Cadastros;
using Itamarati_ControleDeProducao.Controller;
using Itamarati_ControleDeProducao.DTO;
using Itamarati_ControleDeProducao.Manutenção;
using Itamarati_ControleDeProducao.System_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itamarati_ControleDeProducao.Controle_do_Sistema
{
    public partial class frm_TelaPrincipal : Form
    {
        public frm_TelaPrincipal(UsuarioDTO obj_UsuarioDTO)
        {
            InitializeComponent();
            InformacoesDoSistema.obj_UsuarioLogado = obj_UsuarioDTO;
            InformacoesDoSistema.frm_MDIParent = this;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath formaDeElipse = new GraphicsPath();
            formaDeElipse.AddEllipse(0, 00, pic_FotoDoUsuarioLogado.Width, pic_FotoDoUsuarioLogado.Height);
            pic_FotoDoUsuarioLogado.Region = new Region(formaDeElipse);
        }

        //Métodos Usuais
        private void HabilitarBotoesDoSubMenuPrincipal(String str_Modo)
        {
            switch(str_Modo)
            {
                case "Cadastros":
                    btn_Cadastros.Checked = true;
                    btn_Manutencao.Checked = false;

                    btn_SubMenu1.Text = "Produtos";
                    btn_SubMenu1.Visible = true;
                    btn_SubMenu2.Text = "Insumos";
                    btn_SubMenu2.Visible = true;
                    btn_SubMenu3.Text = "Usuários";
                    btn_SubMenu3.Visible = true;
                    btn_SubMenu4.Text = "Grupos";
                    btn_SubMenu4.Visible = true;
                    break;

                case "Manutenção":
                    btn_Manutencao.Checked = true;
                    btn_Cadastros.Checked = false;

                    btn_SubMenu1.Text = "Controle de Produção";
                    btn_SubMenu1.Visible = true;
                    btn_SubMenu2.Visible = false;
                    btn_SubMenu3.Visible = false;
                    btn_SubMenu4.Visible = false;
                    break;

                case "Desabilitar":
                    btn_Cadastros.Checked = false;
                    btn_Manutencao.Checked = false;
                    btn_SubMenu1.Visible = false;
                    btn_SubMenu2.Visible = false;
                    btn_SubMenu3.Visible = false;
                    btn_SubMenu4.Visible = false;
                    break;
            }
        }

        #region Funções de Componentes da Tela
        //Funções da Tela
        private void frm_TelaPrincipal_Load(object sender, EventArgs e)
        {

            //Insere as Informações do Usuário no Menu
            pic_FotoDoUsuarioLogado.Image = InformacoesDoSistema.obj_UsuarioLogado.FotoDoUsuario;
            btn_ConfiguracoesDoUsuario.Text = InformacoesDoSistema.obj_UsuarioLogado.LoginDoUsuario;

            //Inicializa o Timer de Data e Hora
            lbl_DataHora.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString(); 
            tmr_DataHora.Enabled = true;
            lbl_NumeroDeSerie.Text = new InformacoesDoHardware().BuscaNumeroDoSerial().Trim();

            //imagem de fundo
            this.BackgroundImage = System.Drawing.Image.FromFile(@"Imagens De Fundo\TelaPrincipal.jpg");
        }

        private void frm_TelaPrincipal_Shown(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void tmr_DataHora_Tick(object sender, EventArgs e)
        {
            //Timer da Data e Hora do sistema
            lbl_DataHora.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void btn_Cadastros_Click(object sender, EventArgs e)
        {
            HabilitarBotoesDoSubMenuPrincipal("Cadastros");
        }

        private void btn_SubMenu3_Click(object sender, EventArgs e)
        {
            InformacoesDoSistema.AbrirFormulario(typeof(frm_CadastroDeUsuario));
        }
        #endregion

        private void men_MenuPrincipal_Click(object sender, EventArgs e)
        {
            HabilitarBotoesDoSubMenuPrincipal("Desabilitar");
        }

        private void frm_TelaPrincipal_Click(object sender, EventArgs e)
        {
            HabilitarBotoesDoSubMenuPrincipal("Desabilitar");
        }

        private void btn_AlterarSenha_Click(object sender, EventArgs e)
        {
            InformacoesDoSistema.AbrirFormulario(typeof(frm_AlterarSenha));
        }

        private void btn_SubMenu2_Click(object sender, EventArgs e)
        {
            InformacoesDoSistema.AbrirFormulario(typeof(frm_CadastroDeInsumo));
        }

        private void btn_SubMenu1_Click(object sender, EventArgs e)
        {
            if (btn_SubMenu1.Text == "Controle de Produção") //Módulo de Manutenção
            {
                InformacoesDoSistema.AbrirFormulario(typeof(frm_ControleDeProducao));
            }
            else //Módulo de Cadastro
            {
                InformacoesDoSistema.AbrirFormulario(typeof(frm_CadastroDeProduto));
            }
        }

        private void btn_SubMenu4_Click(object sender, EventArgs e)
        {
            InformacoesDoSistema.AbrirFormulario(typeof(frm_CadastroDeGrupo));
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja trocar de Usuário do sistema?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            Application.Restart();
        }

        private void btn_Manutencao_Click(object sender, EventArgs e)
        {
            HabilitarBotoesDoSubMenuPrincipal("Manutenção");
        }
    }
}
