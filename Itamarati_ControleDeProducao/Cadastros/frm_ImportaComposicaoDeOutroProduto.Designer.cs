namespace Itamarati_ControleDeProducao.Cadastros
{
    partial class frm_ImportaComposicaoDeOutroProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ImportaComposicaoDeOutroProduto));
            this.lbl_Composição = new System.Windows.Forms.Label();
            this.grd_ComposicaoDoProduto = new System.Windows.Forms.DataGridView();
            this.CodigoDoInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeDoInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnidadeDeMedidaDoInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeDoItemDaComposicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitarioDaUltimaCompraDoInsumo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDoItemDaComposicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_CodigoDoProduto = new System.Windows.Forms.TextBox();
            this.lbl_CodigoDoProduto = new System.Windows.Forms.Label();
            this.txt_DescricaoDoProduto = new System.Windows.Forms.TextBox();
            this.lbl_NomeDoProduto = new System.Windows.Forms.Label();
            this.btn_ImportarComposicao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grd_ComposicaoDoProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Composição
            // 
            this.lbl_Composição.AutoSize = true;
            this.lbl_Composição.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Composição.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Composição.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_Composição.Location = new System.Drawing.Point(17, 47);
            this.lbl_Composição.Name = "lbl_Composição";
            this.lbl_Composição.Size = new System.Drawing.Size(146, 15);
            this.lbl_Composição.TabIndex = 24;
            this.lbl_Composição.Text = "Composição do Produto:";
            // 
            // grd_ComposicaoDoProduto
            // 
            this.grd_ComposicaoDoProduto.AllowUserToAddRows = false;
            this.grd_ComposicaoDoProduto.AllowUserToDeleteRows = false;
            this.grd_ComposicaoDoProduto.AllowUserToResizeColumns = false;
            this.grd_ComposicaoDoProduto.AllowUserToResizeRows = false;
            this.grd_ComposicaoDoProduto.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grd_ComposicaoDoProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grd_ComposicaoDoProduto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_ComposicaoDoProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grd_ComposicaoDoProduto.ColumnHeadersHeight = 28;
            this.grd_ComposicaoDoProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grd_ComposicaoDoProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDoInsumo,
            this.NomeDoInsumo,
            this.UnidadeDeMedidaDoInsumo,
            this.QuantidadeDoItemDaComposicao,
            this.ValorUnitarioDaUltimaCompraDoInsumo,
            this.TotalDoItemDaComposicao});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grd_ComposicaoDoProduto.DefaultCellStyle = dataGridViewCellStyle6;
            this.grd_ComposicaoDoProduto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grd_ComposicaoDoProduto.EnableHeadersVisualStyles = false;
            this.grd_ComposicaoDoProduto.GridColor = System.Drawing.Color.White;
            this.grd_ComposicaoDoProduto.Location = new System.Drawing.Point(16, 65);
            this.grd_ComposicaoDoProduto.MultiSelect = false;
            this.grd_ComposicaoDoProduto.Name = "grd_ComposicaoDoProduto";
            this.grd_ComposicaoDoProduto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_ComposicaoDoProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grd_ComposicaoDoProduto.RowHeadersVisible = false;
            this.grd_ComposicaoDoProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grd_ComposicaoDoProduto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grd_ComposicaoDoProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grd_ComposicaoDoProduto.Size = new System.Drawing.Size(897, 183);
            this.grd_ComposicaoDoProduto.TabIndex = 5;
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
            this.CodigoDoInsumo.MaxInputLength = 6;
            this.CodigoDoInsumo.Name = "CodigoDoInsumo";
            this.CodigoDoInsumo.ReadOnly = true;
            this.CodigoDoInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodigoDoInsumo.Width = 70;
            // 
            // NomeDoInsumo
            // 
            this.NomeDoInsumo.DataPropertyName = "DescricaoDoInsumo";
            this.NomeDoInsumo.HeaderText = "Descrição";
            this.NomeDoInsumo.MaxInputLength = 60;
            this.NomeDoInsumo.Name = "NomeDoInsumo";
            this.NomeDoInsumo.ReadOnly = true;
            this.NomeDoInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NomeDoInsumo.Width = 380;
            // 
            // UnidadeDeMedidaDoInsumo
            // 
            this.UnidadeDeMedidaDoInsumo.DataPropertyName = "UnidadeDeMedidaDoInsumo";
            this.UnidadeDeMedidaDoInsumo.HeaderText = "Unid. de Medida";
            this.UnidadeDeMedidaDoInsumo.MaxInputLength = 4;
            this.UnidadeDeMedidaDoInsumo.Name = "UnidadeDeMedidaDoInsumo";
            this.UnidadeDeMedidaDoInsumo.ReadOnly = true;
            this.UnidadeDeMedidaDoInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UnidadeDeMedidaDoInsumo.Width = 110;
            // 
            // QuantidadeDoItemDaComposicao
            // 
            this.QuantidadeDoItemDaComposicao.DataPropertyName = "QuantidadeUtilizada";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F);
            dataGridViewCellStyle3.Format = "N3";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            this.QuantidadeDoItemDaComposicao.DefaultCellStyle = dataGridViewCellStyle3;
            this.QuantidadeDoItemDaComposicao.HeaderText = "       Quantidade";
            this.QuantidadeDoItemDaComposicao.MaxInputLength = 20;
            this.QuantidadeDoItemDaComposicao.Name = "QuantidadeDoItemDaComposicao";
            this.QuantidadeDoItemDaComposicao.ReadOnly = true;
            this.QuantidadeDoItemDaComposicao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.QuantidadeDoItemDaComposicao.Width = 90;
            // 
            // ValorUnitarioDaUltimaCompraDoInsumo
            // 
            this.ValorUnitarioDaUltimaCompraDoInsumo.DataPropertyName = "ValorUnitarioDaUltimaCompraDoInsumo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C3";
            dataGridViewCellStyle4.NullValue = null;
            this.ValorUnitarioDaUltimaCompraDoInsumo.DefaultCellStyle = dataGridViewCellStyle4;
            this.ValorUnitarioDaUltimaCompraDoInsumo.HeaderText = "       Valor Unitário";
            this.ValorUnitarioDaUltimaCompraDoInsumo.MaxInputLength = 20;
            this.ValorUnitarioDaUltimaCompraDoInsumo.Name = "ValorUnitarioDaUltimaCompraDoInsumo";
            this.ValorUnitarioDaUltimaCompraDoInsumo.ReadOnly = true;
            this.ValorUnitarioDaUltimaCompraDoInsumo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TotalDoItemDaComposicao
            // 
            this.TotalDoItemDaComposicao.DataPropertyName = "TotalDoItem";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "C3";
            dataGridViewCellStyle5.NullValue = null;
            this.TotalDoItemDaComposicao.DefaultCellStyle = dataGridViewCellStyle5;
            this.TotalDoItemDaComposicao.HeaderText = "                           Total";
            this.TotalDoItemDaComposicao.MaxInputLength = 20;
            this.TotalDoItemDaComposicao.Name = "TotalDoItemDaComposicao";
            this.TotalDoItemDaComposicao.ReadOnly = true;
            this.TotalDoItemDaComposicao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalDoItemDaComposicao.Width = 120;
            // 
            // txt_CodigoDoProduto
            // 
            this.txt_CodigoDoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CodigoDoProduto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_CodigoDoProduto.Enabled = false;
            this.txt_CodigoDoProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CodigoDoProduto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_CodigoDoProduto.Location = new System.Drawing.Point(73, 16);
            this.txt_CodigoDoProduto.MaxLength = 4;
            this.txt_CodigoDoProduto.Name = "txt_CodigoDoProduto";
            this.txt_CodigoDoProduto.Size = new System.Drawing.Size(65, 22);
            this.txt_CodigoDoProduto.TabIndex = 1;
            this.txt_CodigoDoProduto.Tag = "Login";
            // 
            // lbl_CodigoDoProduto
            // 
            this.lbl_CodigoDoProduto.AutoSize = true;
            this.lbl_CodigoDoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_CodigoDoProduto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CodigoDoProduto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_CodigoDoProduto.Location = new System.Drawing.Point(18, 19);
            this.lbl_CodigoDoProduto.Name = "lbl_CodigoDoProduto";
            this.lbl_CodigoDoProduto.Size = new System.Drawing.Size(49, 15);
            this.lbl_CodigoDoProduto.TabIndex = 0;
            this.lbl_CodigoDoProduto.Text = "Código:";
            // 
            // txt_DescricaoDoProduto
            // 
            this.txt_DescricaoDoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DescricaoDoProduto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescricaoDoProduto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_DescricaoDoProduto.Location = new System.Drawing.Point(229, 16);
            this.txt_DescricaoDoProduto.MaxLength = 60;
            this.txt_DescricaoDoProduto.Name = "txt_DescricaoDoProduto";
            this.txt_DescricaoDoProduto.Size = new System.Drawing.Size(444, 22);
            this.txt_DescricaoDoProduto.TabIndex = 3;
            this.txt_DescricaoDoProduto.Tag = "Nome do Produto";
            this.txt_DescricaoDoProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_DescricaoDoProduto_KeyDown);
            this.txt_DescricaoDoProduto.Validating += new System.ComponentModel.CancelEventHandler(this.txt_DescricaoDoProduto_Validating);
            // 
            // lbl_NomeDoProduto
            // 
            this.lbl_NomeDoProduto.AutoSize = true;
            this.lbl_NomeDoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_NomeDoProduto.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeDoProduto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NomeDoProduto.Location = new System.Drawing.Point(155, 19);
            this.lbl_NomeDoProduto.Name = "lbl_NomeDoProduto";
            this.lbl_NomeDoProduto.Size = new System.Drawing.Size(68, 15);
            this.lbl_NomeDoProduto.TabIndex = 2;
            this.lbl_NomeDoProduto.Text = "Descrição:";
            // 
            // btn_ImportarComposicao
            // 
            this.btn_ImportarComposicao.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ImportarComposicao.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_ImportarComposicao.FlatAppearance.BorderSize = 2;
            this.btn_ImportarComposicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImportarComposicao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportarComposicao.ForeColor = System.Drawing.Color.White;
            this.btn_ImportarComposicao.Image = global::Itamarati_ControleDeProducao.Properties.Resources._1461896514_circle_arrow_down_download_glyph;
            this.btn_ImportarComposicao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImportarComposicao.Location = new System.Drawing.Point(739, 12);
            this.btn_ImportarComposicao.Name = "btn_ImportarComposicao";
            this.btn_ImportarComposicao.Size = new System.Drawing.Size(174, 28);
            this.btn_ImportarComposicao.TabIndex = 4;
            this.btn_ImportarComposicao.Text = "Importar Composição";
            this.btn_ImportarComposicao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ImportarComposicao.UseVisualStyleBackColor = false;
            this.btn_ImportarComposicao.Click += new System.EventHandler(this.btn_ImportaComposicao_Click);
            // 
            // frm_ImportaComposicaoDeOutroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(929, 262);
            this.Controls.Add(this.btn_ImportarComposicao);
            this.Controls.Add(this.lbl_Composição);
            this.Controls.Add(this.grd_ComposicaoDoProduto);
            this.Controls.Add(this.txt_CodigoDoProduto);
            this.Controls.Add(this.lbl_CodigoDoProduto);
            this.Controls.Add(this.txt_DescricaoDoProduto);
            this.Controls.Add(this.lbl_NomeDoProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ImportaComposicaoDeOutroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importar Composição";
            this.Load += new System.EventHandler(this.frm_ImportaComposicaoDeOutroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grd_ComposicaoDoProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Composição;
        private System.Windows.Forms.DataGridView grd_ComposicaoDoProduto;
        private System.Windows.Forms.TextBox txt_CodigoDoProduto;
        private System.Windows.Forms.Label lbl_CodigoDoProduto;
        private System.Windows.Forms.TextBox txt_DescricaoDoProduto;
        private System.Windows.Forms.Label lbl_NomeDoProduto;
        private System.Windows.Forms.Button btn_ImportarComposicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDoInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnidadeDeMedidaDoInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeDoItemDaComposicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitarioDaUltimaCompraDoInsumo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDoItemDaComposicao;
    }
}