namespace CDI_ControleDeProducao.Cadastros
{
    partial class frm_CadastroDeUsuario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadastroDeUsuario));
            this.tls_ControleDeRegistro = new System.Windows.Forms.ToolStrip();
            this.btn_NovoRegistro = new System.Windows.Forms.ToolStripButton();
            this.btn_SalvarRegistro = new System.Windows.Forms.ToolStripButton();
            this.btn_CancelarAlteracao = new System.Windows.Forms.ToolStripButton();
            this.btn_PesquisarRegistro = new System.Windows.Forms.ToolStripButton();
            this.txt_PesquisaUsuario = new System.Windows.Forms.ToolStripTextBox();
            this.btn_ExcluirRegistro = new System.Windows.Forms.ToolStripButton();
            this.grp_InfoUsuario = new System.Windows.Forms.GroupBox();
            this.chk_UsuarioGerente = new System.Windows.Forms.CheckBox();
            this.pic_ImagemDoUsuario = new System.Windows.Forms.PictureBox();
            this.msk_DataHoraDeCadastro = new System.Windows.Forms.MaskedTextBox();
            this.lbl_DataDeCadastro = new System.Windows.Forms.Label();
            this.rdb_StatusInativo = new System.Windows.Forms.RadioButton();
            this.rdb_StatusAtivo = new System.Windows.Forms.RadioButton();
            this.lbl_StatusDoUsuario = new System.Windows.Forms.Label();
            this.txt_LoginDoUsuario = new System.Windows.Forms.TextBox();
            this.txt_NomeDoUsuario = new System.Windows.Forms.TextBox();
            this.lbl_LoginDoUsuario = new System.Windows.Forms.Label();
            this.lbl_NomeDoUsuario = new System.Windows.Forms.Label();
            this.grd_Usuarios = new System.Windows.Forms.DataGridView();
            this.CodigoDoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FotoDePerfil = new System.Windows.Forms.DataGridViewImageColumn();
            this.LoginDoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDeCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusDoUsuario = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UsuarioGerente = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dlg_PesquisaImagem = new System.Windows.Forms.OpenFileDialog();
            this.err_ValidaUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.tls_ControleDeRegistro.SuspendLayout();
            this.grp_InfoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImagemDoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_ValidaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tls_ControleDeRegistro
            // 
            this.tls_ControleDeRegistro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tls_ControleDeRegistro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tls_ControleDeRegistro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tls_ControleDeRegistro.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tls_ControleDeRegistro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_NovoRegistro,
            this.btn_SalvarRegistro,
            this.btn_CancelarAlteracao,
            this.btn_PesquisarRegistro,
            this.txt_PesquisaUsuario,
            this.btn_ExcluirRegistro});
            this.tls_ControleDeRegistro.Location = new System.Drawing.Point(0, 330);
            this.tls_ControleDeRegistro.Name = "tls_ControleDeRegistro";
            this.tls_ControleDeRegistro.Padding = new System.Windows.Forms.Padding(0);
            this.tls_ControleDeRegistro.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tls_ControleDeRegistro.Size = new System.Drawing.Size(683, 42);
            this.tls_ControleDeRegistro.Stretch = true;
            this.tls_ControleDeRegistro.TabIndex = 0;
            // 
            // btn_NovoRegistro
            // 
            this.btn_NovoRegistro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_NovoRegistro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NovoRegistro.ForeColor = System.Drawing.Color.White;
            this.btn_NovoRegistro.Image = global::Itamarati_ControleDeProducao.Properties.Resources._1460227555_circle_add_plus_new_glyph;
            this.btn_NovoRegistro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_NovoRegistro.ImageTransparentColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_NovoRegistro.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.btn_NovoRegistro.Name = "btn_NovoRegistro";
            this.btn_NovoRegistro.Size = new System.Drawing.Size(72, 36);
            this.btn_NovoRegistro.Text = "Novo";
            this.btn_NovoRegistro.Click += new System.EventHandler(this.btn_NovoRegistro_Click);
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
            // btn_PesquisarRegistro
            // 
            this.btn_PesquisarRegistro.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_PesquisarRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_PesquisarRegistro.Image = global::Itamarati_ControleDeProducao.Properties.Resources._1460227217_common_search_lookup_glyph;
            this.btn_PesquisarRegistro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_PesquisarRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_PesquisarRegistro.Margin = new System.Windows.Forms.Padding(0, 3, 10, 3);
            this.btn_PesquisarRegistro.Name = "btn_PesquisarRegistro";
            this.btn_PesquisarRegistro.Size = new System.Drawing.Size(36, 36);
            this.btn_PesquisarRegistro.ToolTipText = "Pesquisar Usuário";
            this.btn_PesquisarRegistro.Click += new System.EventHandler(this.btn_PesquisarRegistro_Click);
            // 
            // txt_PesquisaUsuario
            // 
            this.txt_PesquisaUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_PesquisaUsuario.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PesquisaUsuario.Margin = new System.Windows.Forms.Padding(1, 3, 10, 3);
            this.txt_PesquisaUsuario.MaxLength = 20;
            this.txt_PesquisaUsuario.Name = "txt_PesquisaUsuario";
            this.txt_PesquisaUsuario.Size = new System.Drawing.Size(150, 36);
            this.txt_PesquisaUsuario.ToolTipText = "Digite o texto que deseja pesquisar";
            this.txt_PesquisaUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PesquisaUsuario_KeyPress);
            // 
            // btn_ExcluirRegistro
            // 
            this.btn_ExcluirRegistro.ForeColor = System.Drawing.Color.White;
            this.btn_ExcluirRegistro.Image = global::Itamarati_ControleDeProducao.Properties.Resources._1460227290_editor_trash_delete_recycle_bin_glyph;
            this.btn_ExcluirRegistro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ExcluirRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ExcluirRegistro.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.btn_ExcluirRegistro.Name = "btn_ExcluirRegistro";
            this.btn_ExcluirRegistro.Size = new System.Drawing.Size(84, 36);
            this.btn_ExcluirRegistro.Text = "Excluir";
            this.btn_ExcluirRegistro.ToolTipText = "Excluir";
            this.btn_ExcluirRegistro.Click += new System.EventHandler(this.btn_ExcluirRegistro_Click);
            // 
            // grp_InfoUsuario
            // 
            this.grp_InfoUsuario.Controls.Add(this.chk_UsuarioGerente);
            this.grp_InfoUsuario.Controls.Add(this.pic_ImagemDoUsuario);
            this.grp_InfoUsuario.Controls.Add(this.msk_DataHoraDeCadastro);
            this.grp_InfoUsuario.Controls.Add(this.lbl_DataDeCadastro);
            this.grp_InfoUsuario.Controls.Add(this.rdb_StatusInativo);
            this.grp_InfoUsuario.Controls.Add(this.rdb_StatusAtivo);
            this.grp_InfoUsuario.Controls.Add(this.lbl_StatusDoUsuario);
            this.grp_InfoUsuario.Controls.Add(this.txt_LoginDoUsuario);
            this.grp_InfoUsuario.Controls.Add(this.txt_NomeDoUsuario);
            this.grp_InfoUsuario.Controls.Add(this.lbl_LoginDoUsuario);
            this.grp_InfoUsuario.Controls.Add(this.lbl_NomeDoUsuario);
            this.grp_InfoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grp_InfoUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_InfoUsuario.Location = new System.Drawing.Point(13, 4);
            this.grp_InfoUsuario.Name = "grp_InfoUsuario";
            this.grp_InfoUsuario.Size = new System.Drawing.Size(658, 121);
            this.grp_InfoUsuario.TabIndex = 1;
            this.grp_InfoUsuario.TabStop = false;
            this.grp_InfoUsuario.Text = "Informações do Usuário";
            // 
            // chk_UsuarioGerente
            // 
            this.chk_UsuarioGerente.AutoSize = true;
            this.chk_UsuarioGerente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_UsuarioGerente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chk_UsuarioGerente.Location = new System.Drawing.Point(325, 57);
            this.chk_UsuarioGerente.Name = "chk_UsuarioGerente";
            this.chk_UsuarioGerente.Size = new System.Drawing.Size(71, 19);
            this.chk_UsuarioGerente.TabIndex = 11;
            this.chk_UsuarioGerente.Text = "Gerente";
            this.chk_UsuarioGerente.UseVisualStyleBackColor = true;
            // 
            // pic_ImagemDoUsuario
            // 
            this.pic_ImagemDoUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.pic_ImagemDoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_ImagemDoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_ImagemDoUsuario.ErrorImage = global::Itamarati_ControleDeProducao.Properties.Resources.Usuario_Logo1;
            this.pic_ImagemDoUsuario.Image = global::Itamarati_ControleDeProducao.Properties.Resources.Usuario_Logo1;
            this.pic_ImagemDoUsuario.InitialImage = global::Itamarati_ControleDeProducao.Properties.Resources.Usuario_Logo1;
            this.pic_ImagemDoUsuario.Location = new System.Drawing.Point(537, 12);
            this.pic_ImagemDoUsuario.Name = "pic_ImagemDoUsuario";
            this.pic_ImagemDoUsuario.Size = new System.Drawing.Size(103, 103);
            this.pic_ImagemDoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ImagemDoUsuario.TabIndex = 10;
            this.pic_ImagemDoUsuario.TabStop = false;
            this.pic_ImagemDoUsuario.Click += new System.EventHandler(this.pic_ImagemDoUsuario_Click);
            // 
            // msk_DataHoraDeCadastro
            // 
            this.msk_DataHoraDeCadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_DataHoraDeCadastro.Enabled = false;
            this.msk_DataHoraDeCadastro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_DataHoraDeCadastro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.msk_DataHoraDeCadastro.Location = new System.Drawing.Point(325, 85);
            this.msk_DataHoraDeCadastro.Mask = "00/00/0000 90:00";
            this.msk_DataHoraDeCadastro.Name = "msk_DataHoraDeCadastro";
            this.msk_DataHoraDeCadastro.Size = new System.Drawing.Size(116, 22);
            this.msk_DataHoraDeCadastro.TabIndex = 8;
            this.msk_DataHoraDeCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_DataDeCadastro
            // 
            this.lbl_DataDeCadastro.AutoSize = true;
            this.lbl_DataDeCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_DataDeCadastro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataDeCadastro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_DataDeCadastro.Location = new System.Drawing.Point(257, 89);
            this.lbl_DataDeCadastro.Name = "lbl_DataDeCadastro";
            this.lbl_DataDeCadastro.Size = new System.Drawing.Size(62, 15);
            this.lbl_DataDeCadastro.TabIndex = 7;
            this.lbl_DataDeCadastro.Text = "Cadastro:";
            // 
            // rdb_StatusInativo
            // 
            this.rdb_StatusInativo.AutoSize = true;
            this.rdb_StatusInativo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_StatusInativo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rdb_StatusInativo.Location = new System.Drawing.Point(139, 88);
            this.rdb_StatusInativo.Name = "rdb_StatusInativo";
            this.rdb_StatusInativo.Size = new System.Drawing.Size(61, 18);
            this.rdb_StatusInativo.TabIndex = 6;
            this.rdb_StatusInativo.Text = "Inativo";
            this.rdb_StatusInativo.UseVisualStyleBackColor = true;
            // 
            // rdb_StatusAtivo
            // 
            this.rdb_StatusAtivo.AutoSize = true;
            this.rdb_StatusAtivo.Checked = true;
            this.rdb_StatusAtivo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_StatusAtivo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rdb_StatusAtivo.Location = new System.Drawing.Point(69, 88);
            this.rdb_StatusAtivo.Name = "rdb_StatusAtivo";
            this.rdb_StatusAtivo.Size = new System.Drawing.Size(53, 18);
            this.rdb_StatusAtivo.TabIndex = 5;
            this.rdb_StatusAtivo.TabStop = true;
            this.rdb_StatusAtivo.Text = "Ativo";
            this.rdb_StatusAtivo.UseVisualStyleBackColor = true;
            // 
            // lbl_StatusDoUsuario
            // 
            this.lbl_StatusDoUsuario.AutoSize = true;
            this.lbl_StatusDoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_StatusDoUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StatusDoUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_StatusDoUsuario.Location = new System.Drawing.Point(13, 89);
            this.lbl_StatusDoUsuario.Name = "lbl_StatusDoUsuario";
            this.lbl_StatusDoUsuario.Size = new System.Drawing.Size(47, 15);
            this.lbl_StatusDoUsuario.TabIndex = 4;
            this.lbl_StatusDoUsuario.Text = "Status:";
            // 
            // txt_LoginDoUsuario
            // 
            this.txt_LoginDoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LoginDoUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_LoginDoUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoginDoUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.err_ValidaUsuario.SetIconPadding(this.txt_LoginDoUsuario, 5);
            this.txt_LoginDoUsuario.Location = new System.Drawing.Point(69, 54);
            this.txt_LoginDoUsuario.MaxLength = 10;
            this.txt_LoginDoUsuario.Name = "txt_LoginDoUsuario";
            this.txt_LoginDoUsuario.Size = new System.Drawing.Size(194, 22);
            this.txt_LoginDoUsuario.TabIndex = 3;
            this.txt_LoginDoUsuario.Tag = "Login";
            this.txt_LoginDoUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txt_LoginDoUsuario_Validating);
            // 
            // txt_NomeDoUsuario
            // 
            this.txt_NomeDoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NomeDoUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeDoUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.err_ValidaUsuario.SetIconPadding(this.txt_NomeDoUsuario, 5);
            this.txt_NomeDoUsuario.Location = new System.Drawing.Point(69, 24);
            this.txt_NomeDoUsuario.MaxLength = 60;
            this.txt_NomeDoUsuario.Name = "txt_NomeDoUsuario";
            this.txt_NomeDoUsuario.Size = new System.Drawing.Size(372, 22);
            this.txt_NomeDoUsuario.TabIndex = 1;
            this.txt_NomeDoUsuario.Tag = "Nome do Usuário";
            this.txt_NomeDoUsuario.Validating += new System.ComponentModel.CancelEventHandler(this.txt_NomeDoUsuario_Validating);
            // 
            // lbl_LoginDoUsuario
            // 
            this.lbl_LoginDoUsuario.AutoSize = true;
            this.lbl_LoginDoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_LoginDoUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginDoUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_LoginDoUsuario.Location = new System.Drawing.Point(19, 57);
            this.lbl_LoginDoUsuario.Name = "lbl_LoginDoUsuario";
            this.lbl_LoginDoUsuario.Size = new System.Drawing.Size(41, 15);
            this.lbl_LoginDoUsuario.TabIndex = 2;
            this.lbl_LoginDoUsuario.Text = "Login:";
            // 
            // lbl_NomeDoUsuario
            // 
            this.lbl_NomeDoUsuario.AutoSize = true;
            this.lbl_NomeDoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_NomeDoUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeDoUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NomeDoUsuario.Location = new System.Drawing.Point(19, 27);
            this.lbl_NomeDoUsuario.Name = "lbl_NomeDoUsuario";
            this.lbl_NomeDoUsuario.Size = new System.Drawing.Size(43, 15);
            this.lbl_NomeDoUsuario.TabIndex = 0;
            this.lbl_NomeDoUsuario.Text = "Nome:";
            // 
            // grd_Usuarios
            // 
            this.grd_Usuarios.AllowUserToAddRows = false;
            this.grd_Usuarios.AllowUserToDeleteRows = false;
            this.grd_Usuarios.AllowUserToResizeColumns = false;
            this.grd_Usuarios.AllowUserToResizeRows = false;
            this.grd_Usuarios.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grd_Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_Usuarios.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.grd_Usuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_Usuarios.ColumnHeadersHeight = 28;
            this.grd_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd_Usuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDoUsuario,
            this.FotoDePerfil,
            this.LoginDoUsuario,
            this.NomeDoUsuario,
            this.DataDeCadastro,
            this.StatusDoUsuario,
            this.UsuarioGerente});
            this.grd_Usuarios.EnableHeadersVisualStyles = false;
            this.grd_Usuarios.GridColor = System.Drawing.Color.White;
            this.grd_Usuarios.Location = new System.Drawing.Point(14, 139);
            this.grd_Usuarios.MultiSelect = false;
            this.grd_Usuarios.Name = "grd_Usuarios";
            this.grd_Usuarios.ReadOnly = true;
            this.grd_Usuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grd_Usuarios.RowHeadersVisible = false;
            this.grd_Usuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_Usuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Usuarios.Size = new System.Drawing.Size(658, 177);
            this.grd_Usuarios.StandardTab = true;
            this.grd_Usuarios.TabIndex = 9;
            this.grd_Usuarios.SelectionChanged += new System.EventHandler(this.grd_Usuarios_SelectionChanged);
            // 
            // CodigoDoUsuario
            // 
            this.CodigoDoUsuario.DataPropertyName = "CodigoDoUsuario";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            this.CodigoDoUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodigoDoUsuario.HeaderText = "Código";
            this.CodigoDoUsuario.Name = "CodigoDoUsuario";
            this.CodigoDoUsuario.ReadOnly = true;
            this.CodigoDoUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoDoUsuario.Visible = false;
            // 
            // FotoDePerfil
            // 
            this.FotoDePerfil.DataPropertyName = "FotoDePerfil";
            this.FotoDePerfil.HeaderText = "FotoDePerfil";
            this.FotoDePerfil.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.FotoDePerfil.Name = "FotoDePerfil";
            this.FotoDePerfil.ReadOnly = true;
            this.FotoDePerfil.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FotoDePerfil.Visible = false;
            // 
            // LoginDoUsuario
            // 
            this.LoginDoUsuario.DataPropertyName = "LoginDoUsuario";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            this.LoginDoUsuario.DefaultCellStyle = dataGridViewCellStyle3;
            this.LoginDoUsuario.HeaderText = "Login";
            this.LoginDoUsuario.Name = "LoginDoUsuario";
            this.LoginDoUsuario.ReadOnly = true;
            this.LoginDoUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LoginDoUsuario.Width = 60;
            // 
            // NomeDoUsuario
            // 
            this.NomeDoUsuario.DataPropertyName = "NomeDoUsuario";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gray;
            this.NomeDoUsuario.DefaultCellStyle = dataGridViewCellStyle4;
            this.NomeDoUsuario.HeaderText = "Nome";
            this.NomeDoUsuario.Name = "NomeDoUsuario";
            this.NomeDoUsuario.ReadOnly = true;
            this.NomeDoUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeDoUsuario.Width = 340;
            // 
            // DataDeCadastro
            // 
            this.DataDeCadastro.DataPropertyName = "DataHoraDeCadastro";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gray;
            this.DataDeCadastro.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataDeCadastro.HeaderText = "Data de Cadastro";
            this.DataDeCadastro.Name = "DataDeCadastro";
            this.DataDeCadastro.ReadOnly = true;
            this.DataDeCadastro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataDeCadastro.Width = 130;
            // 
            // StatusDoUsuario
            // 
            this.StatusDoUsuario.DataPropertyName = "StatusDoUsuario";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StatusDoUsuario.DefaultCellStyle = dataGridViewCellStyle6;
            this.StatusDoUsuario.HeaderText = "Status";
            this.StatusDoUsuario.Name = "StatusDoUsuario";
            this.StatusDoUsuario.ReadOnly = true;
            this.StatusDoUsuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StatusDoUsuario.Width = 45;
            // 
            // UsuarioGerente
            // 
            this.UsuarioGerente.DataPropertyName = "UsuarioGerente";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = false;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UsuarioGerente.DefaultCellStyle = dataGridViewCellStyle7;
            this.UsuarioGerente.HeaderText = "Gerente";
            this.UsuarioGerente.Name = "UsuarioGerente";
            this.UsuarioGerente.ReadOnly = true;
            this.UsuarioGerente.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UsuarioGerente.Width = 55;
            // 
            // dlg_PesquisaImagem
            // 
            this.dlg_PesquisaImagem.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            // 
            // err_ValidaUsuario
            // 
            this.err_ValidaUsuario.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_ValidaUsuario.ContainerControl = this;
            this.err_ValidaUsuario.Icon = ((System.Drawing.Icon)(resources.GetObject("err_ValidaUsuario.Icon")));
            // 
            // frm_CadastroDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 372);
            this.Controls.Add(this.grd_Usuarios);
            this.Controls.Add(this.grp_InfoUsuario);
            this.Controls.Add(this.tls_ControleDeRegistro);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CadastroDeUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Usuários";
            this.Load += new System.EventHandler(this.frm_CadastroDeUsuario_Load);
            this.Shown += new System.EventHandler(this.frm_CadastroDeUsuario_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_CadastroDeUsuario_KeyPress);
            this.tls_ControleDeRegistro.ResumeLayout(false);
            this.tls_ControleDeRegistro.PerformLayout();
            this.grp_InfoUsuario.ResumeLayout(false);
            this.grp_InfoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ImagemDoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_ValidaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tls_ControleDeRegistro;
        private System.Windows.Forms.ToolStripButton btn_NovoRegistro;
        private System.Windows.Forms.ToolStripButton btn_SalvarRegistro;
        private System.Windows.Forms.ToolStripButton btn_CancelarAlteracao;
        private System.Windows.Forms.ToolStripButton btn_PesquisarRegistro;
        private System.Windows.Forms.ToolStripTextBox txt_PesquisaUsuario;
        private System.Windows.Forms.ToolStripButton btn_ExcluirRegistro;
        private System.Windows.Forms.GroupBox grp_InfoUsuario;
        private System.Windows.Forms.Label lbl_LoginDoUsuario;
        private System.Windows.Forms.Label lbl_NomeDoUsuario;
        private System.Windows.Forms.TextBox txt_LoginDoUsuario;
        private System.Windows.Forms.TextBox txt_NomeDoUsuario;
        private System.Windows.Forms.MaskedTextBox msk_DataHoraDeCadastro;
        private System.Windows.Forms.Label lbl_DataDeCadastro;
        private System.Windows.Forms.RadioButton rdb_StatusInativo;
        private System.Windows.Forms.RadioButton rdb_StatusAtivo;
        private System.Windows.Forms.Label lbl_StatusDoUsuario;
        private System.Windows.Forms.PictureBox pic_ImagemDoUsuario;
        private System.Windows.Forms.CheckBox chk_UsuarioGerente;
        private System.Windows.Forms.OpenFileDialog dlg_PesquisaImagem;
        private System.Windows.Forms.ErrorProvider err_ValidaUsuario;
        private System.Windows.Forms.DataGridView grd_Usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDoUsuario;
        private System.Windows.Forms.DataGridViewImageColumn FotoDePerfil;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginDoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDeCadastro;
        private System.Windows.Forms.DataGridViewCheckBoxColumn StatusDoUsuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn UsuarioGerente;
    }
}