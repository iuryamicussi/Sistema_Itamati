namespace Itamarati_ControleDeProducao.Manutenção
{
    partial class frm_ControleDeProducao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tls_ControleDeRegistro = new System.Windows.Forms.ToolStrip();
            this.btn_ImprimirRegistro = new System.Windows.Forms.ToolStripButton();
            this.btn_PesquisarRegistro = new System.Windows.Forms.ToolStripButton();
            this.txt_Pesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.grp_Filtros = new System.Windows.Forms.GroupBox();
            this.grd_Produto = new System.Windows.Forms.DataGridView();
            this.Imprimir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CodigoDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComprimentoDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LarguraDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EspessuraDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PesoTotalDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnitarioDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataHoraDeCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_Grupo = new System.Windows.Forms.ComboBox();
            this.lbl_Grupo = new System.Windows.Forms.Label();
            this.tls_ControleDeRegistro.SuspendLayout();
            this.grp_Filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Produto)).BeginInit();
            this.SuspendLayout();
            // 
            // tls_ControleDeRegistro
            // 
            this.tls_ControleDeRegistro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tls_ControleDeRegistro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tls_ControleDeRegistro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tls_ControleDeRegistro.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tls_ControleDeRegistro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ImprimirRegistro,
            this.btn_PesquisarRegistro,
            this.txt_Pesquisa});
            this.tls_ControleDeRegistro.Location = new System.Drawing.Point(0, 297);
            this.tls_ControleDeRegistro.Name = "tls_ControleDeRegistro";
            this.tls_ControleDeRegistro.Padding = new System.Windows.Forms.Padding(0);
            this.tls_ControleDeRegistro.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tls_ControleDeRegistro.Size = new System.Drawing.Size(1100, 42);
            this.tls_ControleDeRegistro.Stretch = true;
            this.tls_ControleDeRegistro.TabIndex = 15;
            // 
            // btn_ImprimirRegistro
            // 
            this.btn_ImprimirRegistro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ImprimirRegistro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImprimirRegistro.ForeColor = System.Drawing.Color.White;
            this.btn_ImprimirRegistro.Image = global::Itamarati_ControleDeProducao.Properties.Resources.Imprimir_36;
            this.btn_ImprimirRegistro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_ImprimirRegistro.ImageTransparentColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ImprimirRegistro.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.btn_ImprimirRegistro.Name = "btn_ImprimirRegistro";
            this.btn_ImprimirRegistro.Size = new System.Drawing.Size(90, 36);
            this.btn_ImprimirRegistro.Text = "Imprimir";
            this.btn_ImprimirRegistro.Click += new System.EventHandler(this.btn_ImprimirRegistro_Click);
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
            // grp_Filtros
            // 
            this.grp_Filtros.Controls.Add(this.grd_Produto);
            this.grp_Filtros.Controls.Add(this.cmb_Grupo);
            this.grp_Filtros.Controls.Add(this.lbl_Grupo);
            this.grp_Filtros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grp_Filtros.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_Filtros.Location = new System.Drawing.Point(12, 12);
            this.grp_Filtros.Name = "grp_Filtros";
            this.grp_Filtros.Size = new System.Drawing.Size(1076, 274);
            this.grp_Filtros.TabIndex = 16;
            this.grp_Filtros.TabStop = false;
            this.grp_Filtros.Text = "Filtros";
            // 
            // grd_Produto
            // 
            this.grd_Produto.AllowUserToAddRows = false;
            this.grd_Produto.AllowUserToDeleteRows = false;
            this.grd_Produto.AllowUserToResizeColumns = false;
            this.grd_Produto.AllowUserToResizeRows = false;
            this.grd_Produto.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grd_Produto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_Produto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Produto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_Produto.ColumnHeadersHeight = 28;
            this.grd_Produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd_Produto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imprimir,
            this.CodigoDoProduto,
            this.NomeDoProduto,
            this.ComprimentoDoProduto,
            this.LarguraDoProduto,
            this.EspessuraDoProduto,
            this.PesoTotalDoProduto,
            this.PrecoUnitarioDoProduto,
            this.DataHoraDeCadastro});
            this.grd_Produto.EnableHeadersVisualStyles = false;
            this.grd_Produto.GridColor = System.Drawing.Color.White;
            this.grd_Produto.Location = new System.Drawing.Point(26, 69);
            this.grd_Produto.MultiSelect = false;
            this.grd_Produto.Name = "grd_Produto";
            this.grd_Produto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Produto.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grd_Produto.RowHeadersVisible = false;
            this.grd_Produto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_Produto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_Produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Produto.Size = new System.Drawing.Size(1022, 177);
            this.grd_Produto.StandardTab = true;
            this.grd_Produto.TabIndex = 2;
            this.grd_Produto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_Produto_CellContentClick);
            // 
            // Imprimir
            // 
            this.Imprimir.DataPropertyName = "Imprimir";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Imprimir.DefaultCellStyle = dataGridViewCellStyle2;
            this.Imprimir.FalseValue = "F";
            this.Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Imprimir.HeaderText = "Imprimir";
            this.Imprimir.IndeterminateValue = "F";
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Imprimir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Imprimir.TrueValue = "T";
            this.Imprimir.Width = 50;
            // 
            // CodigoDoProduto
            // 
            this.CodigoDoProduto.DataPropertyName = "CodigoDoProduto";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CodigoDoProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.CodigoDoProduto.HeaderText = "Código";
            this.CodigoDoProduto.Name = "CodigoDoProduto";
            this.CodigoDoProduto.ReadOnly = true;
            this.CodigoDoProduto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoDoProduto.Width = 70;
            // 
            // NomeDoProduto
            // 
            this.NomeDoProduto.DataPropertyName = "DescricaoDoProduto";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gray;
            this.NomeDoProduto.DefaultCellStyle = dataGridViewCellStyle4;
            this.NomeDoProduto.HeaderText = "Descrição";
            this.NomeDoProduto.Name = "NomeDoProduto";
            this.NomeDoProduto.ReadOnly = true;
            this.NomeDoProduto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeDoProduto.Width = 390;
            // 
            // ComprimentoDoProduto
            // 
            this.ComprimentoDoProduto.DataPropertyName = "ComprimentoDoProduto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Format = "N4";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ComprimentoDoProduto.DefaultCellStyle = dataGridViewCellStyle5;
            this.ComprimentoDoProduto.HeaderText = "Comprimento";
            this.ComprimentoDoProduto.Name = "ComprimentoDoProduto";
            this.ComprimentoDoProduto.ReadOnly = true;
            this.ComprimentoDoProduto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ComprimentoDoProduto.Width = 90;
            // 
            // LarguraDoProduto
            // 
            this.LarguraDoProduto.DataPropertyName = "LarguraDoProduto";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Format = "N4";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LarguraDoProduto.DefaultCellStyle = dataGridViewCellStyle6;
            this.LarguraDoProduto.HeaderText = "           Largura";
            this.LarguraDoProduto.Name = "LarguraDoProduto";
            this.LarguraDoProduto.ReadOnly = true;
            this.LarguraDoProduto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LarguraDoProduto.Width = 90;
            // 
            // EspessuraDoProduto
            // 
            this.EspessuraDoProduto.DataPropertyName = "EspessuraDoProduto";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Format = "N4";
            dataGridViewCellStyle7.NullValue = "0,0000";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EspessuraDoProduto.DefaultCellStyle = dataGridViewCellStyle7;
            this.EspessuraDoProduto.HeaderText = "     Espessura";
            this.EspessuraDoProduto.Name = "EspessuraDoProduto";
            this.EspessuraDoProduto.ReadOnly = true;
            this.EspessuraDoProduto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EspessuraDoProduto.Width = 90;
            // 
            // PesoTotalDoProduto
            // 
            this.PesoTotalDoProduto.DataPropertyName = "PesoTotalDoProduto";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Format = "N4";
            dataGridViewCellStyle8.NullValue = null;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PesoTotalDoProduto.DefaultCellStyle = dataGridViewCellStyle8;
            this.PesoTotalDoProduto.HeaderText = "                Peso";
            this.PesoTotalDoProduto.Name = "PesoTotalDoProduto";
            this.PesoTotalDoProduto.ReadOnly = true;
            this.PesoTotalDoProduto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PesoTotalDoProduto.Width = 90;
            // 
            // PrecoUnitarioDoProduto
            // 
            this.PrecoUnitarioDoProduto.DataPropertyName = "PrecoUnitarioDoProduto";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle9.Format = "C3";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PrecoUnitarioDoProduto.DefaultCellStyle = dataGridViewCellStyle9;
            this.PrecoUnitarioDoProduto.HeaderText = "                           Preço";
            this.PrecoUnitarioDoProduto.Name = "PrecoUnitarioDoProduto";
            this.PrecoUnitarioDoProduto.ReadOnly = true;
            this.PrecoUnitarioDoProduto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PrecoUnitarioDoProduto.Width = 130;
            // 
            // DataHoraDeCadastro
            // 
            this.DataHoraDeCadastro.DataPropertyName = "DataHoraDeCadastro";
            this.DataHoraDeCadastro.HeaderText = "Data de Cadastro";
            this.DataHoraDeCadastro.Name = "DataHoraDeCadastro";
            this.DataHoraDeCadastro.ReadOnly = true;
            this.DataHoraDeCadastro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataHoraDeCadastro.Visible = false;
            // 
            // cmb_Grupo
            // 
            this.cmb_Grupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Grupo.Font = new System.Drawing.Font("Arial", 9.75F);
            this.cmb_Grupo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmb_Grupo.FormattingEnabled = true;
            this.cmb_Grupo.Location = new System.Drawing.Point(74, 28);
            this.cmb_Grupo.Name = "cmb_Grupo";
            this.cmb_Grupo.Size = new System.Drawing.Size(316, 24);
            this.cmb_Grupo.TabIndex = 0;
            this.cmb_Grupo.SelectedIndexChanged += new System.EventHandler(this.cmb_Grupo_SelectedIndexChanged);
            // 
            // lbl_Grupo
            // 
            this.lbl_Grupo.AutoSize = true;
            this.lbl_Grupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Grupo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Grupo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Grupo.Location = new System.Drawing.Point(27, 32);
            this.lbl_Grupo.Name = "lbl_Grupo";
            this.lbl_Grupo.Size = new System.Drawing.Size(41, 15);
            this.lbl_Grupo.TabIndex = 0;
            this.lbl_Grupo.Text = "Grupo";
            // 
            // frm_ControleDeProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 339);
            this.Controls.Add(this.grp_Filtros);
            this.Controls.Add(this.tls_ControleDeRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ControleDeProducao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Produção";
            this.Shown += new System.EventHandler(this.frm_ControleDeProducao_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_ControleDeProducao_KeyDown);
            this.tls_ControleDeRegistro.ResumeLayout(false);
            this.tls_ControleDeRegistro.PerformLayout();
            this.grp_Filtros.ResumeLayout(false);
            this.grp_Filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tls_ControleDeRegistro;
        private System.Windows.Forms.ToolStripButton btn_ImprimirRegistro;
        private System.Windows.Forms.ToolStripButton btn_PesquisarRegistro;
        private System.Windows.Forms.ToolStripTextBox txt_Pesquisa;
        private System.Windows.Forms.GroupBox grp_Filtros;
        private System.Windows.Forms.Label lbl_Grupo;
        private System.Windows.Forms.ComboBox cmb_Grupo;
        private System.Windows.Forms.DataGridView grd_Produto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Imprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ComprimentoDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn LarguraDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn EspessuraDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PesoTotalDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnitarioDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataHoraDeCadastro;
    }
}