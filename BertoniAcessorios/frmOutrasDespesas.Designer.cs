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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtDataCompra = new System.Windows.Forms.TextBox();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTipoDespesa
            // 
            this.lblTipoDespesa.AutoSize = true;
            this.lblTipoDespesa.Location = new System.Drawing.Point(27, 60);
            this.lblTipoDespesa.Name = "lblTipoDespesa";
            this.lblTipoDespesa.Size = new System.Drawing.Size(88, 13);
            this.lblTipoDespesa.TabIndex = 0;
            this.lblTipoDespesa.Text = "Tipo de Despesa";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // txtDataCompra
            // 
            this.txtDataCompra.Location = new System.Drawing.Point(132, 132);
            this.txtDataCompra.MaxLength = 10;
            this.txtDataCompra.Name = "txtDataCompra";
            this.txtDataCompra.Size = new System.Drawing.Size(100, 20);
            this.txtDataCompra.TabIndex = 26;
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Location = new System.Drawing.Point(30, 135);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(84, 13);
            this.lblDataCompra.TabIndex = 25;
            this.lblDataCompra.Text = "Data da Compra";
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(132, 94);
            this.txtValorCompra.MaxLength = 16;
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(100, 20);
            this.txtValorCompra.TabIndex = 24;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(30, 97);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(85, 13);
            this.lblValor.TabIndex = 23;
            this.lblValor.Text = "Valor de Compra";
            // 
            // frmOutrasDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDataCompra);
            this.Controls.Add(this.lblDataCompra);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTipoDespesa);
            this.Name = "frmOutrasDespesas";
            this.Text = "frmOutrasDespesas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoDespesa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtDataCompra;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label lblValor;
    }
}