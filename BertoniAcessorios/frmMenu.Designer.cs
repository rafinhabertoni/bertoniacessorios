namespace BertoniAcessorios
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblVendas = new System.Windows.Forms.Label();
            this.lblOutrasDespesas = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVendas = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRelatorioVendas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.Location = new System.Drawing.Point(34, 27);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(91, 20);
            this.lblFornecedor.TabIndex = 3;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(168, 27);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(65, 20);
            this.lblProduto.TabIndex = 5;
            this.lblProduto.Text = "Produto";
            // 
            // lblVendas
            // 
            this.lblVendas.AutoSize = true;
            this.lblVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendas.Location = new System.Drawing.Point(284, 27);
            this.lblVendas.Name = "lblVendas";
            this.lblVendas.Size = new System.Drawing.Size(64, 20);
            this.lblVendas.TabIndex = 7;
            this.lblVendas.Text = "Vendas";
            // 
            // lblOutrasDespesas
            // 
            this.lblOutrasDespesas.AutoSize = true;
            this.lblOutrasDespesas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutrasDespesas.Location = new System.Drawing.Point(380, 27);
            this.lblOutrasDespesas.Name = "lblOutrasDespesas";
            this.lblOutrasDespesas.Size = new System.Drawing.Size(133, 20);
            this.lblOutrasDespesas.TabIndex = 9;
            this.lblOutrasDespesas.Text = "Outras Despesas";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BertoniAcessorios.Properties.Resources.outras_despesas;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(393, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 83);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnVendas
            // 
            this.btnVendas.BackgroundImage = global::BertoniAcessorios.Properties.Resources.vendas;
            this.btnVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVendas.Location = new System.Drawing.Point(269, 46);
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(96, 83);
            this.btnVendas.TabIndex = 6;
            this.btnVendas.UseVisualStyleBackColor = true;
            this.btnVendas.Click += new System.EventHandler(this.btnVendas_Click);
            // 
            // btnProduto
            // 
            this.btnProduto.BackgroundImage = global::BertoniAcessorios.Properties.Resources.produto;
            this.btnProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduto.Location = new System.Drawing.Point(153, 46);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(96, 83);
            this.btnProduto.TabIndex = 4;
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.BackgroundImage = global::BertoniAcessorios.Properties.Resources.loja2;
            this.btnFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFornecedor.Location = new System.Drawing.Point(34, 46);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(96, 83);
            this.btnFornecedor.TabIndex = 2;
            this.btnFornecedor.UseVisualStyleBackColor = true;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Relatório de Vendas";
            // 
            // btnRelatorioVendas
            // 
            this.btnRelatorioVendas.BackgroundImage = global::BertoniAcessorios.Properties.Resources.RelatorioVendas;
            this.btnRelatorioVendas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRelatorioVendas.Location = new System.Drawing.Point(34, 174);
            this.btnRelatorioVendas.Name = "btnRelatorioVendas";
            this.btnRelatorioVendas.Size = new System.Drawing.Size(96, 83);
            this.btnRelatorioVendas.TabIndex = 10;
            this.btnRelatorioVendas.UseVisualStyleBackColor = true;
            this.btnRelatorioVendas.Click += new System.EventHandler(this.btnRelatorioVendas_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRelatorioVendas);
            this.Controls.Add(this.lblOutrasDespesas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblVendas);
            this.Controls.Add(this.btnVendas);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.btnFornecedor);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Label lblVendas;
        private System.Windows.Forms.Button btnVendas;
        private System.Windows.Forms.Label lblOutrasDespesas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRelatorioVendas;
    }
}

