namespace BertoniAcessorios
{
    partial class frmListaProduto
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
            this.lblListaFornecedor = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.blTipoProduto = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgProduto = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipoproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idfornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoproduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomefornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorcompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorvenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtinclusao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtalteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnNovo = new System.Windows.Forms.Button();
            this.cmbTipoProduto = new System.Windows.Forms.ComboBox();
            this.cmbFornecedor = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaFornecedor
            // 
            this.lblListaFornecedor.AutoSize = true;
            this.lblListaFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaFornecedor.ForeColor = System.Drawing.Color.Red;
            this.lblListaFornecedor.Location = new System.Drawing.Point(21, 11);
            this.lblListaFornecedor.Name = "lblListaFornecedor";
            this.lblListaFornecedor.Size = new System.Drawing.Size(225, 31);
            this.lblListaFornecedor.TabIndex = 23;
            this.lblListaFornecedor.Text = "Lista de Produtos";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(239, 222);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 22;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // blTipoProduto
            // 
            this.blTipoProduto.AutoSize = true;
            this.blTipoProduto.Location = new System.Drawing.Point(24, 143);
            this.blTipoProduto.Name = "blTipoProduto";
            this.blTipoProduto.Size = new System.Drawing.Size(68, 13);
            this.blTipoProduto.TabIndex = 20;
            this.blTipoProduto.Text = "Tipo Produto";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Location = new System.Drawing.Point(24, 103);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(61, 13);
            this.lblFornecedor.TabIndex = 18;
            this.lblFornecedor.Text = "Fornecedor";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 60);
            this.txtNome.MaxLength = 200;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(262, 20);
            this.txtNome.TabIndex = 17;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(24, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Nome";
            // 
            // dgProduto
            // 
            this.dgProduto.AllowUserToAddRows = false;
            this.dgProduto.AllowUserToDeleteRows = false;
            this.dgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.idtipoproduto,
            this.idfornecedor,
            this.tipoproduto,
            this.nomefornecedor,
            this.valorcompra,
            this.valorvenda,
            this.datacompra,
            this.id,
            this.dtinclusao,
            this.dtalteracao,
            this.ativo,
            this.Editar,
            this.Excluir});
            this.dgProduto.Location = new System.Drawing.Point(27, 264);
            this.dgProduto.Name = "dgProduto";
            this.dgProduto.ReadOnly = true;
            this.dgProduto.Size = new System.Drawing.Size(884, 330);
            this.dgProduto.TabIndex = 15;
            this.dgProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProduto_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 70;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 170;
            // 
            // idtipoproduto
            // 
            this.idtipoproduto.DataPropertyName = "idtipoproduto";
            this.idtipoproduto.HeaderText = "idtipoproduto";
            this.idtipoproduto.Name = "idtipoproduto";
            this.idtipoproduto.ReadOnly = true;
            this.idtipoproduto.Visible = false;
            // 
            // idfornecedor
            // 
            this.idfornecedor.DataPropertyName = "idfornecedor";
            this.idfornecedor.HeaderText = "idfornecedor";
            this.idfornecedor.Name = "idfornecedor";
            this.idfornecedor.ReadOnly = true;
            this.idfornecedor.Visible = false;
            // 
            // tipoproduto
            // 
            this.tipoproduto.DataPropertyName = "tipoproduto";
            this.tipoproduto.HeaderText = "tipoproduto";
            this.tipoproduto.Name = "tipoproduto";
            this.tipoproduto.ReadOnly = true;
            // 
            // nomefornecedor
            // 
            this.nomefornecedor.DataPropertyName = "nomefornecedor";
            this.nomefornecedor.HeaderText = "nomefornecedor";
            this.nomefornecedor.Name = "nomefornecedor";
            this.nomefornecedor.ReadOnly = true;
            this.nomefornecedor.Width = 130;
            // 
            // valorcompra
            // 
            this.valorcompra.DataPropertyName = "valorcompra";
            this.valorcompra.HeaderText = "valorcompra";
            this.valorcompra.Name = "valorcompra";
            this.valorcompra.ReadOnly = true;
            this.valorcompra.Width = 80;
            // 
            // valorvenda
            // 
            this.valorvenda.DataPropertyName = "valorvenda";
            this.valorvenda.HeaderText = "valorvenda";
            this.valorvenda.Name = "valorvenda";
            this.valorvenda.ReadOnly = true;
            this.valorvenda.Width = 80;
            // 
            // datacompra
            // 
            this.datacompra.DataPropertyName = "datacompra";
            this.datacompra.HeaderText = "datacompra";
            this.datacompra.Name = "datacompra";
            this.datacompra.ReadOnly = true;
            this.datacompra.Width = 70;
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
            // dtinclusao
            // 
            this.dtinclusao.DataPropertyName = "datainclusao";
            this.dtinclusao.HeaderText = "dtinclusao";
            this.dtinclusao.Name = "dtinclusao";
            this.dtinclusao.ReadOnly = true;
            this.dtinclusao.Visible = false;
            // 
            // dtalteracao
            // 
            this.dtalteracao.DataPropertyName = "dataalteracao";
            this.dtalteracao.HeaderText = "dtalteracao";
            this.dtalteracao.Name = "dtalteracao";
            this.dtalteracao.ReadOnly = true;
            this.dtalteracao.Visible = false;
            // 
            // ativo
            // 
            this.ativo.DataPropertyName = "ativo";
            this.ativo.HeaderText = "ativo";
            this.ativo.Name = "ativo";
            this.ativo.ReadOnly = true;
            this.ativo.Visible = false;
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
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(836, 610);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 24;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // cmbTipoProduto
            // 
            this.cmbTipoProduto.FormattingEnabled = true;
            this.cmbTipoProduto.Location = new System.Drawing.Point(100, 140);
            this.cmbTipoProduto.Name = "cmbTipoProduto";
            this.cmbTipoProduto.Size = new System.Drawing.Size(171, 21);
            this.cmbTipoProduto.TabIndex = 25;
            // 
            // cmbFornecedor
            // 
            this.cmbFornecedor.FormattingEnabled = true;
            this.cmbFornecedor.Location = new System.Drawing.Point(100, 100);
            this.cmbFornecedor.Name = "cmbFornecedor";
            this.cmbFornecedor.Size = new System.Drawing.Size(171, 21);
            this.cmbFornecedor.TabIndex = 26;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(24, 186);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 27;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(100, 179);
            this.txtCodigo.MaxLength = 200;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(171, 20);
            this.txtCodigo.TabIndex = 28;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cmbStatus.Location = new System.Drawing.Point(100, 222);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(99, 21);
            this.cmbStatus.TabIndex = 30;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(24, 225);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "Status";
            // 
            // frmListaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 645);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.cmbFornecedor);
            this.Controls.Add(this.cmbTipoProduto);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.lblListaFornecedor);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.blTipoProduto);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgProduto);
            this.Name = "frmListaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Produtos";
            this.Load += new System.EventHandler(this.frmListaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaFornecedor;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label blTipoProduto;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgProduto;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ComboBox cmbTipoProduto;
        private System.Windows.Forms.ComboBox cmbFornecedor;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipoproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoproduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomefornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorcompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorvenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtinclusao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtalteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}