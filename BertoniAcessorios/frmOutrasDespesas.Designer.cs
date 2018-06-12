namespace BertoniAcessorios
{
    partial class frmOutrasDespesas
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
            this.lblTipoDespesa = new System.Windows.Forms.Label();
            this.cmbTipoDespesa = new System.Windows.Forms.ComboBox();
            this.txtDataDespesa = new System.Windows.Forms.TextBox();
            this.lblDataDespesa = new System.Windows.Forms.Label();
            this.txtValorDespesa = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblDespesa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTipoDespesa
            // 
            this.lblTipoDespesa.AutoSize = true;
            this.lblTipoDespesa.Location = new System.Drawing.Point(26, 88);
            this.lblTipoDespesa.Name = "lblTipoDespesa";
            this.lblTipoDespesa.Size = new System.Drawing.Size(88, 13);
            this.lblTipoDespesa.TabIndex = 0;
            this.lblTipoDespesa.Text = "Tipo de Despesa";
            // 
            // cmbTipoDespesa
            // 
            this.cmbTipoDespesa.FormattingEnabled = true;
            this.cmbTipoDespesa.Location = new System.Drawing.Point(131, 80);
            this.cmbTipoDespesa.Name = "cmbTipoDespesa";
            this.cmbTipoDespesa.Size = new System.Drawing.Size(180, 21);
            this.cmbTipoDespesa.TabIndex = 1;
            // 
            // txtDataDespesa
            // 
            this.txtDataDespesa.Location = new System.Drawing.Point(131, 160);
            this.txtDataDespesa.MaxLength = 10;
            this.txtDataDespesa.Name = "txtDataDespesa";
            this.txtDataDespesa.Size = new System.Drawing.Size(100, 20);
            this.txtDataDespesa.TabIndex = 26;
            this.txtDataDespesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataDespesa_KeyPress);
            // 
            // lblDataDespesa
            // 
            this.lblDataDespesa.AutoSize = true;
            this.lblDataDespesa.Location = new System.Drawing.Point(29, 163);
            this.lblDataDespesa.Name = "lblDataDespesa";
            this.lblDataDespesa.Size = new System.Drawing.Size(90, 13);
            this.lblDataDespesa.TabIndex = 25;
            this.lblDataDespesa.Text = "Data da Despesa";
            // 
            // txtValorDespesa
            // 
            this.txtValorDespesa.Location = new System.Drawing.Point(131, 122);
            this.txtValorDespesa.MaxLength = 16;
            this.txtValorDespesa.Name = "txtValorDespesa";
            this.txtValorDespesa.Size = new System.Drawing.Size(100, 20);
            this.txtValorDespesa.TabIndex = 24;
            this.txtValorDespesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDespesa_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(29, 125);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(91, 13);
            this.lblValor.TabIndex = 23;
            this.lblValor.Text = "Valor da Despesa";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(32, 213);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblDespesa
            // 
            this.lblDespesa.AutoSize = true;
            this.lblDespesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDespesa.ForeColor = System.Drawing.Color.Red;
            this.lblDespesa.Location = new System.Drawing.Point(23, 21);
            this.lblDespesa.Name = "lblDespesa";
            this.lblDespesa.Size = new System.Drawing.Size(277, 31);
            this.lblDespesa.TabIndex = 33;
            this.lblDespesa.Text = "Cadastro de Despesa";
            // 
            // frmOutrasDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 282);
            this.Controls.Add(this.lblDespesa);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDataDespesa);
            this.Controls.Add(this.lblDataDespesa);
            this.Controls.Add(this.txtValorDespesa);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.cmbTipoDespesa);
            this.Controls.Add(this.lblTipoDespesa);
            this.Name = "frmOutrasDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOutrasDespesas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoDespesa;
        private System.Windows.Forms.ComboBox cmbTipoDespesa;
        private System.Windows.Forms.TextBox txtDataDespesa;
        private System.Windows.Forms.Label lblDataDespesa;
        private System.Windows.Forms.TextBox txtValorDespesa;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblDespesa;
    }
}