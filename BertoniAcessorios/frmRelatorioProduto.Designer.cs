namespace BertoniAcessorios
{
    partial class frmRelatorioProduto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pRPRODUTORELATORIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bertoniAcessoriosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bertoniAcessoriosDataSet = new BertoniAcessorios.BertoniAcessoriosDataSet();
            this.pRVENDARELATORIOGRAFICOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rdlProduto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.cmbAno = new System.Windows.Forms.ComboBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.cmbVendido = new System.Windows.Forms.ComboBox();
            this.lblVendido = new System.Windows.Forms.Label();
            this.pR_PRODUTO_RELATORIOTableAdapter = new BertoniAcessorios.BertoniAcessoriosDataSetTableAdapters.PR_PRODUTO_RELATORIOTableAdapter();
            this.pR_VENDA_RELATORIO_GRAFICOTableAdapter = new BertoniAcessorios.BertoniAcessoriosDataSetTableAdapters.PR_VENDA_RELATORIO_GRAFICOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pRPRODUTORELATORIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bertoniAcessoriosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bertoniAcessoriosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRVENDARELATORIOGRAFICOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pRPRODUTORELATORIOBindingSource
            // 
            this.pRPRODUTORELATORIOBindingSource.DataMember = "PR_PRODUTO_RELATORIO";
            this.pRPRODUTORELATORIOBindingSource.DataSource = this.bertoniAcessoriosDataSetBindingSource;
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
            // pRVENDARELATORIOGRAFICOBindingSource
            // 
            this.pRVENDARELATORIOGRAFICOBindingSource.DataMember = "PR_VENDA_RELATORIO_GRAFICO";
            this.pRVENDARELATORIOGRAFICOBindingSource.DataSource = this.bertoniAcessoriosDataSetBindingSource;
            // 
            // rdlProduto
            // 
            reportDataSource1.Name = "dsProduto";
            reportDataSource1.Value = this.pRPRODUTORELATORIOBindingSource;
            this.rdlProduto.LocalReport.DataSources.Add(reportDataSource1);
            this.rdlProduto.LocalReport.ReportEmbeddedResource = "BertoniAcessorios.rptProdutos.rdlc";
            this.rdlProduto.Location = new System.Drawing.Point(12, 151);
            this.rdlProduto.Name = "rdlProduto";
            this.rdlProduto.ServerReport.BearerToken = null;
            this.rdlProduto.Size = new System.Drawing.Size(1217, 504);
            this.rdlProduto.TabIndex = 0;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(104, 26);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(214, 21);
            this.cmbFornecedor.TabIndex = 53;
            this.cmbFornecedor.SelectedIndexChanged += new System.EventHandler(this.cmbFornecedor_SelectedIndexChanged);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(23, 29);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 52;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // cmbProduto
            // 
            this.cmbProduto.Enabled = false;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(104, 68);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(214, 21);
            this.cmbProduto.TabIndex = 50;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(23, 71);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 49;
            this.lblProduto.Text = "Produto";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(282, 107);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 54;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Selecione",
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cmbMes.Location = new System.Drawing.Point(507, 26);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(131, 21);
            this.cmbMes.TabIndex = 58;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(426, 29);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(27, 13);
            this.lblMes.TabIndex = 57;
            this.lblMes.Text = "Mês";
            // 
            // cmbAno
            // 
            this.cmbAno.FormattingEnabled = true;
            this.cmbAno.Items.AddRange(new object[] {
            "Selecione",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.cmbAno.Location = new System.Drawing.Point(507, 66);
            this.cmbAno.Name = "cmbAno";
            this.cmbAno.Size = new System.Drawing.Size(131, 21);
            this.cmbAno.TabIndex = 60;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(426, 69);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 59;
            this.lblAno.Text = "Ano";
            // 
            // cmbVendido
            // 
            this.cmbVendido.FormattingEnabled = true;
            this.cmbVendido.Items.AddRange(new object[] {
            "Selecione",
            "Sim",
            "Não"});
            this.cmbVendido.Location = new System.Drawing.Point(104, 107);
            this.cmbVendido.Name = "cmbVendido";
            this.cmbVendido.Size = new System.Drawing.Size(131, 21);
            this.cmbVendido.TabIndex = 62;
            // 
            // lblVendido
            // 
            this.lblVendido.AutoSize = true;
            this.lblVendido.Location = new System.Drawing.Point(23, 110);
            this.lblVendido.Name = "lblVendido";
            this.lblVendido.Size = new System.Drawing.Size(46, 13);
            this.lblVendido.TabIndex = 61;
            this.lblVendido.Text = "Vendido";
            // 
            // pR_PRODUTO_RELATORIOTableAdapter
            // 
            this.pR_PRODUTO_RELATORIOTableAdapter.ClearBeforeFill = true;
            // 
            // pR_VENDA_RELATORIO_GRAFICOTableAdapter
            // 
            this.pR_VENDA_RELATORIO_GRAFICOTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 675);
            this.Controls.Add(this.cmbVendido);
            this.Controls.Add(this.lblVendido);
            this.Controls.Add(this.cmbAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.rdlProduto);
            this.Name = "frmRelatorioProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioProduto";
            this.Load += new System.EventHandler(this.frmRelatorioProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRPRODUTORELATORIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bertoniAcessoriosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bertoniAcessoriosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRVENDARELATORIOGRAFICOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rdlProduto;
        private System.Windows.Forms.BindingSource bertoniAcessoriosDataSetBindingSource;
        private BertoniAcessoriosDataSet bertoniAcessoriosDataSet;
        private System.Windows.Forms.BindingSource pRPRODUTORELATORIOBindingSource;
        private BertoniAcessoriosDataSetTableAdapters.PR_PRODUTO_RELATORIOTableAdapter pR_PRODUTO_RELATORIOTableAdapter;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cmbAno;
        private System.Windows.Forms.Label lblAno;
        private BertoniAcessoriosDataSetTableAdapters.PR_VENDA_RELATORIO_GRAFICOTableAdapter pR_VENDA_RELATORIO_GRAFICOTableAdapter;
        private System.Windows.Forms.BindingSource pRVENDARELATORIOGRAFICOBindingSource;
        private System.Windows.Forms.ComboBox cmbVendido;
        private System.Windows.Forms.Label lblVendido;
    }
}