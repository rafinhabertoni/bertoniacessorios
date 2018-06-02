using System;
using System.Collections;
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
    public partial class frmListaProduto : Form
    {
        public class Status
        {
            public string valor;
            public string nome;
        }

        public frmListaProduto()
        {
            InitializeComponent();
            dgProduto.AutoGenerateColumns = false;
        }

        private void frmListaProduto_Load(object sender, EventArgs e)
        {
            this.cmbStatus.SelectedIndex = 0;
            this.CarregarComboTipoProduto();
            this.CarregarComboFornecedor();
            ProdutoBE produtoBE = new ProdutoBE();
            produtoBE.Ativo = true;
            Pesquisar(produtoBE);
        }

        public void CarregarComboTipoProduto()
        {
            TipoProdutoBO tipoProdutoBO = new TipoProdutoBO();
            List<TipoProdutoBE> listaTipoProdutoBE = tipoProdutoBO.Listar(new TipoProdutoBE());

            cmbTipoProduto.Items.Add("Selecione");
            foreach (TipoProdutoBE tipoProdutoBE in listaTipoProdutoBE)
            {
                cmbTipoProduto.Items.Add(tipoProdutoBE);
            }
            cmbTipoProduto.DisplayMember = "Nome";
            cmbTipoProduto.ValueMember = "Id";
            cmbTipoProduto.SelectedIndex = 0;
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

        public void Pesquisar(ProdutoBE produtoBE)
        {
            ProdutoBO produtoBO = new ProdutoBO();
            dgProduto.DataSource = produtoBO.Listar(produtoBE);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ProdutoBE produtoBE = PreencherDados();

            Pesquisar(produtoBE);
        }

        /// <summary>
        /// Recupera os dados dos campos
        /// </summary>
        /// <returns></returns>
        public ProdutoBE PreencherDados()
        {
            ProdutoBE produtoBE = new ProdutoBE();
            produtoBE.Nome = this.txtNome.Text;
            produtoBE.Codigo = this.txtCodigo.Text;
            if (this.cmbTipoProduto.SelectedIndex != 0)
            {
                produtoBE.IdTipoProduto = Convert.ToInt32(((BertoniAcessorios.BE.TipoProdutoBE)this.cmbTipoProduto.SelectedItem).Id);
            }
            if (this.cmbFornecedor.SelectedIndex != 0)
            {
                produtoBE.IdFornecedor = Convert.ToInt32(((BertoniAcessorios.BE.FornecedorBE)this.cmbFornecedor.SelectedItem).Id);
            }
            if (this.cmbStatus.SelectedIndex >= 0)
            {
                if(this.cmbStatus.SelectedItem.ToString() == "Ativo")
                {
                    produtoBE.Ativo = true;
                }
            }
            return produtoBE;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmProduto frmProduto = new frmProduto(null);
            frmProduto.Show();
            this.Hide();
        }

        private void dgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                if (Convert.ToBoolean(dgProduto[12, e.RowIndex].Value) == false)
                {
                    MessageBox.Show("Não é permitido realizar esta ação. Este item está inativo.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (senderGrid.Columns[e.ColumnIndex].Name == "Editar")
                {
                    frmProduto frmProduto = new frmProduto((int)dgProduto[9, e.RowIndex].Value);
                    frmProduto.Show();
                    this.Hide();
                }
                if (senderGrid.Columns[e.ColumnIndex].Name == "Excluir")
                {
                    DialogResult dr = MessageBox.Show("Deseja realmente excluir?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (dr == DialogResult.Yes)
                    {
                        ProdutoBO produtoBO = new ProdutoBO();
                        produtoBO.Excluir((int)dgProduto[9, e.RowIndex].Value);

                        MessageBox.Show("Produto excluído com sucesso.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ProdutoBE produtoBE = PreencherDados();
                        Pesquisar(produtoBE);
                    }
                }
            }
        }
    }
}
