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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pRVENDARELATORIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rdlVenda = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bertoniAcessoriosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bertoniAcessoriosDataSet = new BertoniAcessorios.BertoniAcessoriosDataSet();
            this.pR_VENDA_RELATORIOTableAdapter = new BertoniAcessorios.BertoniAcessoriosDataSetTableAdapters.PR_VENDA_RELATORIOTableAdapter();
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
            // rdlVenda
            // 
            reportDataSource1.Name = "dsVenda";
            reportDataSource1.Value = this.pRVENDARELATORIOBindingSource;
            this.rdlVenda.LocalReport.DataSources.Add(reportDataSource1);
            this.rdlVenda.LocalReport.ReportEmbeddedResource = "BertoniAcessorios.rptVendas.rdlc";
            this.rdlVenda.Location = new System.Drawing.Point(12, 12);
            this.rdlVenda.Name = "rdlVenda";
            this.rdlVenda.ServerReport.BearerToken = null;
            this.rdlVenda.Size = new System.Drawing.Size(1217, 643);
            this.rdlVenda.TabIndex = 0;
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
            // pR_VENDA_RELATORIOTableAdapter
            // 
            this.pR_VENDA_RELATORIOTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 696);
            this.Controls.Add(this.rdlVenda);
            this.Name = "frmRelatorioVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRelatorioVenda";
            this.Load += new System.EventHandler(this.frmRelatorioVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRVENDARELATORIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bertoniAcessoriosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bertoniAcessoriosDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rdlVenda;
        private System.Windows.Forms.BindingSource bertoniAcessoriosDataSetBindingSource;
        private BertoniAcessoriosDataSet bertoniAcessoriosDataSet;
        private System.Windows.Forms.BindingSource pRVENDARELATORIOBindingSource;
        private BertoniAcessoriosDataSetTableAdapters.PR_VENDA_RELATORIOTableAdapter pR_VENDA_RELATORIOTableAdapter;
    }
}