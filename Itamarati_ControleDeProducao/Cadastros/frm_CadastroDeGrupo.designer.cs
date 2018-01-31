namespace Itamarati_ControleDeProducao.Cadastros
{
    partial class frm_CadastroDeGrupo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadastroDeGrupo));
            this.btn_ExcluirRegistro = new System.Windows.Forms.ToolStripButton();
            this.msk_DataHoraDeCadastroDoGrupo = new System.Windows.Forms.MaskedTextBox();
            this.lbl_DataDeCadastroDoGrupo = new System.Windows.Forms.Label();
            this.btn_CancelarAlteracao = new System.Windows.Forms.ToolStripButton();
            this.btn_SalvarRegistro = new System.Windows.Forms.ToolStripButton();
            this.btn_NovoRegistro = new System.Windows.Forms.ToolStripButton();
            this.tls_ControleDeRegistro = new System.Windows.Forms.ToolStrip();
            this.btn_PesquisarRegistro = new System.Windows.Forms.ToolStripButton();
            this.txt_Pesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.txt_CodigoDoGrupo = new System.Windows.Forms.TextBox();
            this.lbl_CodigoDoGrupo = new System.Windows.Forms.Label();
            this.txt_NomeDoGrupo = new System.Windows.Forms.TextBox();
            this.lbl_NomeDoGrupo = new System.Windows.Forms.Label();
            this.grd_Grupos = new System.Windows.Forms.DataGridView();
            this.CodigoDoGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDoGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDeCadastroDoGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grp_InfoGrupo = new System.Windows.Forms.GroupBox();
            this.err_ValidaGrupo = new System.Windows.Forms.ErrorProvider(this.components);
            this.tls_ControleDeRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Grupos)).BeginInit();
            this.grp_InfoGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_ValidaGrupo)).BeginInit();
            this.SuspendLayout();
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
            // msk_DataHoraDeCadastroDoGrupo
            // 
            this.msk_DataHoraDeCadastroDoGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_DataHoraDeCadastroDoGrupo.Enabled = false;
            this.msk_DataHoraDeCadastroDoGrupo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_DataHoraDeCadastroDoGrupo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.msk_DataHoraDeCadastroDoGrupo.Location = new System.Drawing.Point(547, 53);
            this.msk_DataHoraDeCadastroDoGrupo.Mask = "00/00/0000 90:00";
            this.msk_DataHoraDeCadastroDoGrupo.Name = "msk_DataHoraDeCadastroDoGrupo";
            this.msk_DataHoraDeCadastroDoGrupo.Size = new System.Drawing.Size(112, 22);
            this.msk_DataHoraDeCadastroDoGrupo.TabIndex = 2;
            this.msk_DataHoraDeCadastroDoGrupo.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_DataDeCadastroDoGrupo
            // 
            this.lbl_DataDeCadastroDoGrupo.AutoSize = true;
            this.lbl_DataDeCadastroDoGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_DataDeCadastroDoGrupo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataDeCadastroDoGrupo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_DataDeCadastroDoGrupo.Location = new System.Drawing.Point(479, 56);
            this.lbl_DataDeCadastroDoGrupo.Name = "lbl_DataDeCadastroDoGrupo";
            this.lbl_DataDeCadastroDoGrupo.Size = new System.Drawing.Size(62, 15);
            this.lbl_DataDeCadastroDoGrupo.TabIndex = 7;
            this.lbl_DataDeCadastroDoGrupo.Text = "Cadastro:";
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
            this.txt_Pesquisa,
            this.btn_ExcluirRegistro});
            this.tls_ControleDeRegistro.Location = new System.Drawing.Point(0, 303);
            this.tls_ControleDeRegistro.Name = "tls_ControleDeRegistro";
            this.tls_ControleDeRegistro.Padding = new System.Windows.Forms.Padding(0);
            this.tls_ControleDeRegistro.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tls_ControleDeRegistro.Size = new System.Drawing.Size(700, 42);
            this.tls_ControleDeRegistro.Stretch = true;
            this.tls_ControleDeRegistro.TabIndex = 13;
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
            // txt_Pesquisa
            // 
            this.txt_Pesquisa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txt_Pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pesquisa.Margin = new System.Windows.Forms.Padding(1, 3, 10, 3);
            this.txt_Pesquisa.MaxLength = 20;
            this.txt_Pesquisa.Name = "txt_Pesquisa";
            this.txt_Pesquisa.Size = new System.Drawing.Size(150, 36);
            this.txt_Pesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Pesquisa_KeyPress);
            // 
            // txt_CodigoDoGrupo
            // 
            this.txt_CodigoDoGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CodigoDoGrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_CodigoDoGrupo.Enabled = false;
            this.txt_CodigoDoGrupo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoDoGrupo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.err_ValidaGrupo.SetIconPadding(this.txt_CodigoDoGrupo, 5);
            this.txt_CodigoDoGrupo.Location = new System.Drawing.Point(68, 23);
            this.txt_CodigoDoGrupo.MaxLength = 3;
            this.txt_CodigoDoGrupo.Name = "txt_CodigoDoGrupo";
            this.txt_CodigoDoGrupo.Size = new System.Drawing.Size(39, 22);
            this.txt_CodigoDoGrupo.TabIndex = 11;
            this.txt_CodigoDoGrupo.Tag = "o Código do Grupo";
            this.txt_CodigoDoGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoDoGrupo_KeyPress);
            this.txt_CodigoDoGrupo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_CodigoDoGrupo_Validating);
            // 
            // lbl_CodigoDoGrupo
            // 
            this.lbl_CodigoDoGrupo.AutoSize = true;
            this.lbl_CodigoDoGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_CodigoDoGrupo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodigoDoGrupo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_CodigoDoGrupo.Location = new System.Drawing.Point(14, 26);
            this.lbl_CodigoDoGrupo.Name = "lbl_CodigoDoGrupo";
            this.lbl_CodigoDoGrupo.Size = new System.Drawing.Size(49, 15);
            this.lbl_CodigoDoGrupo.TabIndex = 10;
            this.lbl_CodigoDoGrupo.Text = "Código:";
            // 
            // txt_NomeDoGrupo
            // 
            this.txt_NomeDoGrupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NomeDoGrupo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeDoGrupo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.err_ValidaGrupo.SetIconPadding(this.txt_NomeDoGrupo, 5);
            this.txt_NomeDoGrupo.Location = new System.Drawing.Point(68, 53);
            this.txt_NomeDoGrupo.MaxLength = 60;
            this.txt_NomeDoGrupo.Name = "txt_NomeDoGrupo";
            this.txt_NomeDoGrupo.Size = new System.Drawing.Size(379, 22);
            this.txt_NomeDoGrupo.TabIndex = 1;
            this.txt_NomeDoGrupo.Tag = "o Nome do Grupo";
            this.txt_NomeDoGrupo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_NomeDoGrupo_Validating);
            // 
            // lbl_NomeDoGrupo
            // 
            this.lbl_NomeDoGrupo.AutoSize = true;
            this.lbl_NomeDoGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_NomeDoGrupo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeDoGrupo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NomeDoGrupo.Location = new System.Drawing.Point(20, 56);
            this.lbl_NomeDoGrupo.Name = "lbl_NomeDoGrupo";
            this.lbl_NomeDoGrupo.Size = new System.Drawing.Size(43, 15);
            this.lbl_NomeDoGrupo.TabIndex = 0;
            this.lbl_NomeDoGrupo.Text = "Nome:";
            // 
            // grd_Grupos
            // 
            this.grd_Grupos.AllowUserToAddRows = false;
            this.grd_Grupos.AllowUserToDeleteRows = false;
            this.grd_Grupos.AllowUserToResizeColumns = false;
            this.grd_Grupos.AllowUserToResizeRows = false;
            this.grd_Grupos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grd_Grupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_Grupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Grupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_Grupos.ColumnHeadersHeight = 28;
            this.grd_Grupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd_Grupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDoGrupo,
            this.NomeDoGrupo,
            this.DataDeCadastroDoGrupo});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Grupos.DefaultCellStyle = dataGridViewCellStyle4;
            this.grd_Grupos.EnableHeadersVisualStyles = false;
            this.grd_Grupos.GridColor = System.Drawing.Color.White;
            this.grd_Grupos.Location = new System.Drawing.Point(12, 115);
            this.grd_Grupos.MultiSelect = false;
            this.grd_Grupos.Name = "grd_Grupos";
            this.grd_Grupos.ReadOnly = true;
            this.grd_Grupos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Grupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grd_Grupos.RowHeadersVisible = false;
            this.grd_Grupos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_Grupos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_Grupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Grupos.Size = new System.Drawing.Size(675, 177);
            this.grd_Grupos.StandardTab = true;
            this.grd_Grupos.TabIndex = 12;
            this.grd_Grupos.SelectionChanged += new System.EventHandler(this.grd_Grupos_SelectionChanged);
            // 
            // CodigoDoGrupo
            // 
            this.CodigoDoGrupo.DataPropertyName = "CodigoDoGrupo";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            this.CodigoDoGrupo.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodigoDoGrupo.HeaderText = "Código";
            this.CodigoDoGrupo.MaxInputLength = 3;
            this.CodigoDoGrupo.Name = "CodigoDoGrupo";
            this.CodigoDoGrupo.ReadOnly = true;
            this.CodigoDoGrupo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoDoGrupo.Width = 55;
            // 
            // NomeDoGrupo
            // 
            this.NomeDoGrupo.DataPropertyName = "NomeDoGrupo";
            this.NomeDoGrupo.HeaderText = "Nome";
            this.NomeDoGrupo.Name = "NomeDoGrupo";
            this.NomeDoGrupo.ReadOnly = true;
            this.NomeDoGrupo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeDoGrupo.Width = 450;
            // 
            // DataDeCadastroDoGrupo
            // 
            this.DataDeCadastroDoGrupo.DataPropertyName = "DataHoraDeCadastroDoGrupo";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            this.DataDeCadastroDoGrupo.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataDeCadastroDoGrupo.HeaderText = "Data e Hora de Cadastro";
            this.DataDeCadastroDoGrupo.Name = "DataDeCadastroDoGrupo";
            this.DataDeCadastroDoGrupo.ReadOnly = true;
            this.DataDeCadastroDoGrupo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataDeCadastroDoGrupo.Width = 150;
            // 
            // grp_InfoGrupo
            // 
            this.grp_InfoGrupo.Controls.Add(this.txt_CodigoDoGrupo);
            this.grp_InfoGrupo.Controls.Add(this.lbl_CodigoDoGrupo);
            this.grp_InfoGrupo.Controls.Add(this.msk_DataHoraDeCadastroDoGrupo);
            this.grp_InfoGrupo.Controls.Add(this.lbl_DataDeCadastroDoGrupo);
            this.grp_InfoGrupo.Controls.Add(this.txt_NomeDoGrupo);
            this.grp_InfoGrupo.Controls.Add(this.lbl_NomeDoGrupo);
            this.grp_InfoGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grp_InfoGrupo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_InfoGrupo.Location = new System.Drawing.Point(12, 12);
            this.grp_InfoGrupo.Name = "grp_InfoGrupo";
            this.grp_InfoGrupo.Size = new System.Drawing.Size(675, 90);
            this.grp_InfoGrupo.TabIndex = 14;
            this.grp_InfoGrupo.TabStop = false;
            this.grp_InfoGrupo.Text = "Informações do Grupo";
            // 
            // err_ValidaGrupo
            // 
            this.err_ValidaGrupo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_ValidaGrupo.ContainerControl = this;
            this.err_ValidaGrupo.Icon = ((System.Drawing.Icon)(resources.GetObject("err_ValidaGrupo.Icon")));
            // 
            // frm_CadastroDeGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 345);
            this.Controls.Add(this.tls_ControleDeRegistro);
            this.Controls.Add(this.grd_Grupos);
            this.Controls.Add(this.grp_InfoGrupo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CadastroDeGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Grupo";
            this.Load += new System.EventHandler(this.frm_CadastroDeGrupo_Load);
            this.Shown += new System.EventHandler(this.frm_CadastroDeGrupo_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_CadastroDeGrupo_KeyPress);
            this.tls_ControleDeRegistro.ResumeLayout(false);
            this.tls_ControleDeRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Grupos)).EndInit();
            this.grp_InfoGrupo.ResumeLayout(false);
            this.grp_InfoGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_ValidaGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btn_ExcluirRegistro;
        private System.Windows.Forms.MaskedTextBox msk_DataHoraDeCadastroDoGrupo;
        private System.Windows.Forms.Label lbl_DataDeCadastroDoGrupo;
        private System.Windows.Forms.ToolStripButton btn_CancelarAlteracao;
        private System.Windows.Forms.ToolStripButton btn_SalvarRegistro;
        private System.Windows.Forms.ToolStripButton btn_NovoRegistro;
        private System.Windows.Forms.ToolStrip tls_ControleDeRegistro;
        private System.Windows.Forms.ToolStripButton btn_PesquisarRegistro;
        private System.Windows.Forms.ToolStripTextBox txt_Pesquisa;
        private System.Windows.Forms.TextBox txt_CodigoDoGrupo;
        private System.Windows.Forms.Label lbl_CodigoDoGrupo;
        private System.Windows.Forms.TextBox txt_NomeDoGrupo;
        private System.Windows.Forms.Label lbl_NomeDoGrupo;
        private System.Windows.Forms.DataGridView grd_Grupos;
        private System.Windows.Forms.GroupBox grp_InfoGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDoGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDeCadastroDoGrupo;
        private System.Windows.Forms.ErrorProvider err_ValidaGrupo;
    }
}