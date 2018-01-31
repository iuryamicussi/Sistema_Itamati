namespace Itamarati_ControleDeProducao.System_Control
{
    partial class frm_TelaDeAcesso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TelaDeAcesso));
            this.pnl_TituloTelaDeLogin = new System.Windows.Forms.Panel();
            this.pic_ImagemDoUsuario = new System.Windows.Forms.PictureBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Logar = new System.Windows.Forms.Button();
            this.txt_LoginDoUsuario = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_NomeDoUsuario = new System.Windows.Forms.Label();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.lbl_Mesagem = new System.Windows.Forms.Label();
            this.pic_LogoDaEmpresa = new System.Windows.Forms.PictureBox();
            this.err_Login = new System.Windows.Forms.ErrorProvider(this.components);
            this.tmr_EntradaDaFoto = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_TituloTelaDeLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImagemDoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoDaEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_TituloTelaDeLogin
            // 
            this.pnl_TituloTelaDeLogin.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_TituloTelaDeLogin.Controls.Add(this.pic_ImagemDoUsuario);
            this.pnl_TituloTelaDeLogin.Location = new System.Drawing.Point(-1, -1);
            this.pnl_TituloTelaDeLogin.Name = "pnl_TituloTelaDeLogin";
            this.pnl_TituloTelaDeLogin.Size = new System.Drawing.Size(455, 208);
            this.pnl_TituloTelaDeLogin.TabIndex = 0;
            // 
            // pic_ImagemDoUsuario
            // 
            this.pic_ImagemDoUsuario.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pic_ImagemDoUsuario.ErrorImage = global::Itamarati_ControleDeProducao.Properties.Resources.Usuario_Logo1;
            this.pic_ImagemDoUsuario.Image = global::Itamarati_ControleDeProducao.Properties.Resources.Usuario_Logo1;
            this.pic_ImagemDoUsuario.InitialImage = global::Itamarati_ControleDeProducao.Properties.Resources.Usuario_Logo1;
            this.pic_ImagemDoUsuario.Location = new System.Drawing.Point(128, 13);
            this.pic_ImagemDoUsuario.Name = "pic_ImagemDoUsuario";
            this.pic_ImagemDoUsuario.Size = new System.Drawing.Size(180, 180);
            this.pic_ImagemDoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ImagemDoUsuario.TabIndex = 1;
            this.pic_ImagemDoUsuario.TabStop = false;
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Sair.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Sair.FlatAppearance.BorderSize = 2;
            this.btn_Sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.btn_Sair.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Sair.Location = new System.Drawing.Point(194, 293);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(119, 45);
            this.btn_Sair.TabIndex = 4;
            this.btn_Sair.Text = "&Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Logar
            // 
            this.btn_Logar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Logar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Logar.FlatAppearance.BorderSize = 2;
            this.btn_Logar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Logar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logar.ForeColor = System.Drawing.Color.White;
            this.btn_Logar.Location = new System.Drawing.Point(323, 293);
            this.btn_Logar.Name = "btn_Logar";
            this.btn_Logar.Size = new System.Drawing.Size(119, 45);
            this.btn_Logar.TabIndex = 3;
            this.btn_Logar.Text = "&Login";
            this.btn_Logar.UseVisualStyleBackColor = false;
            this.btn_Logar.Click += new System.EventHandler(this.btn_Logar_Click);
            // 
            // txt_LoginDoUsuario
            // 
            this.txt_LoginDoUsuario.AccessibleDescription = "";
            this.txt_LoginDoUsuario.AccessibleName = "";
            this.txt_LoginDoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LoginDoUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoginDoUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.err_Login.SetIconPadding(this.txt_LoginDoUsuario, 5);
            this.txt_LoginDoUsuario.Location = new System.Drawing.Point(266, 220);
            this.txt_LoginDoUsuario.MaxLength = 20;
            this.txt_LoginDoUsuario.Name = "txt_LoginDoUsuario";
            this.txt_LoginDoUsuario.Size = new System.Drawing.Size(153, 26);
            this.txt_LoginDoUsuario.TabIndex = 1;
            this.txt_LoginDoUsuario.Tag = "Usuário";
            this.txt_LoginDoUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txt_LoginDoUsuario_Validating);
            // 
            // txt_Senha
            // 
            this.txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.err_Login.SetIconPadding(this.txt_Senha, 5);
            this.txt_Senha.Location = new System.Drawing.Point(266, 252);
            this.txt_Senha.MaxLength = 20;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(153, 26);
            this.txt_Senha.TabIndex = 2;
            this.txt_Senha.Tag = "Senha";
            this.txt_Senha.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Senha_Validating);
            // 
            // lbl_NomeDoUsuario
            // 
            this.lbl_NomeDoUsuario.AutoSize = true;
            this.lbl_NomeDoUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeDoUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NomeDoUsuario.Location = new System.Drawing.Point(190, 223);
            this.lbl_NomeDoUsuario.Name = "lbl_NomeDoUsuario";
            this.lbl_NomeDoUsuario.Size = new System.Drawing.Size(75, 19);
            this.lbl_NomeDoUsuario.TabIndex = 6;
            this.lbl_NomeDoUsuario.Text = "Usuário:";
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Senha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Senha.Location = new System.Drawing.Point(201, 255);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(64, 19);
            this.lbl_Senha.TabIndex = 7;
            this.lbl_Senha.Text = "Senha:";
            // 
            // lbl_Mesagem
            // 
            this.lbl_Mesagem.AutoSize = true;
            this.lbl_Mesagem.ForeColor = System.Drawing.Color.Silver;
            this.lbl_Mesagem.Location = new System.Drawing.Point(21, 314);
            this.lbl_Mesagem.Name = "lbl_Mesagem";
            this.lbl_Mesagem.Size = new System.Drawing.Size(153, 13);
            this.lbl_Mesagem.TabIndex = 8;
            this.lbl_Mesagem.Text = "Itamarati Controle de Produção";
            // 
            // pic_LogoDaEmpresa
            // 
            this.pic_LogoDaEmpresa.BackColor = System.Drawing.Color.White;
            this.pic_LogoDaEmpresa.Image = global::Itamarati_ControleDeProducao.Properties.Resources.Itamarati_ArtefatosDePapel;
            this.pic_LogoDaEmpresa.InitialImage = global::Itamarati_ControleDeProducao.Properties.Resources.CDI_Logo;
            this.pic_LogoDaEmpresa.Location = new System.Drawing.Point(12, 220);
            this.pic_LogoDaEmpresa.Name = "pic_LogoDaEmpresa";
            this.pic_LogoDaEmpresa.Size = new System.Drawing.Size(172, 86);
            this.pic_LogoDaEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_LogoDaEmpresa.TabIndex = 5;
            this.pic_LogoDaEmpresa.TabStop = false;
            // 
            // err_Login
            // 
            this.err_Login.BlinkRate = 0;
            this.err_Login.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_Login.ContainerControl = this;
            this.err_Login.Icon = ((System.Drawing.Icon)(resources.GetObject("err_Login.Icon")));
            // 
            // tmr_EntradaDaFoto
            // 
            this.tmr_EntradaDaFoto.Interval = 30;
            this.tmr_EntradaDaFoto.Tick += new System.EventHandler(this.tmr_EntradaDaFoto_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(60, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Versão 1.0.1";
            // 
            // frm_TelaDeAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(453, 350);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Mesagem);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.lbl_NomeDoUsuario);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_LoginDoUsuario);
            this.Controls.Add(this.pic_LogoDaEmpresa);
            this.Controls.Add(this.btn_Logar);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.pnl_TituloTelaDeLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_TelaDeAcesso";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_TelaDeAcesso";
            this.Load += new System.EventHandler(this.frm_TelaDeAcesso_Load);
            this.Shown += new System.EventHandler(this.frm_TelaDeAcesso_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_TelaDeAcesso_KeyPress);
            this.pnl_TituloTelaDeLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImagemDoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_LogoDaEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_TituloTelaDeLogin;
        private System.Windows.Forms.PictureBox pic_ImagemDoUsuario;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Logar;
        private System.Windows.Forms.PictureBox pic_LogoDaEmpresa;
        private System.Windows.Forms.TextBox txt_LoginDoUsuario;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label lbl_NomeDoUsuario;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.Label lbl_Mesagem;
        private System.Windows.Forms.ErrorProvider err_Login;
        private System.Windows.Forms.Timer tmr_EntradaDaFoto;
        private System.Windows.Forms.Label label1;
    }
}