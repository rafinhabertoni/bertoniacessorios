namespace BertoniAcessorios
{
    partial class frmListaVenda
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
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtDataVenda = new System.Windows.Forms.TextBox();
            this.lblDataVenda = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.lblListaVenda = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgVenda = new System.Windows.Forms.DataGridView();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.nomevendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorcomissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idvendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataalteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cmbStatus.Location = new System.Drawing.Point(96, 224);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(99, 21);
            this.cmbStatus.TabIndex = 43;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(15, 227);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 42;
            this.lblStatus.Text = "Status";
            // 
            // txtDataVenda
            // 
            this.txtDataVenda.Location = new System.Drawing.Point(96, 181);
            this.txtDataVenda.MaxLength = 10;
            this.txtDataVenda.Name = "txtDataVenda";
            this.txtDataVenda.Size = new System.Drawing.Size(99, 20);
            this.txtDataVenda.TabIndex = 41;
            this.txtDataVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataVenda_KeyPress);
            // 
            // lblDataVenda
            // 
            this.lblDataVenda.AutoSize = true;
            this.lblDataVenda.Location = new System.Drawing.Point(15, 188);
            this.lblDataVenda.Name = "lblDataVenda";
            this.lblDataVenda.Size = new System.Drawing.Size(78, 13);
            this.lblDataVenda.TabIndex = 40;
            this.lblDataVenda.Text = "Data da venda";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(96, 59);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(214, 21);
            this.cmbVendedor.TabIndex = 39;
            // 
            // cmbProduto
            // 
            this.cmbProduto.Enabled = false;
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(96, 142);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(214, 21);
            this.cmbProduto.TabIndex = 38;
            // 
            // lblListaVenda
            // 
            this.lblListaVenda.AutoSize = true;
            this.lblListaVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaVenda.ForeColor = System.Drawing.Color.Red;
            this.lblListaVenda.Location = new System.Drawing.Point(12, 9);
            this.lblListaVenda.Name = "lblListaVenda";
            this.lblListaVenda.Size = new System.Drawing.Size(208, 31);
            this.lblListaVenda.TabIndex = 37;
            this.lblListaVenda.Text = "Lista de Vendas";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(235, 224);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 36;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(15, 145);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(44, 13);
            this.lblProduto.TabIndex = 35;
            this.lblProduto.Text = "Produto";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(15, 62);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 34;
            this.lblVendedor.Text = "Vendedor";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(928, 646);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 44;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgVenda
            // 
            this.dgVenda.AllowUserToAddRows = false;
            this.dgVenda.AllowUserToDeleteRows = false;
            this.dgVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomevendedor,
            this.nomefornecedor,
            this.nomeproduto,
            this.valorvenda,
            this.valorcomissao,
            this.datavenda,
            this.id,
            this.idvendedor,
            this.idproduto,
            this.ativo,
            this.dataalteracao,
            this.Editar,
            this.Excluir});
            this.dgVenda.Location = new System.Drawing.Point(18, 293);
            this.dgVenda.Name = "dgVenda";
            this.dgVenda.ReadOnly = true;
            this.dgVenda.Size = new System.Drawing.Size(985, 335);
            this.dgVenda.TabIndex = 45;
            this.dgVenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVenda_CellContentClick);
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(96, 100);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(214, 21);
            this.cmbFornecedor.TabIndex = 47;
            this.cmbFornecedor.SelectedIndexChanged += new System.EventHandler(this.cmbFornecedor_SelectedIndexChanged);
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(15, 103);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 46;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // nomevendedor
            // 
            this.nomevendedor.DataPropertyName = "nomevendedor";
            this.nomevendedor.HeaderText = "nomevendedor";
            this.nomevendedor.Name = "nomevendedor";
            this.nomevendedor.ReadOnly = true;
            this.nomevendedor.Width = 150;
            // 
            // nomefornecedor
            // 
            this.nomefornecedor.DataPropertyName = "nomefornecedor";
            this.nomefornecedor.HeaderText = "nomefornecedor";
            this.nomefornecedor.Name = "nomefornecedor";
            this.nomefornecedor.ReadOnly = true;
            this.nomefornecedor.Width = 150;
            // 
            // nomeproduto
            // 
            this.nomeproduto.DataPropertyName = "codigonomeproduto";
            this.nomeproduto.HeaderText = "nomeproduto";
            this.nomeproduto.Name = "nomeproduto";
            this.nomeproduto.ReadOnly = true;
            this.nomeproduto.Width = 200;
            // 
            // valorvenda
            // 
            this.valorvenda.DataPropertyName = "valorvenda";
            this.valorvenda.HeaderText = "valorvenda";
            this.valorvenda.Name = "valorvenda";
            this.valorvenda.ReadOnly = true;
            // 
            // valorcomissao
            // 
            this.valorcomissao.DataPropertyName = "valorcomissao";
            this.valorcomissao.HeaderText = "valorcomissao";
            this.valorcomissao.Name = "valorcomissao";
            this.valorcomissao.ReadOnly = true;
            // 
            // datavenda
            // 
            this.datavenda.DataPropertyName = "datavenda";
            this.datavenda.HeaderText = "datavenda";
            this.datavenda.Name = "datavenda";
            this.datavenda.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 50;
            // 
            // idvendedor
            // 
            this.idvendedor.DataPropertyName = "idvendedor";
            this.idvendedor.HeaderText = "idvendedor";
            this.idvendedor.Name = "idvendedor";
            this.idvendedor.ReadOnly = true;
            this.idvendedor.Visible = false;
            // 
            // idproduto
            // 
            this.idproduto.DataPropertyName = "idproduto";
            this.idproduto.HeaderText = "idproduto";
            this.idproduto.Name = "idproduto";
            this.idproduto.ReadOnly = true;
            this.idproduto.Visible = false;
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            this.ativo.HeaderText = "ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            this.ativo.Visible = false;
            // 
            // dataalteracao
            // 
            this.dataalteracao.DataPropertyName = "dataalteracao";
            this.dataalteracao.HeaderText = "dataalteracao";
            this.dataalteracao.Name = "dataalteracao";
            this.dataalteracao.ReadOnly = true;
            this.dataalteracao.Visible = false;
            // 
            // Editar
            // 
            this.Editar.DataPropertyName = "Editar";
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 70;
            // 
            // Excluir
            // 
            this.Excluir.DataPropertyName = "Excluir";
            this.Excluir.HeaderText = "";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseColumnTextForButtonValue = true;
            this.Excluir.Width = 70;
            // 
            // frmListaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 681);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.dgVenda);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtDataVenda);
            this.Controls.Add(this.lblDataVenda);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.cmbProduto);
            this.Controls.Add(this.lblListaVenda);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblVendedor);
            this.Name = "frmListaVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaVenda";
            this.Load += new System.EventHandler(this.frmListaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDataVenda;
        private System.Windows.Forms.Label lblDataVenda;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Label lblListaVenda;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgVenda;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomevendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorvenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorcomissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idvendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataalteracao;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}