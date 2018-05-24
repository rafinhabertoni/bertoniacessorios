namespace BertoniAcessorios
{
    partial class frmVenda
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
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.lvlValorVenda = new System.Windows.Forms.Label();
            this.txtValorComissao = new System.Windows.Forms.TextBox();
            this.lblValorComissao = new System.Windows.Forms.Label();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblVenda = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(141, 63);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(148, 21);
            this.cmbVendedor.TabIndex = 39;
            this.cmbVendedor.SelectedIndexChanged += new System.EventHandler(this.cmbVendedor_SelectedIndexChanged);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Enabled = false;
            this.txtValorVenda.Location = new System.Drawing.Point(141, 179);
            this.txtValorVenda.MaxLength = 16;
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(100, 20);
            this.txtValorVenda.TabIndex = 36;
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            // 
            // lvlValorVenda
            // 
            this.lvlValorVenda.AutoSize = true;
            this.lvlValorVenda.Location = new System.Drawing.Point(38, 182);
            this.lvlValorVenda.Name = "lvlValorVenda";
            this.lvlValorVenda.Size = new System.Drawing.Size(80, 13);
            this.lvlValorVenda.TabIndex = 35;
            this.lvlValorVenda.Text = "Valor de Venda";
            // 
            // txtValorComissao
            // 
            this.txtValorComissao.Enabled = false;
            this.txtValorComissao.Location = new System.Drawing.Point(141, 217);
            this.txtValorComissao.MaxLength = 16;
            this.txtValorComissao.Name = "txtValorComissao";
            this.txtValorComissao.Size = new System.Drawing.Size(100, 20);
            this.txtValorComissao.TabIndex = 34;
            // 
            // lblValorComissao
            // 
            this.lblValorComissao.AutoSize = true;
            this.lblValorComissao.Location = new System.Drawing.Point(38, 220);
            this.lblValorComissao.Name = "lblValorComissao";
            this.lblValorComissao.Size = new System.Drawing.Size(94, 13);
            this.lblValorComissao.TabIndex = 33;
            this.lblValorComissao.Text = "Valor de Comissão";
            // 
            // cmbProduto
            // 
            this.cmbProduto.Enabled = false;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(141, 136);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(247, 21);
            this.cmbProduto.TabIndex = 32;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(41, 260);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenda.ForeColor = System.Drawing.Color.Red;
            this.lblVenda.Location = new System.Drawing.Point(30, 9);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(247, 31);
            this.lblVenda.TabIndex = 30;
            this.lblVenda.Text = "Cadastro de Venda";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(38, 142);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 29;
            this.lblProduto.Text = "Produto";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(39, 66);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 28;
            this.lblVendedor.Text = "Vendedor";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.Enabled = false;
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(141, 100);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(148, 21);
            this.cmbFornecedor.TabIndex = 41;
            this.cmbFornecedor.SelectedIndexChanged += new System.EventHandler(this.cmbFornecedor_SelectedIndexChanged);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(39, 103);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 40;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 330);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.lvlValorVenda);
            this.Controls.Add(this.txtValorComissao);
            this.Controls.Add(this.lblValorComissao);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblVenda);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblVendedor);
            this.Name = "frmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmVenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label lvlValorVenda;
        private System.Windows.Forms.TextBox txtValorComissao;
        private System.Windows.Forms.Label lblValorComissao;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblVenda;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
    }
}