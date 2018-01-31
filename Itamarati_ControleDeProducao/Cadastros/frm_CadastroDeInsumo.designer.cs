namespace Itamarati_ControleDeProducao.Cadastros
{
    partial class frm_CadastroDeInsumo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CadastroDeInsumo));
            this.txt_NomeDoInsumo = new System.Windows.Forms.TextBox();
            this.txt_UnidadeDeMedidaDoInsumo = new System.Windows.Forms.TextBox();
            this.txt_ValorUnitarioDaUltimaCompraDoInsumo = new System.Windows.Forms.TextBox();
            this.msk_DataHoraDeCadastroDoInsumo = new System.Windows.Forms.MaskedTextBox();
            this.lbl_DataDeCadastro = new System.Windows.Forms.Label();
            this.grd_Insumos = new System.Windows.Forms.DataGridView();
            this.CodigoDoInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDoInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadeDeMedidaDoInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDeCadastroDoInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitarioDaUltimaCompraDoInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_UnidadeDeMedida = new System.Windows.Forms.Label();
            this.lbl_NomeDoInsumo = new System.Windows.Forms.Label();
            this.grp_InfoInsumo = new System.Windows.Forms.GroupBox();
            this.txt_CodigoDoInsumo = new System.Windows.Forms.TextBox();
            this.lbl_CodigoDoInsumo = new System.Windows.Forms.Label();
            this.lbl_ValorUnitarioDaUltimaCompraDoInsumo = new System.Windows.Forms.Label();
            this.txt_Pesquisa = new System.Windows.Forms.ToolStripTextBox();
            this.tls_ControleDeRegistro = new System.Windows.Forms.ToolStrip();
            this.btn_NovoRegistro = new System.Windows.Forms.ToolStripButton();
            this.btn_SalvarRegistro = new System.Windows.Forms.ToolStripButton();
            this.btn_CancelarAlteracao = new System.Windows.Forms.ToolStripButton();
            this.btn_PesquisarRegistro = new System.Windows.Forms.ToolStripButton();
            this.btn_ExcluirRegistro = new System.Windows.Forms.ToolStripButton();
            this.err_ValidaInsumo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Insumos)).BeginInit();
            this.grp_InfoInsumo.SuspendLayout();
            this.tls_ControleDeRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_ValidaInsumo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NomeDoInsumo
            // 
            this.txt_NomeDoInsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NomeDoInsumo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeDoInsumo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.err_ValidaInsumo.SetIconPadding(this.txt_NomeDoInsumo, 5);
            this.txt_NomeDoInsumo.Location = new System.Drawing.Point(211, 23);
            this.txt_NomeDoInsumo.MaxLength = 60;
            this.txt_NomeDoInsumo.Name = "txt_NomeDoInsumo";
            this.txt_NomeDoInsumo.Size = new System.Drawing.Size(370, 22);
            this.txt_NomeDoInsumo.TabIndex = 1;
            this.txt_NomeDoInsumo.Tag = "Nome do Usuário";
            this.txt_NomeDoInsumo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_NomeDoInsumo_Validating);
            // 
            // txt_UnidadeDeMedidaDoInsumo
            // 
            this.txt_UnidadeDeMedidaDoInsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UnidadeDeMedidaDoInsumo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_UnidadeDeMedidaDoInsumo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UnidadeDeMedidaDoInsumo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.err_ValidaInsumo.SetIconPadding(this.txt_UnidadeDeMedidaDoInsumo, 5);
            this.txt_UnidadeDeMedidaDoInsumo.Location = new System.Drawing.Point(419, 54);
            this.txt_UnidadeDeMedidaDoInsumo.MaxLength = 4;
            this.txt_UnidadeDeMedidaDoInsumo.Name = "txt_UnidadeDeMedidaDoInsumo";
            this.txt_UnidadeDeMedidaDoInsumo.Size = new System.Drawing.Size(41, 22);
            this.txt_UnidadeDeMedidaDoInsumo.TabIndex = 3;
            this.txt_UnidadeDeMedidaDoInsumo.Tag = "Login";
            this.txt_UnidadeDeMedidaDoInsumo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_UnidadeDeMedidaDoInsumo_Validating);
            // 
            // txt_ValorUnitarioDaUltimaCompraDoInsumo
            // 
            this.txt_ValorUnitarioDaUltimaCompraDoInsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ValorUnitarioDaUltimaCompraDoInsumo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ValorUnitarioDaUltimaCompraDoInsumo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.err_ValidaInsumo.SetIconPadding(this.txt_ValorUnitarioDaUltimaCompraDoInsumo, 5);
            this.txt_ValorUnitarioDaUltimaCompraDoInsumo.Location = new System.Drawing.Point(713, 54);
            this.txt_ValorUnitarioDaUltimaCompraDoInsumo.MaxLength = 10;
            this.txt_ValorUnitarioDaUltimaCompraDoInsumo.Name = "txt_ValorUnitarioDaUltimaCompraDoInsumo";
            this.txt_ValorUnitarioDaUltimaCompraDoInsumo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ValorUnitarioDaUltimaCompraDoInsumo.Size = new System.Drawing.Size(97, 22);
            this.txt_ValorUnitarioDaUltimaCompraDoInsumo.TabIndex = 4;
            this.txt_ValorUnitarioDaUltimaCompraDoInsumo.Tag = "Login";
            this.txt_ValorUnitarioDaUltimaCompraDoInsumo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_ValorUnitarioDaUltimaCompraDoInsumo_Validating);
            // 
            // msk_DataHoraDeCadastroDoInsumo
            // 
            this.msk_DataHoraDeCadastroDoInsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk_DataHoraDeCadastroDoInsumo.Enabled = false;
            this.msk_DataHoraDeCadastroDoInsumo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msk_DataHoraDeCadastroDoInsumo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.msk_DataHoraDeCadastroDoInsumo.Location = new System.Drawing.Point(694, 23);
            this.msk_DataHoraDeCadastroDoInsumo.Mask = "00/00/0000 90:00";
            this.msk_DataHoraDeCadastroDoInsumo.Name = "msk_DataHoraDeCadastroDoInsumo";
            this.msk_DataHoraDeCadastroDoInsumo.Size = new System.Drawing.Size(116, 22);
            this.msk_DataHoraDeCadastroDoInsumo.TabIndex = 2;
            this.msk_DataHoraDeCadastroDoInsumo.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_DataDeCadastro
            // 
            this.lbl_DataDeCadastro.AutoSize = true;
            this.lbl_DataDeCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_DataDeCadastro.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DataDeCadastro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_DataDeCadastro.Location = new System.Drawing.Point(626, 26);
            this.lbl_DataDeCadastro.Name = "lbl_DataDeCadastro";
            this.lbl_DataDeCadastro.Size = new System.Drawing.Size(62, 15);
            this.lbl_DataDeCadastro.TabIndex = 7;
            this.lbl_DataDeCadastro.Text = "Cadastro:";
            // 
            // grd_Insumos
            // 
            this.grd_Insumos.AllowUserToAddRows = false;
            this.grd_Insumos.AllowUserToDeleteRows = false;
            this.grd_Insumos.AllowUserToResizeColumns = false;
            this.grd_Insumos.AllowUserToResizeRows = false;
            this.grd_Insumos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grd_Insumos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_Insumos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Insumos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_Insumos.ColumnHeadersHeight = 28;
            this.grd_Insumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd_Insumos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDoInsumo,
            this.NomeDoInsumo,
            this.UnidadeDeMedidaDoInsumo,
            this.DataDeCadastroDoInsumo,
            this.ValorUnitarioDaUltimaCompraDoInsumo});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_Insumos.DefaultCellStyle = dataGridViewCellStyle7;
            this.grd_Insumos.EnableHeadersVisualStyles = false;
            this.grd_Insumos.GridColor = System.Drawing.Color.White;
            this.grd_Insumos.Location = new System.Drawing.Point(14, 108);
            this.grd_Insumos.MultiSelect = false;
            this.grd_Insumos.Name = "grd_Insumos";
            this.grd_Insumos.ReadOnly = true;
            this.grd_Insumos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_Insumos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grd_Insumos.RowHeadersVisible = false;
            this.grd_Insumos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_Insumos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_Insumos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_Insumos.Size = new System.Drawing.Size(846, 177);
            this.grd_Insumos.StandardTab = true;
            this.grd_Insumos.TabIndex = 5;
            this.grd_Insumos.SelectionChanged += new System.EventHandler(this.grd_Insumos_SelectionChanged);
            // 
            // CodigoDoInsumo
            // 
            this.CodigoDoInsumo.DataPropertyName = "CodigoDoInsumo";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CodigoDoInsumo.DefaultCellStyle = dataGridViewCellStyle2;
            this.CodigoDoInsumo.HeaderText = "Código";
            this.CodigoDoInsumo.Name = "CodigoDoInsumo";
            this.CodigoDoInsumo.ReadOnly = true;
            this.CodigoDoInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoDoInsumo.Width = 70;
            // 
            // NomeDoInsumo
            // 
            this.NomeDoInsumo.DataPropertyName = "NomeDoInsumo";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NomeDoInsumo.DefaultCellStyle = dataGridViewCellStyle3;
            this.NomeDoInsumo.HeaderText = "Nome";
            this.NomeDoInsumo.Name = "NomeDoInsumo";
            this.NomeDoInsumo.ReadOnly = true;
            this.NomeDoInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeDoInsumo.Width = 315;
            // 
            // UnidadeDeMedidaDoInsumo
            // 
            this.UnidadeDeMedidaDoInsumo.DataPropertyName = "UnidadeDeMedidaDoInsumo";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UnidadeDeMedidaDoInsumo.DefaultCellStyle = dataGridViewCellStyle4;
            this.UnidadeDeMedidaDoInsumo.HeaderText = "Unid. de Medida";
            this.UnidadeDeMedidaDoInsumo.Name = "UnidadeDeMedidaDoInsumo";
            this.UnidadeDeMedidaDoInsumo.ReadOnly = true;
            this.UnidadeDeMedidaDoInsumo.Width = 115;
            // 
            // DataDeCadastroDoInsumo
            // 
            this.DataDeCadastroDoInsumo.DataPropertyName = "DataHoraDeCadastroDoInsumo";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataDeCadastroDoInsumo.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataDeCadastroDoInsumo.HeaderText = "Data de Cadastro";
            this.DataDeCadastroDoInsumo.Name = "DataDeCadastroDoInsumo";
            this.DataDeCadastroDoInsumo.ReadOnly = true;
            this.DataDeCadastroDoInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataDeCadastroDoInsumo.Width = 130;
            // 
            // ValorUnitarioDaUltimaCompraDoInsumo
            // 
            this.ValorUnitarioDaUltimaCompraDoInsumo.DataPropertyName = "ValorUnitarioDaUltimaCompraDoInsumo";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Format = "C3";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ValorUnitarioDaUltimaCompraDoInsumo.DefaultCellStyle = dataGridViewCellStyle6;
            this.ValorUnitarioDaUltimaCompraDoInsumo.HeaderText = "Valor Unit. da Última Compra";
            this.ValorUnitarioDaUltimaCompraDoInsumo.Name = "ValorUnitarioDaUltimaCompraDoInsumo";
            this.ValorUnitarioDaUltimaCompraDoInsumo.ReadOnly = true;
            this.ValorUnitarioDaUltimaCompraDoInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ValorUnitarioDaUltimaCompraDoInsumo.Width = 180;
            // 
            // lbl_UnidadeDeMedida
            // 
            this.lbl_UnidadeDeMedida.AutoSize = true;
            this.lbl_UnidadeDeMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_UnidadeDeMedida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UnidadeDeMedida.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_UnidadeDeMedida.Location = new System.Drawing.Point(296, 57);
            this.lbl_UnidadeDeMedida.Name = "lbl_UnidadeDeMedida";
            this.lbl_UnidadeDeMedida.Size = new System.Drawing.Size(117, 15);
            this.lbl_UnidadeDeMedida.TabIndex = 2;
            this.lbl_UnidadeDeMedida.Text = "Unidade de Medida:";
            // 
            // lbl_NomeDoInsumo
            // 
            this.lbl_NomeDoInsumo.AutoSize = true;
            this.lbl_NomeDoInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_NomeDoInsumo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeDoInsumo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NomeDoInsumo.Location = new System.Drawing.Point(162, 26);
            this.lbl_NomeDoInsumo.Name = "lbl_NomeDoInsumo";
            this.lbl_NomeDoInsumo.Size = new System.Drawing.Size(43, 15);
            this.lbl_NomeDoInsumo.TabIndex = 0;
            this.lbl_NomeDoInsumo.Text = "Nome:";
            // 
            // grp_InfoInsumo
            // 
            this.grp_InfoInsumo.Controls.Add(this.txt_CodigoDoInsumo);
            this.grp_InfoInsumo.Controls.Add(this.lbl_CodigoDoInsumo);
            this.grp_InfoInsumo.Controls.Add(this.txt_ValorUnitarioDaUltimaCompraDoInsumo);
            this.grp_InfoInsumo.Controls.Add(this.lbl_ValorUnitarioDaUltimaCompraDoInsumo);
            this.grp_InfoInsumo.Controls.Add(this.msk_DataHoraDeCadastroDoInsumo);
            this.grp_InfoInsumo.Controls.Add(this.lbl_DataDeCadastro);
            this.grp_InfoInsumo.Controls.Add(this.txt_UnidadeDeMedidaDoInsumo);
            this.grp_InfoInsumo.Controls.Add(this.txt_NomeDoInsumo);
            this.grp_InfoInsumo.Controls.Add(this.lbl_UnidadeDeMedida);
            this.grp_InfoInsumo.Controls.Add(this.lbl_NomeDoInsumo);
            this.grp_InfoInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grp_InfoInsumo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_InfoInsumo.Location = new System.Drawing.Point(13, 2);
            this.grp_InfoInsumo.Name = "grp_InfoInsumo";
            this.grp_InfoInsumo.Size = new System.Drawing.Size(847, 91);
            this.grp_InfoInsumo.TabIndex = 11;
            this.grp_InfoInsumo.TabStop = false;
            this.grp_InfoInsumo.Text = "Informações do Insumo";
            // 
            // txt_CodigoDoInsumo
            // 
            this.txt_CodigoDoInsumo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CodigoDoInsumo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_CodigoDoInsumo.Enabled = false;
            this.txt_CodigoDoInsumo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoDoInsumo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.err_ValidaInsumo.SetIconPadding(this.txt_CodigoDoInsumo, 5);
            this.txt_CodigoDoInsumo.Location = new System.Drawing.Point(60, 23);
            this.txt_CodigoDoInsumo.MaxLength = 6;
            this.txt_CodigoDoInsumo.Name = "txt_CodigoDoInsumo";
            this.txt_CodigoDoInsumo.Size = new System.Drawing.Size(65, 22);
            this.txt_CodigoDoInsumo.TabIndex = 11;
            this.txt_CodigoDoInsumo.Tag = "Login";
            this.txt_CodigoDoInsumo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CodigoDoInsumo_KeyPress);
            this.txt_CodigoDoInsumo.Validating += new System.ComponentModel.CancelEventHandler(this.txt_CodigoDoInsumo_Validating);
            // 
            // lbl_CodigoDoInsumo
            // 
            this.lbl_CodigoDoInsumo.AutoSize = true;
            this.lbl_CodigoDoInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_CodigoDoInsumo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodigoDoInsumo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_CodigoDoInsumo.Location = new System.Drawing.Point(5, 26);
            this.lbl_CodigoDoInsumo.Name = "lbl_CodigoDoInsumo";
            this.lbl_CodigoDoInsumo.Size = new System.Drawing.Size(49, 15);
            this.lbl_CodigoDoInsumo.TabIndex = 10;
            this.lbl_CodigoDoInsumo.Text = "Código:";
            // 
            // lbl_ValorUnitarioDaUltimaCompraDoInsumo
            // 
            this.lbl_ValorUnitarioDaUltimaCompraDoInsumo.AutoSize = true;
            this.lbl_ValorUnitarioDaUltimaCompraDoInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ValorUnitarioDaUltimaCompraDoInsumo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ValorUnitarioDaUltimaCompraDoInsumo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_ValorUnitarioDaUltimaCompraDoInsumo.Location = new System.Drawing.Point(517, 57);
            this.lbl_ValorUnitarioDaUltimaCompraDoInsumo.Name = "lbl_ValorUnitarioDaUltimaCompraDoInsumo";
            this.lbl_ValorUnitarioDaUltimaCompraDoInsumo.Size = new System.Drawing.Size(190, 15);
            this.lbl_ValorUnitarioDaUltimaCompraDoInsumo.TabIndex = 9;
            this.lbl_ValorUnitarioDaUltimaCompraDoInsumo.Text = "Valor Unitário da Última Compra:";
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
            this.tls_ControleDeRegistro.Location = new System.Drawing.Point(0, 299);
            this.tls_ControleDeRegistro.Name = "tls_ControleDeRegistro";
            this.tls_ControleDeRegistro.Padding = new System.Windows.Forms.Padding(0);
            this.tls_ControleDeRegistro.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tls_ControleDeRegistro.Size = new System.Drawing.Size(872, 42);
            this.tls_ControleDeRegistro.Stretch = true;
            this.tls_ControleDeRegistro.TabIndex = 10;
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
            // err_ValidaInsumo
            // 
            this.err_ValidaInsumo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_ValidaInsumo.ContainerControl = this;
            this.err_ValidaInsumo.Icon = ((System.Drawing.Icon)(resources.GetObject("err_ValidaInsumo.Icon")));
            // 
            // frm_CadastroDeInsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 341);
            this.Controls.Add(this.grd_Insumos);
            this.Controls.Add(this.grp_InfoInsumo);
            this.Controls.Add(this.tls_ControleDeRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_CadastroDeInsumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Insumos";
            this.Load += new System.EventHandler(this.frm_CadastroDeInsumo_Load);
            this.Shown += new System.EventHandler(this.frm_CadastroDeInsumo_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frm_CadastroDeInsumo_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Insumos)).EndInit();
            this.grp_InfoInsumo.ResumeLayout(false);
            this.grp_InfoInsumo.PerformLayout();
            this.tls_ControleDeRegistro.ResumeLayout(false);
            this.tls_ControleDeRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_ValidaInsumo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grd_Insumos;
        private System.Windows.Forms.GroupBox grp_InfoInsumo;
        private System.Windows.Forms.MaskedTextBox msk_DataHoraDeCadastroDoInsumo;
        private System.Windows.Forms.Label lbl_DataDeCadastro;
        private System.Windows.Forms.TextBox txt_UnidadeDeMedidaDoInsumo;
        private System.Windows.Forms.TextBox txt_NomeDoInsumo;
        private System.Windows.Forms.Label lbl_UnidadeDeMedida;
        private System.Windows.Forms.Label lbl_NomeDoInsumo;
        private System.Windows.Forms.ToolStrip tls_ControleDeRegistro;
        private System.Windows.Forms.ToolStripButton btn_NovoRegistro;
        private System.Windows.Forms.ToolStripButton btn_SalvarRegistro;
        private System.Windows.Forms.ToolStripButton btn_CancelarAlteracao;
        private System.Windows.Forms.ToolStripButton btn_PesquisarRegistro;
        private System.Windows.Forms.ToolStripTextBox txt_Pesquisa;
        private System.Windows.Forms.ToolStripButton btn_ExcluirRegistro;
        private System.Windows.Forms.TextBox txt_ValorUnitarioDaUltimaCompraDoInsumo;
        private System.Windows.Forms.Label lbl_ValorUnitarioDaUltimaCompraDoInsumo;
        private System.Windows.Forms.TextBox txt_CodigoDoInsumo;
        private System.Windows.Forms.Label lbl_CodigoDoInsumo;
        private System.Windows.Forms.ErrorProvider err_ValidaInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDoInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadeDeMedidaDoInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDeCadastroDoInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitarioDaUltimaCompraDoInsumo;
    }
}