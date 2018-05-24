namespace BertoniAcessorios
{
    partial class frmProduto
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblCadastroProduto = new System.Windows.Forms.Label();
            this.lblTipoProduto = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.cmbTipoProduto = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.lvlValorVenda = new System.Windows.Forms.Label();
            this.txtDataCompra = new System.Windows.Forms.TextBox();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(21, 319);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblCadastroProduto
            // 
            this.lblCadastroProduto.AutoSize = true;
            this.lblCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroProduto.ForeColor = System.Drawing.Color.Red;
            this.lblCadastroProduto.Location = new System.Drawing.Point(21, 18);
            this.lblCadastroProduto.Name = "lblCadastroProduto";
            this.lblCadastroProduto.Size = new System.Drawing.Size(264, 31);
            this.lblCadastroProduto.TabIndex = 14;
            this.lblCadastroProduto.Text = "Cadastro de Produto";
            // 
            // lblTipoProduto
            // 
            this.lblTipoProduto.AutoSize = true;
            this.lblTipoProduto.Location = new System.Drawing.Point(18, 165);
            this.lblTipoProduto.Name = "lblTipoProduto";
            this.lblTipoProduto.Size = new System.Drawing.Size(68, 13);
            this.lblTipoProduto.TabIndex = 12;
            this.lblTipoProduto.Text = "Tipo Produto";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(19, 123);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 10;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(109, 82);
            this.txtNome.MaxLength = 200;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(416, 20);
            this.txtNome.TabIndex = 9;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 89);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            // 
            // cmbTipoProduto
            // 
            this.cmbTipoProduto.FormattingEnabled = true;
            this.cmbTipoProduto.Location = new System.Drawing.Point(109, 159);
            this.cmbTipoProduto.Name = "cmbTipoProduto";
            this.cmbTipoProduto.Size = new System.Drawing.Size(148, 21);
            this.cmbTipoProduto.TabIndex = 16;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(18, 201);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(85, 13);
            this.lblValor.TabIndex = 17;
            this.lblValor.Text = "Valor de Compra";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(109, 198);
            this.txtValorCompra.MaxLength = 16;
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(100, 20);
            this.txtValorCompra.TabIndex = 18;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(334, 202);
            this.txtValorVenda.MaxLength = 16;
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(100, 20);
            this.txtValorVenda.TabIndex = 20;
            // 
            // lvlValorVenda
            // 
            this.lvlValorVenda.AutoSize = true;
            this.lvlValorVenda.Location = new System.Drawing.Point(243, 205);
            this.lvlValorVenda.Name = "lvlValorVenda";
            this.lvlValorVenda.Size = new System.Drawing.Size(80, 13);
            this.lvlValorVenda.TabIndex = 19;
            this.lvlValorVenda.Text = "Valor de Venda";
            // 
            // txtDataCompra
            // 
            this.txtDataCompra.Location = new System.Drawing.Point(109, 236);
            this.txtDataCompra.MaxLength = 10;
            this.txtDataCompra.Name = "txtDataCompra";
            this.txtDataCompra.Size = new System.Drawing.Size(100, 20);
            this.txtDataCompra.TabIndex = 22;
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Location = new System.Drawing.Point(18, 239);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(84, 13);
            this.lblDataCompra.TabIndex = 21;
            this.lblDataCompra.Text = "Data da Compra";
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(109, 120);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(148, 21);
            this.cmbFornecedor.TabIndex = 23;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(109, 272);
            this.txtCodigo.MaxLength = 9;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 25;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(18, 275);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 24;
            this.lblCodigo.Text = "Código";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 357);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.txtDataCompra);
            this.Controls.Add(this.lblDataCompra);
            this.Controls.Add(this.txtValorVenda);
            this.Controls.Add(this.lvlValorVenda);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.cmbTipoProduto);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblCadastroProduto);
            this.Controls.Add(this.lblTipoProduto);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblCadastroProduto;
        private System.Windows.Forms.Label lblTipoProduto;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cmbTipoProduto;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.Label lvlValorVenda;
        private System.Windows.Forms.TextBox txtDataCompra;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
    }
}