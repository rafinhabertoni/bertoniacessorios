using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BertoniAcessorios.BO;
using BertoniAcessorios.BE;

namespace BertoniAcessorios
{
    public partial class frmOutrasDespesas : Form
    {
        public int? id;

        public frmOutrasDespesas(int? idDespesa)
        {
            InitializeComponent();

            this.CarregarComboTipoDespesa();
            if (idDespesa != null)
            {
                id = idDespesa;
                this.CarregarDados();
            }
        }

        public void CarregarDados()
        {
            DespesaBO despesaBO = new DespesaBO();
            DespesaBE despesaBE = despesaBO.Consultar(id.Value, null, null);

            this.cmbTipoDespesa.SelectedIndex = this.cmbTipoDespesa.FindString(despesaBE.NomeTipoDespesa);
            this.txtValorDespesa.Text = despesaBE.ValorDespesa.ToString();
            this.txtDataDespesa.Text = despesaBE.DataDespesa.Value.ToString("dd/MM/yyyy");
        }

        public void CarregarComboTipoDespesa()
        {
            TipoDespesaBO tipoDespesaBO = new TipoDespesaBO();
            TipoDespesaBE tipoDespesaBE = new TipoDespesaBE();
            tipoDespesaBE.Ativo = true;
            List<TipoDespesaBE> listaTipoDespesaBE = tipoDespesaBO.Listar(tipoDespesaBE);

            listaTipoDespesaBE = listaTipoDespesaBE.OrderBy(o => o.Nome).ToList();

            cmbTipoDespesa.Items.Add("Selecione");
            foreach (TipoDespesaBE retornoTipoDespesaBE in listaTipoDespesaBE)
            {
                cmbTipoDespesa.Items.Add(retornoTipoDespesaBE);
            }
            cmbTipoDespesa.DisplayMember = "Nome";
            cmbTipoDespesa.ValueMember = "Id";
            cmbTipoDespesa.SelectedIndex = 0;
        }

        /// <summary>
        /// Método responsável por validar os campos
        /// </summary>
        /// <returns></returns>
        public bool Validar()
        {
            if (this.cmbTipoDespesa.SelectedIndex == 0)
            {
                MessageBox.Show("O campo Tipo de Despesa é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Convert.ToDecimal(this.txtValorDespesa.Text) <= 0)
            {
                MessageBox.Show("O campo Valor da Despesa deve ser maior que zero.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Convert.ToDecimal(this.txtValorDespesa.Text) < 0)
            {
                MessageBox.Show("O campo Valor da Despesa deve ser maior ou igual a zero.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(this.txtDataDespesa.Text))
            {
                MessageBox.Show("O campo Data da Despesa é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Recupera os dados dos campos
        /// </summary>
        /// <returns></returns>
        public DespesaBE PreencherDados()
        {
            DespesaBE despesaBE = new DespesaBE();
            despesaBE.IdTipoDespesa = Convert.ToInt32(((BertoniAcessorios.BE.TipoDespesaBE)this.cmbTipoDespesa.SelectedItem).Id);
            despesaBE.ValorDespesa = Convert.ToDecimal(this.txtValorDespesa.Text);
            despesaBE.DataDespesa = Convert.ToDateTime(this.txtDataDespesa.Text);
            despesaBE.Id = this.id;
            return despesaBE;
        }

        /// <summary>
        /// Método responsável por salvar
        /// </summary>
        public void Salvar(DespesaBE despesaBE)
        {
            DespesaBO despesaBO = new DespesaBO();
            despesaBO.Salvar(despesaBE);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                DespesaBE despesaBE = this.PreencherDados();
                this.Salvar(despesaBE);
                MessageBox.Show("Despesa salva com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmListaOutrasDespesas frmListaOutrasDespesas = new frmListaOutrasDespesas();
                frmListaOutrasDespesas.Show();
            }
        }

        private void txtValorDespesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.SomenteNumeros(sender, e);
        }

        public void SomenteNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDataDespesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }
    }
}
