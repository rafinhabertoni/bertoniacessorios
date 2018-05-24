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
    public partial class frmListaFornecedor : Form
    {
        public frmListaFornecedor()
        {
            InitializeComponent();
            dgFornecedor.AutoGenerateColumns = false;
        }

        private void frmListaFornecedor_Load(object sender, EventArgs e)
        {
            this.cmbStatus.SelectedIndex = 0;
            FornecedorBE fornecedorBE = new FornecedorBE();
            fornecedorBE.Ativo = true;
            Pesquisar(fornecedorBE);
        }

        public void Pesquisar(FornecedorBE fornecedorBE)
        {
            FornecedorBO fornecedorBO = new FornecedorBO();
            dgFornecedor.DataSource = fornecedorBO.Listar(fornecedorBE);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FornecedorBE fornecedorBE = PreencherDados();

            Pesquisar(fornecedorBE);
        }

        /// <summary>
        /// Recupera os dados dos campos
        /// </summary>
        /// <returns></returns>
        public FornecedorBE PreencherDados()
        {
            FornecedorBE fornecedorBE = new FornecedorBE();
            fornecedorBE.Nome = this.txtNome.Text;
            fornecedorBE.Descricao = this.txtDescricao.Text;
            fornecedorBE.Codigo = this.txtCodigo.Text;
            if (this.cmbStatus.SelectedIndex >= 0)
            {
                if (this.cmbStatus.SelectedItem.ToString() == "Ativo")
                {
                    fornecedorBE.Ativo = true;
                }
            }
            return fornecedorBE;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmFornecedor frmFornecedor = new frmFornecedor(null);
            frmFornecedor.Show();
            this.Hide();
        }

        private void dgFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (Convert.ToBoolean(dgFornecedor[8, e.RowIndex].Value) == false)
                {
                    MessageBox.Show("Não é permitido realizar esta ação. Este item está inativo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (senderGrid.Columns[e.ColumnIndex].Name == "Editar")
                {
                    frmFornecedor frmFornecedor = new frmFornecedor((int)dgFornecedor[3, e.RowIndex].Value);
                    frmFornecedor.Show();
                    this.Hide();
                }
                if (senderGrid.Columns[e.ColumnIndex].Name == "Excluir")
                {
                    DialogResult dr = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        FornecedorBO fornecedorBO = new FornecedorBO();
                        fornecedorBO.Excluir((int)dgFornecedor[3, e.RowIndex].Value);

                        MessageBox.Show("Fornecedor excluído com sucesso.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FornecedorBE fornecedorBE = PreencherDados();
                        Pesquisar(fornecedorBE);
                    }
                }
            }
        }
    }
}
