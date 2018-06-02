namespace BertoniAcessorios
{
    partial class frmRelatorioVenda
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pRVENDARELATORIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bertoniAcessoriosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bertoniAcessoriosDataSet = new BertoniAcessorios.BertoniAcessoriosDataSet();
            this.rdlVenda = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pR_VENDA_RELATORIOTableAdapter = new BertoniAcessorios.BertoniAcessoriosDataSetTableAdapters.PR_VENDA_RELATORIOTableAdapter();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbTipoRelatorio = new System.Windows.Forms.ComboBox();
            this.lblTipoRelatorio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pRVENDARELATORIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bertoniAcessoriosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bertoniAcessoriosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pRVENDARELATORIOBindingSource
            // 
            this.pRVENDARELATORIOBindingSource.DataMember = "PR_VENDA_RELATORIO";
            this.pRVENDARELATORIOBindingSource.DataSource = this.bertoniAcessoriosDataSetBindingSource;
            // 
            // bertoniAcessoriosDataSetBindingSource
            // 
            this.bertoniAcessoriosDataSetBindingSource.DataSource = this.bertoniAcessoriosDataSet;
            this.bertoniAcessoriosDataSetBindingSource.Position = 0;
            // 
            // bertoniAcessoriosDataSet
            // 
            this.bertoniAcessoriosDataSet.DataSetName = "BertoniAcessoriosDataSet";
            this.bertoniAcessoriosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rdlVenda
            // 
            reportDataSource3.Name = "dsVenda";
            reportDataSource3.Value = this.pRVENDARELATORIOBindingSource;
            this.rdlVenda.LocalReport.DataSources.Add(reportDataSource3);
            this.rdlVenda.LocalReport.ReportEmbeddedResource = "BertoniAcessorios.rptVendas.rdlc";
            this.rdlVenda.Location = new System.Drawing.Point(12, 182);
            this.rdlVenda.Name = "rdlVenda";
            this.rdlVenda.ServerReport.BearerToken = null;
            this.rdlVenda.Size = new System.Drawing.Size(1217, 473);
            this.rdlVenda.TabIndex = 0;
            // 
            // pR_VENDA_RELATORIOTableAdapter
            // 
            this.pR_VENDA_RELATORIOTableAdapter.ClearBeforeFill = true;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(102, 67);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(214, 21);
            this.cmbFornecedor.TabIndex = 53;
            this.cmbFornecedor.SelectedIndexChanged += new System.EventHandler(this.cmbFornecedor_SelectedIndexChanged);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(21, 70);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 52;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(102, 26);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(214, 21);
            this.cmbVendedor.TabIndex = 51;
            // 
            // cmbProduto
            // 
            this.cmbProduto.Enabled = false;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(102, 109);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(214, 21);
            this.cmbProduto.TabIndex = 50;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(21, 112);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 49;
            this.lblProduto.Text = "Produto";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(21, 29);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 48;
            this.lblVendedor.Text = "Vendedor";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(269, 153);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 54;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cmbTipoRelatorio
            // 
            this.cmbTipoRelatorio.FormattingEnabled = true;
            this.cmbTipoRelatorio.Items.AddRange(new object[] {
            "Geral",
            "Anual",
            "Mensal"});
            this.cmbTipoRelatorio.Location = new System.Drawing.Point(102, 153);
            this.cmbTipoRelatorio.Name = "cmbTipoRelatorio";
            this.cmbTipoRelatorio.Size = new System.Drawing.Size(131, 21);
            this.cmbTipoRelatorio.TabIndex = 56;
            // 
            // lblTipoRelatorio
            // 
            this.lblTipoRelatorio.AutoSize = true;
            this.lblTipoRelatorio.Location = new System.Drawing.Point(21, 156);
            this.lblTipoRelatorio.Name = "lblTipoRelatorio";
            this.lblTipoRelatorio.Size = new System.Drawing.Size(73, 13);
            this.lblTipoRelatorio.TabIndex = 55;
            this.lblTipoRelatorio.Text = "Tipo Relatório";
            // 
            // frmRelatorioVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 696);
            this.Controls.Add(this.cmbTipoRelatorio);
            this.Controls.Add(this.lblTipoRelatorio);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.rdlVenda);
            this.Name = "frmRelatorioVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioVenda";
            this.Load += new System.EventHandler(this.frmRelatorioVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRVENDARELATORIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bertoniAcessoriosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bertoniAcessoriosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rdlVenda;
        private System.Windows.Forms.BindingSource bertoniAcessoriosDataSetBindingSource;
        private BertoniAcessoriosDataSet bertoniAcessoriosDataSet;
        private System.Windows.Forms.BindingSource pRVENDARELATORIOBindingSource;
        private BertoniAcessoriosDataSetTableAdapters.PR_VENDA_RELATORIOTableAdapter pR_VENDA_RELATORIOTableAdapter;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cmbTipoRelatorio;
        private System.Windows.Forms.Label lblTipoRelatorio;
    }
}