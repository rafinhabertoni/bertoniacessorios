namespace BertoniAcessorios
{
    partial class frmListaOutrasDespesas
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
            this.dgDespesa = new System.Windows.Forms.DataGridView();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtDataDespesa = new System.Windows.Forms.TextBox();
            this.lblDataDespesa = new System.Windows.Forms.Label();
            this.cmbTipoDespesa = new System.Windows.Forms.ComboBox();
            this.lblListaDespesa = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblTipoDespesa = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.nometipodespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datadespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipodespesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgDespesa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDespesa
            // 
            this.dgDespesa.AllowUserToAddRows = false;
            this.dgDespesa.AllowUserToDeleteRows = false;
            this.dgDespesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDespesa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nometipodespesa,
            this.valordespesa,
            this.datadespesa,
            this.id,
            this.idtipodespesa,
            this.ativo,
            this.Editar,
            this.Excluir});
            this.dgDespesa.Location = new System.Drawing.Point(21, 183);
            this.dgDespesa.Name = "dgDespesa";
            this.dgDespesa.ReadOnly = true;
            this.dgDespesa.Size = new System.Drawing.Size(534, 335);
            this.dgDespesa.TabIndex = 58;
            this.dgDespesa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDespesa_CellContentClick);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cmbStatus.Location = new System.Drawing.Point(112, 141);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(99, 21);
            this.cmbStatus.TabIndex = 57;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(18, 144);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 56;
            this.lblStatus.Text = "Status";
            // 
            // txtDataDespesa
            // 
            this.txtDataDespesa.Location = new System.Drawing.Point(112, 98);
            this.txtDataDespesa.MaxLength = 10;
            this.txtDataDespesa.Name = "txtDataDespesa";
            this.txtDataDespesa.Size = new System.Drawing.Size(99, 20);
            this.txtDataDespesa.TabIndex = 55;
            this.txtDataDespesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataDespesa_KeyPress);
            // 
            // lblDataDespesa
            // 
            this.lblDataDespesa.AutoSize = true;
            this.lblDataDespesa.Location = new System.Drawing.Point(18, 105);
            this.lblDataDespesa.Name = "lblDataDespesa";
            this.lblDataDespesa.Size = new System.Drawing.Size(88, 13);
            this.lblDataDespesa.TabIndex = 54;
            this.lblDataDespesa.Text = "Data da despesa";
            // 
            // cmbTipoDespesa
            // 
            this.cmbTipoDespesa.FormattingEnabled = true;
            this.cmbTipoDespesa.Location = new System.Drawing.Point(112, 57);
            this.cmbTipoDespesa.Name = "cmbTipoDespesa";
            this.cmbTipoDespesa.Size = new System.Drawing.Size(214, 21);
            this.cmbTipoDespesa.TabIndex = 53;
            // 
            // lblListaDespesa
            // 
            this.lblListaDespesa.AutoSize = true;
            this.lblListaDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDespesa.ForeColor = System.Drawing.Color.Red;
            this.lblListaDespesa.Location = new System.Drawing.Point(15, 7);
            this.lblListaDespesa.Name = "lblListaDespesa";
            this.lblListaDespesa.Size = new System.Drawing.Size(238, 31);
            this.lblListaDespesa.TabIndex = 51;
            this.lblListaDespesa.Text = "Lista de Despesas";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(251, 141);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 50;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // lblTipoDespesa
            // 
            this.lblTipoDespesa.AutoSize = true;
            this.lblTipoDespesa.Location = new System.Drawing.Point(18, 60);
            this.lblTipoDespesa.Name = "lblTipoDespesa";
            this.lblTipoDespesa.Size = new System.Drawing.Size(88, 13);
            this.lblTipoDespesa.TabIndex = 48;
            this.lblTipoDespesa.Text = "Tipo de Despesa";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(480, 537);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 59;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // nometipodespesa
            // 
            this.nometipodespesa.DataPropertyName = "nometipodespesa";
            this.nometipodespesa.HeaderText = "nometipodespesa";
            this.nometipodespesa.Name = "nometipodespesa";
            this.nometipodespesa.ReadOnly = true;
            this.nometipodespesa.Width = 150;
            // 
            // valordespesa
            // 
            this.valordespesa.DataPropertyName = "valordespesa";
            this.valordespesa.HeaderText = "valordespesa";
            this.valordespesa.Name = "valordespesa";
            this.valordespesa.ReadOnly = true;
            // 
            // datadespesa
            // 
            this.datadespesa.DataPropertyName = "datadespesa";
            this.datadespesa.HeaderText = "datadespesa";
            this.datadespesa.Name = "datadespesa";
            this.datadespesa.ReadOnly = true;
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
            // idtipodespesa
            // 
            this.idtipodespesa.DataPropertyName = "idtipodespesa";
            this.idtipodespesa.HeaderText = "idtipodespesa";
            this.idtipodespesa.Name = "idtipodespesa";
            this.idtipodespesa.ReadOnly = true;
            this.idtipodespesa.Visible = false;
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
            // frmListaOutrasDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 572);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgDespesa);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtDataDespesa);
            this.Controls.Add(this.lblDataDespesa);
            this.Controls.Add(this.cmbTipoDespesa);
            this.Controls.Add(this.lblListaDespesa);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblTipoDespesa);
            this.Name = "frmListaOutrasDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListaOutrasDespesas";
            this.Load += new System.EventHandler(this.frmListaOutrasDespesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDespesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgDespesa;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtDataDespesa;
        private System.Windows.Forms.Label lblDataDespesa;
        private System.Windows.Forms.ComboBox cmbTipoDespesa;
        private System.Windows.Forms.Label lblListaDespesa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblTipoDespesa;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nometipodespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn datadespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipodespesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ativo;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}