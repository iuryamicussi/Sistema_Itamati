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
using Itamarati_ControleDeProducao.DTO;
using Itamarati_ControleDeProducao.Model;
using Itamarati_ControleDeProducao.Controle_do_Sistema;
using Itamarati_ControleDeProducao.Controller;

namespace Itamarati_ControleDeProducao.System_Control
{
    public partial class frm_TelaDeAcesso : Form
    {
        private Form frm_Tela;
        private UsuarioDTO obj_UltimoUsuarioLogado = new UsuarioDTO();

        public frm_TelaDeAcesso()
        {
            InitializeComponent();
            tmr_EntradaDaFoto.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath formaDeElipse = new GraphicsPath();
            formaDeElipse.AddEllipse(0, 00, pic_ImagemDoUsuario.Width, pic_ImagemDoUsuario.Height);
            pic_ImagemDoUsuario.Region = new Region(formaDeElipse);
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            //Valida Campos
            if(err_Login.GetError(txt_LoginDoUsuario) != "")
            {
                MessageBox.Show("Informe o Login do usuário!", "Usuário não informado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_LoginDoUsuario.Focus();
                return;
            }

            if (err_Login.GetError(txt_Senha) != "")
            {
                MessageBox.Show("Informe a senha de acesso do usuário!", "Senha não informada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Senha.Focus();
                return;
            }

            //Busca Usuário digitado e valida a senha
            try
            {
                UsuarioDTO obj_UsuarioDTO = new UsuarioDTO(txt_LoginDoUsuario.Text, txt_Senha.Text);

                obj_UsuarioDTO = new UsuarioModel().AutenticaUsuario(obj_UsuarioDTO);

                if(obj_UsuarioDTO.LoginDoUsuario == null)
                {
                    MessageBox.Show("Usuário ou Senha inválida!", "Usuário Incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_LoginDoUsuario.Focus();
                    return;
                }

                this.Hide();
                frm_Tela = new frm_TelaPrincipal(obj_UsuarioDTO);


                frm_Tela.ShowDialog();

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_LoginDoUsuario_Validating(object sender, CancelEventArgs e)
        {
            //Valida se o campo está vazio
            if (txt_LoginDoUsuario.TextLength == 0)
            {
                err_Login.SetError(txt_LoginDoUsuario, "Informe o login do Usuário.");
            }
            else
            {
                err_Login.SetError(txt_LoginDoUsuario, "");

                if (txt_LoginDoUsuario.Text != obj_UltimoUsuarioLogado.LoginDoUsuario)
                {
                    pic_ImagemDoUsuario.Image = pic_ImagemDoUsuario.InitialImage;
                }
                else
                {
                    pic_ImagemDoUsuario.Image = obj_UltimoUsuarioLogado.FotoDoUsuario;
                }
            }
        }

        private void txt_Senha_Validating(object sender, CancelEventArgs e)
        {
            //Valida se o campo está vazio
            if (txt_Senha.TextLength == 0)
            {
                err_Login.SetError(txt_Senha, "Informe a senha de acesso.");
            }
            else
            {
                err_Login.SetError(txt_Senha, "");
            }
        }

        private void frm_TelaDeAcesso_Load(object sender, EventArgs e)
        {

            int int_UltimoUsuarioLogado = new UsuarioModel().VerificaSeExisteRegistroDeUsuarioLogado(new InformacoesDoHardware().BuscaNumeroDoSerial());

            //Verifica se existe registros de um último usuario logado no sistema
            if (int_UltimoUsuarioLogado > 0)
            {
                obj_UltimoUsuarioLogado = new UsuarioModel().BuscaUsuarioPorCodigo(int_UltimoUsuarioLogado);
            }
        }

        private void frm_TelaDeAcesso_Shown(object sender, EventArgs e)
        {
            if(obj_UltimoUsuarioLogado.LoginDoUsuario != null)
            {
                pic_ImagemDoUsuario.Image = obj_UltimoUsuarioLogado.FotoDoUsuario;
                txt_LoginDoUsuario.Text = obj_UltimoUsuarioLogado.LoginDoUsuario;

                txt_Senha.Focus();
            }
        }

        private void tmr_EntradaDaFoto_Tick(object sender, EventArgs e)
        {
            this.Opacity += .05;

            if(this.Opacity == 1)
            {
                tmr_EntradaDaFoto.Stop();
            }
        }

        private void frm_TelaDeAcesso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
