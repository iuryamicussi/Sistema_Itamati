namespace Itamarati_ControleDeProducao.Controle_do_Sistema
{
    partial class frm_AlterarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AlterarSenha));
            this.grp_InfoUsuario = new System.Windows.Forms.GroupBox();
            this.txt_ConfirmarNovaSenha = new System.Windows.Forms.TextBox();
            this.lbl_ConfirmarNovaSenha = new System.Windows.Forms.Label();
            this.txt_NovaSenha = new System.Windows.Forms.TextBox();
            this.lbl_NovaSenha = new System.Windows.Forms.Label();
            this.tls_ControleDeRegistro = new System.Windows.Forms.ToolStrip();
            this.btn_SalvarRegistro = new System.Windows.Forms.ToolStripButton();
            this.btn_CancelarAlteracao = new System.Windows.Forms.ToolStripButton();
            this.pic_ImagemDoUsuario = new System.Windows.Forms.PictureBox();
            this.err_ValidaNovaSenha = new System.Windows.Forms.ErrorProvider(this.components);
            this.grp_InfoUsuario.SuspendLayout();
            this.tls_ControleDeRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImagemDoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_ValidaNovaSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_InfoUsuario
            // 
            this.grp_InfoUsuario.Controls.Add(this.txt_ConfirmarNovaSenha);
            this.grp_InfoUsuario.Controls.Add(this.lbl_ConfirmarNovaSenha);
            this.grp_InfoUsuario.Controls.Add(this.txt_NovaSenha);
            this.grp_InfoUsuario.Controls.Add(this.lbl_NovaSenha);
            this.grp_InfoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grp_InfoUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_InfoUsuario.Location = new System.Drawing.Point(13, 4);
            this.grp_InfoUsuario.Name = "grp_InfoUsuario";
            this.grp_InfoUsuario.Size = new System.Drawing.Size(361, 109);
            this.grp_InfoUsuario.TabIndex = 2;
            this.grp_InfoUsuario.TabStop = false;
            this.grp_InfoUsuario.Text = "Informações do Usuário";
            // 
            // txt_ConfirmarNovaSenha
            // 
            this.txt_ConfirmarNovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ConfirmarNovaSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmarNovaSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.err_ValidaNovaSenha.SetIconPadding(this.txt_ConfirmarNovaSenha, 5);
            this.txt_ConfirmarNovaSenha.Location = new System.Drawing.Point(127, 67);
            this.txt_ConfirmarNovaSenha.MaxLength = 10;
            this.txt_ConfirmarNovaSenha.Name = "txt_ConfirmarNovaSenha";
            this.txt_ConfirmarNovaSenha.PasswordChar = '*';
            this.txt_ConfirmarNovaSenha.Size = new System.Drawing.Size(194, 22);
            this.txt_ConfirmarNovaSenha.TabIndex = 3;
            this.txt_ConfirmarNovaSenha.Tag = "Nova Senha";
            this.txt_ConfirmarNovaSenha.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ConfirmarNovaSenha_Validating);
            // 
            // lbl_ConfirmarNovaSenha
            // 
            this.lbl_ConfirmarNovaSenha.AutoSize = true;
            this.lbl_ConfirmarNovaSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ConfirmarNovaSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfirmarNovaSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_ConfirmarNovaSenha.Location = new System.Drawing.Point(15, 70);
            this.lbl_ConfirmarNovaSenha.Name = "lbl_ConfirmarNovaSenha";
            this.lbl_ConfirmarNovaSenha.Size = new System.Drawing.Size(106, 15);
            this.lbl_ConfirmarNovaSenha.TabIndex = 2;
            this.lbl_ConfirmarNovaSenha.Text = "Confirmar Senha:";
            // 
            // txt_NovaSenha
            // 
            this.txt_NovaSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NovaSenha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NovaSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.err_ValidaNovaSenha.SetIconPadding(this.txt_NovaSenha, 5);
            this.txt_NovaSenha.Location = new System.Drawing.Point(127, 27);
            this.txt_NovaSenha.MaxLength = 10;
            this.txt_NovaSenha.Name = "txt_NovaSenha";
            this.txt_NovaSenha.PasswordChar = '*';
            this.txt_NovaSenha.Size = new System.Drawing.Size(194, 22);
            this.txt_NovaSenha.TabIndex = 1;
            this.txt_NovaSenha.Tag = "Nova Senha";
            this.txt_NovaSenha.Validating += new System.ComponentModel.CancelEventHandler(this.txt_NovaSenha_Validating);
            // 
            // lbl_NovaSenha
            // 
            this.lbl_NovaSenha.AutoSize = true;
            this.lbl_NovaSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_NovaSenha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NovaSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NovaSenha.Location = new System.Drawing.Point(44, 30);
            this.lbl_NovaSenha.Name = "lbl_NovaSenha";
            this.lbl_NovaSenha.Size = new System.Drawing.Size(77, 15);
            this.lbl_NovaSenha.TabIndex = 0;
            this.lbl_NovaSenha.Text = "Nova Senha:";
            // 
            // tls_ControleDeRegistro
            // 
            this.tls_ControleDeRegistro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tls_ControleDeRegistro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tls_ControleDeRegistro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tls_ControleDeRegistro.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tls_ControleDeRegistro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_SalvarRegistro,
            this.btn_CancelarAlteracao});
            this.tls_ControleDeRegistro.Location = new System.Drawing.Point(0, 124);
            this.tls_ControleDeRegistro.Name = "tls_ControleDeRegistro";
            this.tls_ControleDeRegistro.Padding = new System.Windows.Forms.Padding(0);
            this.tls_ControleDeRegistro.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tls_ControleDeRegistro.Size = new System.Drawing.Size(506, 42);
            this.tls_ControleDeRegistro.Stretch = true;
            this.tls_ControleDeRegistro.TabIndex = 3;
            // 
            // btn_SalvarRegistro
            // 
            this.btn_SalvarRegistro.ForeColor = System.Drawing.Color.White;
            this.btn_SalvarRegistro.Image = global::Itamarati_ControleDeProducao.Properties.Resources._1460227522_editor_floopy_dish_save_glyph;
            this.btn_SalvarRegistro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_SalvarRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SalvarRegistro.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.btn_SalvarRegistro.Name = "btn_SalvarRegistro";
            this.btn_SalvarRegistro.Size = new System.Drawing.Size(79, 36);
            this.btn_SalvarRegistro.Text = "Salvar";
            this.btn_SalvarRegistro.Click += new System.EventHandler(this.btn_SalvarRegistro_Click);
            // 
            // btn_CancelarAlteracao
            // 
            this.btn_CancelarAlteracao.ForeColor = System.Drawing.Color.White;
            this.btn_CancelarAlteracao.Image = global::Itamarati_ControleDeProducao.Properties.Resources._1460227342_other_arrow_left_other_glyph;
            this.btn_CancelarAlteracao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_CancelarAlteracao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_CancelarAlteracao.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.btn_CancelarAlteracao.Name = "btn_CancelarAlteracao";
            this.btn_CancelarAlteracao.Size = new System.Drawing.Size(95, 36);
            this.btn_CancelarAlteracao.Text = "Cancelar";
            this.btn_CancelarAlteracao.Click += new System.EventHandler(this.btn_CancelarAlteracao_Click);
            // 
            // pic_ImagemDoUsuario
            // 
            this.pic_ImagemDoUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.pic_ImagemDoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_ImagemDoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_ImagemDoUsuario.ErrorImage = global::Itamarati_ControleDeProducao.Properties.Resources.Usuario_Logo;
            this.pic_ImagemDoUsuario.Image = global::Itamarati_ControleDeProducao.Properties.Resources.Usuario_Logo;
            this.pic_ImagemDoUsuario.InitialImage = global::Itamarati_ControleDeProducao.Properties.Resources.Usuario_Logo;
            this.pic_ImagemDoUsuario.Location = new System.Drawing.Point(389, 10);
            this.pic_ImagemDoUsuario.Name = "pic_ImagemDoUsuario";
            this.pic_ImagemDoUsuario.Size = new System.Drawing.Size(103, 103);
            this.pic_ImagemDoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ImagemDoUsuario.TabIndex = 11;
            this.pic_ImagemDoUsuario.TabStop = false;
            // 
            // err_ValidaNovaSenha
            // 
            this.err_ValidaNovaSenha.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_ValidaNovaSenha.ContainerControl = this;
            this.err_ValidaNovaSenha.Icon = ((System.Drawing.Icon)(resources.GetObject("err_ValidaNovaSenha.Icon")));
            // 
            // frm_AlterarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 166);
            this.Controls.Add(this.pic_ImagemDoUsuario);
            this.Controls.Add(this.tls_ControleDeRegistro);
            this.Controls.Add(this.grp_InfoUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_AlterarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Senha e acesso";
            this.Load += new System.EventHandler(this.frm_AlterarSenha_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_AlterarSenha_KeyPress);
            this.grp_InfoUsuario.ResumeLayout(false);
            this.grp_InfoUsuario.PerformLayout();
            this.tls_ControleDeRegistro.ResumeLayout(false);
            this.tls_ControleDeRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImagemDoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_ValidaNovaSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_InfoUsuario;
        private System.Windows.Forms.ToolStrip tls_ControleDeRegistro;
        private System.Windows.Forms.ToolStripButton btn_SalvarRegistro;
        private System.Windows.Forms.Label lbl_NovaSenha;
        private System.Windows.Forms.TextBox txt_NovaSenha;
        private System.Windows.Forms.PictureBox pic_ImagemDoUsuario;
        private System.Windows.Forms.TextBox txt_ConfirmarNovaSenha;
        private System.Windows.Forms.Label lbl_ConfirmarNovaSenha;
        private System.Windows.Forms.ErrorProvider err_ValidaNovaSenha;
        private System.Windows.Forms.ToolStripButton btn_CancelarAlteracao;
    }
}