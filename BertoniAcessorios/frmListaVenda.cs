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
    public partial class frmListaVenda : Form
    {
        public frmListaVenda()
        {
            InitializeComponent();
            dgVenda.AutoGenerateColumns = false;
        }

        private void frmListaVenda_Load(object sender, EventArgs e)
        {
            this.cmbStatus.SelectedIndex = 0;
            this.CarregarComboFornecedor();
            this.CarregarComboVendendor();
            VendaBE vendaBE = new VendaBE();
            vendaBE.Ativo = true;
            Pesquisar(vendaBE);
        }

        public void CarregarComboFornecedor()
        {
            FornecedorBO fornecedorBO = new FornecedorBO();
            FornecedorBE fornecedorBE = new FornecedorBE();
            fornecedorBE.Ativo = true;
            List<FornecedorBE> listaFornecedorBE = fornecedorBO.Listar(fornecedorBE);

            cmbFornecedor.Items.Add("Selecione");
            foreach (FornecedorBE retornoFornecedorBE in listaFornecedorBE)
            {
                cmbFornecedor.Items.Add(retornoFornecedorBE);
            }
            cmbFornecedor.DisplayMember = "Nome";
            cmbFornecedor.ValueMember = "Id";
            cmbFornecedor.SelectedIndex = 0;
        }

        public void CarregarComboProduto(int idfornecedor)
        {
            ProdutoBO produtoBO = new ProdutoBO();
            ProdutoBE produtoBE = new ProdutoBE();
            produtoBE.Ativo = true;
            produtoBE.IdFornecedor = idfornecedor;
            List<ProdutoBE> listaTipoProdutoBE = produtoBO.Listar(produtoBE);

            cmbProduto.Items.Clear();
            cmbProduto.Items.Add("Selecione");
            foreach (ProdutoBE produtoRetornoBE in listaTipoProdutoBE)
            {
                cmbProduto.Items.Add(produtoRetornoBE);
            }
            cmbProduto.DisplayMember = "CodigoNome";
            cmbProduto.ValueMember = "Id";
            cmbProduto.SelectedIndex = 0;
        }

        public void CarregarComboVendendor()
        {
            VendedorBO vendedorBO = new VendedorBO();
            VendedorBE vendedorBE = new VendedorBE();
            vendedorBE.Ativo = true;
            List<VendedorBE> listaVendedorBE = vendedorBO.Listar(vendedorBE);

            cmbVendedor.Items.Add("Selecione");
            foreach (VendedorBE vendedorRetornoBE in listaVendedorBE)
            {
                cmbVendedor.Items.Add(vendedorRetornoBE);
            }
            cmbVendedor.DisplayMember = "Nome";
            cmbVendedor.ValueMember = "Id";
            cmbVendedor.SelectedIndex = 0;
        }

        public void Pesquisar(VendaBE vendaBE)
        {
            VendaBO vendaBO = new VendaBO();
            dgVenda.DataSource = vendaBO.Listar(vendaBE);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            VendaBE vendaBE = PreencherDados();

            Pesquisar(vendaBE);
        }

        /// <summary>
        /// Recupera os dados dos campos
        /// </summary>
        /// <returns></returns>
        public VendaBE PreencherDados()
        {
            VendaBE vendaBE = new VendaBE();
            if (this.cmbProduto.SelectedIndex != 0)
            {
                vendaBE.IdProduto = Convert.ToInt32(((BertoniAcessorios.BE.ProdutoBE)this.cmbProduto.SelectedItem).Id);
            }
            if (this.cmbVendedor.SelectedIndex != 0)
            {
                vendaBE.IdVendedor = Convert.ToInt32(((BertoniAcessorios.BE.VendedorBE)this.cmbVendedor.SelectedItem).Id);
            }
            if (this.cmbFornecedor.SelectedIndex != 0)
            {
                vendaBE.IdFornecedor = Convert.ToInt32(((BertoniAcessorios.BE.FornecedorBE)this.cmbFornecedor.SelectedItem).Id);
            }
            if (this.cmbStatus.SelectedIndex >= 0)
            {
                if (this.cmbStatus.SelectedItem.ToString() == "Ativo")
                {
                    vendaBE.Ativo = true;
                }
            }
            if (!String.IsNullOrEmpty(this.txtDataVenda.Text))
            {
                vendaBE.DataInclusao = Convert.ToDateTime(this.txtDataVenda.Text);
            }
            return vendaBE;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmVenda frmVenda = new frmVenda(null);
            frmVenda.Show();
            this.Hide();
        }

        private void dgVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if(Convert.ToBoolean(dgVenda[9, e.RowIndex].Value) == false)
                {
                    MessageBox.Show("Não é permitido realizar esta ação. Este item está inativo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; 
                }
                if (senderGrid.Columns[e.ColumnIndex].Name == "Editar")
                {
                    frmVenda frmVenda = new frmVenda((int)dgVenda[6, e.RowIndex].Value);
                    frmVenda.Show();
                    this.Hide();
                }
                if (senderGrid.Columns[e.ColumnIndex].Name == "Excluir")
                {
                    DialogResult dr = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        VendaBO vendaBO = new VendaBO();
                        vendaBO.Excluir((int)dgVenda[6, e.RowIndex].Value);

                        MessageBox.Show("Venda excluída com sucesso.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        VendaBE vendaBE = PreencherDados();
                        Pesquisar(vendaBE);
                    }
                }
            }
        }

        private void txtDataVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '/'))
            {
                e.Handled = true;
            }
        }

        private void cmbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idFornecedor = 0;
            if (cmbFornecedor.SelectedIndex > 0)
            {
                idFornecedor = Convert.ToInt32(((BertoniAcessorios.BE.FornecedorBE)this.cmbFornecedor.SelectedItem).Id);
                this.cmbProduto.Enabled = true;
            }
            else
            {
                this.cmbProduto.Enabled = false;
            }
            this.CarregarComboProduto(idFornecedor);
        }
    }
}
