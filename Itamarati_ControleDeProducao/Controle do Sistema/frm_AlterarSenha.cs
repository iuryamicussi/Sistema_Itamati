using Itamarati_ControleDeProducao.Controller;
using Itamarati_ControleDeProducao.DTO;
using Itamarati_ControleDeProducao.Model;
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
    public partial class frm_AlterarSenha : Form
    {
        //Objetos
        private UsuarioDTO obj_UsuarioDTO = new UsuarioDTO();

        //Variáveis de controle
        private int retornoDaFuncao;

        public frm_AlterarSenha()
        {
            InitializeComponent();
            this.obj_UsuarioDTO = InformacoesDoSistema.obj_UsuarioLogado;
        }

        //Load da tela
        private void frm_AlterarSenha_Load(object sender, EventArgs e)
        {
            pic_ImagemDoUsuario.Image = obj_UsuarioDTO.FotoDoUsuario;
        }

        //Validações básicas do campo
        private void txt_ConfirmarNovaSenha_Validating(object sender, CancelEventArgs e)
        {
            if (txt_NovaSenha.Text == "")
            {
                return;
            }
            else if (txt_ConfirmarNovaSenha.Text == "")
            {
                err_ValidaNovaSenha.SetError(txt_ConfirmarNovaSenha, "Confirme a Senha Digitada");
            }
            else if (txt_NovaSenha.Text.Trim() != txt_ConfirmarNovaSenha.Text.Trim())
            {
                err_ValidaNovaSenha.SetError(txt_ConfirmarNovaSenha, "A confirmação da senha não confere com a senha digitada.");
            }
            else
            {
                err_ValidaNovaSenha.SetError(txt_ConfirmarNovaSenha, "");
            }
        }

        //Transforma a imagem em elipse
        protected override void OnPaint(PaintEventArgs e)
        {
            //transforma o picturebox em elipse
            GraphicsPath formaDeElipse = new GraphicsPath();
            formaDeElipse.AddEllipse(0, 00, pic_ImagemDoUsuario.Width, pic_ImagemDoUsuario.Height);
            pic_ImagemDoUsuario.Region = new Region(formaDeElipse);
        }

        //Validação básica do campo
        private void txt_NovaSenha_Validating(object sender, CancelEventArgs e)
        {
            if (txt_NovaSenha.Text == "")
            {
                err_ValidaNovaSenha.SetError(txt_NovaSenha, "Informe a nova Senha de acesso");
            }
            else
            {
                err_ValidaNovaSenha.SetError(txt_NovaSenha, "");
            }
        }

        private void btn_SalvarRegistro_Click(object sender, EventArgs e)
        {
            //Valida Campos
            if (err_ValidaNovaSenha.GetError(txt_NovaSenha) != "")
            {
                MessageBox.Show(err_ValidaNovaSenha.GetError(txt_NovaSenha), "Alterar Senha de acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NovaSenha.Focus();
                return;
            }

            if (err_ValidaNovaSenha.GetError(txt_ConfirmarNovaSenha) != "")
            {
                MessageBox.Show(err_ValidaNovaSenha.GetError(txt_ConfirmarNovaSenha), "Alterar Senha de acesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_ConfirmarNovaSenha.Focus();
                return;
            }

            InicializaCampos("Salvar");
        }

        //Rotina de inicialização de Função
        private void InicializaCampos(string modo)
        {
            switch (modo)
            {
                case "Salvar":

                    try
                    {
                        obj_UsuarioDTO.SenhaDoUsuario = txt_NovaSenha.Text.Trim();

                        retornoDaFuncao = new UsuarioModel().AlterarSenhaDoUsuario(obj_UsuarioDTO);

                        if(retornoDaFuncao > 0 )
                        {
                            MessageBox.Show("Senha alterada com sucesso!", "Alterar Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            InicializaCampos("Cancelar");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro ao salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case "Cancelar":
                    txt_NovaSenha.Text = "";
                    txt_ConfirmarNovaSenha.Text = "";
                    err_ValidaNovaSenha.SetError(txt_NovaSenha, "");
                    err_ValidaNovaSenha.SetError(txt_ConfirmarNovaSenha, "");
                    break;
            }
        }

        private void btn_CancelarAlteracao_Click(object sender, EventArgs e)
        {
            InicializaCampos("Cancelar");
        }

        private void frm_AlterarSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
