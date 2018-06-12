using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BertoniAcessorios.BE;
using BertoniAcessorios.BO;

namespace BertoniAcessorios
{
    public partial class frmListaOutrasDespesas : Form
    {
        public frmListaOutrasDespesas()
        {
            InitializeComponent();
            dgDespesa.AutoGenerateColumns = false;
        }

        private void frmListaOutrasDespesas_Load(object sender, EventArgs e)
        {
            this.cmbStatus.SelectedIndex = 0;
            this.CarregarComboTipoDespesa();
            DespesaBE despesaBE = new DespesaBE();
            despesaBE.Ativo = true;
            Pesquisar(despesaBE);
        }

        public void CarregarComboTipoDespesa()
        {
            TipoDespesaBO tipoDespesaBO = new TipoDespesaBO();
            TipoDespesaBE tipoDespesaBE = new TipoDespesaBE();
            tipoDespesaBE.Ativo = true;
            List<TipoDespesaBE> listaTipoDespesaBE = tipoDespesaBO.Listar(tipoDespesaBE);

            cmbTipoDespesa.Items.Add("Selecione");
            foreach (TipoDespesaBE retornoTipoDespesaBE in listaTipoDespesaBE)
            {
                cmbTipoDespesa.Items.Add(retornoTipoDespesaBE);
            }
            cmbTipoDespesa.DisplayMember = "Nome";
            cmbTipoDespesa.ValueMember = "Id";
            cmbTipoDespesa.SelectedIndex = 0;
        }

        public void Pesquisar(DespesaBE despesaBE)
        {
            DespesaBO despesaBO = new DespesaBO();
            dgDespesa.DataSource = despesaBO.Listar(despesaBE);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            DespesaBE despesaBE = PreencherDados();

            Pesquisar(despesaBE);
        }

        /// <summary>
        /// Recupera os dados dos campos
        /// </summary>
        /// <returns></returns>
        public DespesaBE PreencherDados()
        {
            DespesaBE despesaBE = new DespesaBE();
            if (this.cmbTipoDespesa.SelectedIndex != 0)
            {
                despesaBE.IdTipoDespesa = Convert.ToInt32(((BertoniAcessorios.BE.TipoDespesaBE)this.cmbTipoDespesa.SelectedItem).Id);
            }
            if (this.cmbStatus.SelectedIndex >= 0)
            {
                if (this.cmbStatus.SelectedItem.ToString() == "Ativo")
                {
                    despesaBE.Ativo = true;
                }
            }
            if (!String.IsNullOrEmpty(this.txtDataDespesa.Text))
            {
                despesaBE.DataDespesa = Convert.ToDateTime(this.txtDataDespesa.Text);
            }
            return despesaBE;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmOutrasDespesas frmOutrasDespesas = new frmOutrasDespesas(null);
            frmOutrasDespesas.Show();
            this.Hide();
        }

        private void dgDespesa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (Convert.ToBoolean(dgDespesa[5, e.RowIndex].Value) == false)
                {
                    MessageBox.Show("Não é permitido realizar esta ação. Este item está inativo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (senderGrid.Columns[e.ColumnIndex].Name == "Editar")
                {
                    frmOutrasDespesas frmOutrasDespesas = new frmOutrasDespesas((int)dgDespesa[3, e.RowIndex].Value);
                    frmOutrasDespesas.Show();
                    this.Hide();
                }
                if (senderGrid.Columns[e.ColumnIndex].Name == "Excluir")
                {
                    DialogResult dr = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        DespesaBO despesaBO = new DespesaBO();
                        despesaBO.Excluir((int)dgDespesa[3, e.RowIndex].Value);

                        MessageBox.Show("Despesa excluída com sucesso.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DespesaBE despesaBE = PreencherDados();
                        Pesquisar(despesaBE);
                    }
                }
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
