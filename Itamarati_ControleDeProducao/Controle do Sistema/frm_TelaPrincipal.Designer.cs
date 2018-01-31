namespace Itamarati_ControleDeProducao.Controle_do_Sistema
{
    partial class frm_TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TelaPrincipal));
            this.men_MenuPrincipal = new System.Windows.Forms.ToolStrip();
            this.btn_Manutencao = new System.Windows.Forms.ToolStripButton();
            this.btn_Cadastros = new System.Windows.Forms.ToolStripButton();
            this.btn_ConfiguracoesDoUsuario = new System.Windows.Forms.ToolStripDropDownButton();
            this.btn_AlterarSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Logout = new System.Windows.Forms.ToolStripMenuItem();
            this.men_SubMenu = new System.Windows.Forms.ToolStrip();
            this.btn_SubMenu1 = new System.Windows.Forms.ToolStripButton();
            this.btn_SubMenu2 = new System.Windows.Forms.ToolStripButton();
            this.btn_SubMenu3 = new System.Windows.Forms.ToolStripButton();
            this.btn_SubMenu4 = new System.Windows.Forms.ToolStripButton();
            this.sts_BarraDeStatus = new System.Windows.Forms.StatusStrip();
            this.lbl_DataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_NumeroDeSerie = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_NumeroDeSerieTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmr_DataHora = new System.Windows.Forms.Timer(this.components);
            this.pic_FotoDoUsuarioLogado = new System.Windows.Forms.PictureBox();
            this.men_MenuPrincipal.SuspendLayout();
            this.men_SubMenu.SuspendLayout();
            this.sts_BarraDeStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FotoDoUsuarioLogado)).BeginInit();
            this.SuspendLayout();
            // 
            // men_MenuPrincipal
            // 
            this.men_MenuPrincipal.AutoSize = false;
            this.men_MenuPrincipal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.men_MenuPrincipal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.men_MenuPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.men_MenuPrincipal.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.men_MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Manutencao,
            this.btn_Cadastros,
            this.btn_ConfiguracoesDoUsuario});
            this.men_MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.men_MenuPrincipal.Name = "men_MenuPrincipal";
            this.men_MenuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.men_MenuPrincipal.Size = new System.Drawing.Size(1350, 65);
            this.men_MenuPrincipal.TabIndex = 2;
            this.men_MenuPrincipal.Click += new System.EventHandler(this.men_MenuPrincipal_Click);
            // 
            // btn_Manutencao
            // 
            this.btn_Manutencao.AutoSize = false;
            this.btn_Manutencao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Manutencao.ForeColor = System.Drawing.Color.White;
            this.btn_Manutencao.Image = global::Itamarati_ControleDeProducao.Properties.Resources._1460618169_device_projector_screen_content_chart_presentation_glyph;
            this.btn_Manutencao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Manutencao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Manutencao.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.btn_Manutencao.Name = "btn_Manutencao";
            this.btn_Manutencao.Size = new System.Drawing.Size(140, 59);
            this.btn_Manutencao.Text = "Manutenção";
            this.btn_Manutencao.Click += new System.EventHandler(this.btn_Manutencao_Click);
            // 
            // btn_Cadastros
            // 
            this.btn_Cadastros.AutoSize = false;
            this.btn_Cadastros.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastros.ForeColor = System.Drawing.Color.White;
            this.btn_Cadastros.Image = global::Itamarati_ControleDeProducao.Properties.Resources._1460617694_circle_edit_pen_pencil_glyph;
            this.btn_Cadastros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Cadastros.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Cadastros.Margin = new System.Windows.Forms.Padding(20, 3, 0, 3);
            this.btn_Cadastros.Name = "btn_Cadastros";
            this.btn_Cadastros.Size = new System.Drawing.Size(140, 59);
            this.btn_Cadastros.Text = "Cadastros";
            this.btn_Cadastros.Click += new System.EventHandler(this.btn_Cadastros_Click);
            // 
            // btn_ConfiguracoesDoUsuario
            // 
            this.btn_ConfiguracoesDoUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_ConfiguracoesDoUsuario.AutoSize = false;
            this.btn_ConfiguracoesDoUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_ConfiguracoesDoUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AlterarSenha,
            this.toolStripSeparator1,
            this.btn_Logout});
            this.btn_ConfiguracoesDoUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfiguracoesDoUsuario.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btn_ConfiguracoesDoUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ConfiguracoesDoUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ConfiguracoesDoUsuario.Margin = new System.Windows.Forms.Padding(0, 3, 58, 3);
            this.btn_ConfiguracoesDoUsuario.Name = "btn_ConfiguracoesDoUsuario";
            this.btn_ConfiguracoesDoUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_ConfiguracoesDoUsuario.Size = new System.Drawing.Size(140, 59);
            this.btn_ConfiguracoesDoUsuario.Text = "Usuário";
            // 
            // btn_AlterarSenha
            // 
            this.btn_AlterarSenha.AutoSize = false;
            this.btn_AlterarSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarSenha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_AlterarSenha.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_AlterarSenha.Margin = new System.Windows.Forms.Padding(1);
            this.btn_AlterarSenha.Name = "btn_AlterarSenha";
            this.btn_AlterarSenha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_AlterarSenha.Size = new System.Drawing.Size(190, 35);
            this.btn_AlterarSenha.Text = "Alterar Senha";
            this.btn_AlterarSenha.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btn_AlterarSenha.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_AlterarSenha.Click += new System.EventHandler(this.btn_AlterarSenha_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // btn_Logout
            // 
            this.btn_Logout.AutoSize = false;
            this.btn_Logout.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Logout.Image = global::Itamarati_ControleDeProducao.Properties.Resources._1460227589_common_login_enter_signin_glyph;
            this.btn_Logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Logout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Logout.Size = new System.Drawing.Size(190, 35);
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btn_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // men_SubMenu
            // 
            this.men_SubMenu.AutoSize = false;
            this.men_SubMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.men_SubMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_SubMenu1,
            this.btn_SubMenu2,
            this.btn_SubMenu3,
            this.btn_SubMenu4});
            this.men_SubMenu.Location = new System.Drawing.Point(0, 65);
            this.men_SubMenu.Name = "men_SubMenu";
            this.men_SubMenu.Size = new System.Drawing.Size(1350, 31);
            this.men_SubMenu.TabIndex = 3;
            // 
            // btn_SubMenu1
            // 
            this.btn_SubMenu1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_SubMenu1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubMenu1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_SubMenu1.Image = ((System.Drawing.Image)(resources.GetObject("btn_SubMenu1.Image")));
            this.btn_SubMenu1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SubMenu1.Margin = new System.Windows.Forms.Padding(70, 3, 0, 3);
            this.btn_SubMenu1.Name = "btn_SubMenu1";
            this.btn_SubMenu1.Size = new System.Drawing.Size(59, 25);
            this.btn_SubMenu1.Text = "Produtos";
            this.btn_SubMenu1.Visible = false;
            this.btn_SubMenu1.Click += new System.EventHandler(this.btn_SubMenu1_Click);
            // 
            // btn_SubMenu2
            // 
            this.btn_SubMenu2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_SubMenu2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_SubMenu2.Image = ((System.Drawing.Image)(resources.GetObject("btn_SubMenu2.Image")));
            this.btn_SubMenu2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SubMenu2.Margin = new System.Windows.Forms.Padding(60, 3, 0, 3);
            this.btn_SubMenu2.Name = "btn_SubMenu2";
            this.btn_SubMenu2.Size = new System.Drawing.Size(56, 25);
            this.btn_SubMenu2.Text = "Insumos";
            this.btn_SubMenu2.Visible = false;
            this.btn_SubMenu2.Click += new System.EventHandler(this.btn_SubMenu2_Click);
            // 
            // btn_SubMenu3
            // 
            this.btn_SubMenu3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_SubMenu3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_SubMenu3.Image = ((System.Drawing.Image)(resources.GetObject("btn_SubMenu3.Image")));
            this.btn_SubMenu3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SubMenu3.Margin = new System.Windows.Forms.Padding(60, 3, 0, 3);
            this.btn_SubMenu3.Name = "btn_SubMenu3";
            this.btn_SubMenu3.Size = new System.Drawing.Size(56, 25);
            this.btn_SubMenu3.Text = "Usuários";
            this.btn_SubMenu3.Visible = false;
            this.btn_SubMenu3.Click += new System.EventHandler(this.btn_SubMenu3_Click);
            // 
            // btn_SubMenu4
            // 
            this.btn_SubMenu4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_SubMenu4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_SubMenu4.Image = ((System.Drawing.Image)(resources.GetObject("btn_SubMenu4.Image")));
            this.btn_SubMenu4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SubMenu4.Margin = new System.Windows.Forms.Padding(60, 3, 0, 3);
            this.btn_SubMenu4.Name = "btn_SubMenu4";
            this.btn_SubMenu4.Size = new System.Drawing.Size(49, 25);
            this.btn_SubMenu4.Text = "Grupos";
            this.btn_SubMenu4.Visible = false;
            this.btn_SubMenu4.Click += new System.EventHandler(this.btn_SubMenu4_Click);
            // 
            // sts_BarraDeStatus
            // 
            this.sts_BarraDeStatus.AutoSize = false;
            this.sts_BarraDeStatus.GripMargin = new System.Windows.Forms.Padding(0);
            this.sts_BarraDeStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_DataHora,
            this.lbl_NumeroDeSerie,
            this.lbl_NumeroDeSerieTitle});
            this.sts_BarraDeStatus.Location = new System.Drawing.Point(0, 701);
            this.sts_BarraDeStatus.Name = "sts_BarraDeStatus";
            this.sts_BarraDeStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sts_BarraDeStatus.Size = new System.Drawing.Size(1350, 28);
            this.sts_BarraDeStatus.TabIndex = 5;
            // 
            // lbl_DataHora
            // 
            this.lbl_DataHora.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataHora.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_DataHora.Margin = new System.Windows.Forms.Padding(20, 3, 0, 3);
            this.lbl_DataHora.Name = "lbl_DataHora";
            this.lbl_DataHora.Size = new System.Drawing.Size(73, 22);
            this.lbl_DataHora.Text = "Data e Hora";
            this.lbl_DataHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_DataHora.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // lbl_NumeroDeSerie
            // 
            this.lbl_NumeroDeSerie.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumeroDeSerie.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NumeroDeSerie.Margin = new System.Windows.Forms.Padding(15, 3, 0, 2);
            this.lbl_NumeroDeSerie.Name = "lbl_NumeroDeSerie";
            this.lbl_NumeroDeSerie.Size = new System.Drawing.Size(100, 23);
            this.lbl_NumeroDeSerie.Text = "Numero de serie";
            // 
            // lbl_NumeroDeSerieTitle
            // 
            this.lbl_NumeroDeSerieTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumeroDeSerieTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NumeroDeSerieTitle.Name = "lbl_NumeroDeSerieTitle";
            this.lbl_NumeroDeSerieTitle.Size = new System.Drawing.Size(105, 23);
            this.lbl_NumeroDeSerieTitle.Text = ":Número de Série";
            // 
            // tmr_DataHora
            // 
            this.tmr_DataHora.Enabled = true;
            this.tmr_DataHora.Interval = 60000;
            this.tmr_DataHora.Tick += new System.EventHandler(this.tmr_DataHora_Tick);
            // 
            // pic_FotoDoUsuarioLogado
            // 
            this.pic_FotoDoUsuarioLogado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_FotoDoUsuarioLogado.ErrorImage = global::Itamarati_ControleDeProducao.Properties.Resources.Usuario_Logo1;
            this.pic_FotoDoUsuarioLogado.Image = global::Itamarati_ControleDeProducao.Properties.Resources.Usuario_Logo1;
            this.pic_FotoDoUsuarioLogado.InitialImage = global::Itamarati_ControleDeProducao.Properties.Resources.Usuario_Logo;
            this.pic_FotoDoUsuarioLogado.Location = new System.Drawing.Point(1293, 9);
            this.pic_FotoDoUsuarioLogado.Name = "pic_FotoDoUsuarioLogado";
            this.pic_FotoDoUsuarioLogado.Size = new System.Drawing.Size(48, 48);
            this.pic_FotoDoUsuarioLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_FotoDoUsuarioLogado.TabIndex = 7;
            this.pic_FotoDoUsuarioLogado.TabStop = false;
            // 
            // frm_TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pic_FotoDoUsuarioLogado);
            this.Controls.Add(this.sts_BarraDeStatus);
            this.Controls.Add(this.men_SubMenu);
            this.Controls.Add(this.men_MenuPrincipal);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frm_TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Itamarati Artefatos de Papel - Controle de Produção";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_TelaPrincipal_Load);
            this.Shown += new System.EventHandler(this.frm_TelaPrincipal_Shown);
            this.Click += new System.EventHandler(this.frm_TelaPrincipal_Click);
            this.men_MenuPrincipal.ResumeLayout(false);
            this.men_MenuPrincipal.PerformLayout();
            this.men_SubMenu.ResumeLayout(false);
            this.men_SubMenu.PerformLayout();
            this.sts_BarraDeStatus.ResumeLayout(false);
            this.sts_BarraDeStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_FotoDoUsuarioLogado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip men_MenuPrincipal;
        private System.Windows.Forms.ToolStripButton btn_Cadastros;
        private System.Windows.Forms.ToolStripButton btn_Manutencao;
        private System.Windows.Forms.ToolStrip men_SubMenu;
        private System.Windows.Forms.ToolStripButton btn_SubMenu1;
        private System.Windows.Forms.ToolStripButton btn_SubMenu2;
        private System.Windows.Forms.ToolStripButton btn_SubMenu3;
        private System.Windows.Forms.StatusStrip sts_BarraDeStatus;
        private System.Windows.Forms.ToolStripStatusLabel lbl_DataHora;
        private System.Windows.Forms.Timer tmr_DataHora;
        private System.Windows.Forms.ToolStripDropDownButton btn_ConfiguracoesDoUsuario;
        private System.Windows.Forms.PictureBox pic_FotoDoUsuarioLogado;
        private System.Windows.Forms.ToolStripMenuItem btn_AlterarSenha;
        private System.Windows.Forms.ToolStripMenuItem btn_Logout;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_SubMenu4;
        private System.Windows.Forms.ToolStripStatusLabel lbl_NumeroDeSerie;
        private System.Windows.Forms.ToolStripStatusLabel lbl_NumeroDeSerieTitle;
    }
}