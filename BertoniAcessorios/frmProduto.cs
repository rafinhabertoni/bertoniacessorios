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
    public partial class frmProduto : Form
    {
        public int? id;

        public frmProduto(int? idProduto)
        {
            InitializeComponent();

            this.CarregarComboTipoProduto();
            this.CarregarComboFornecedor();
            if (idProduto != null)
            {
                id = idProduto;
                this.CarregarDados(idProduto);
            }
        }

        public void CarregarDados(int? idProduto)
        {
            ProdutoBO produtoBO = new ProdutoBO();
            ProdutoBE produtoBE = produtoBO.Consultar(id.Value, null, null);

            this.txtNome.Text = produtoBE.Nome;
            this.txtCodigo.Text = produtoBE.Codigo;
            this.txtValorCompra.Text = produtoBE.ValorCompra.ToString();
            this.txtValorVenda.Text = produtoBE.ValorVenda.ToString();
            this.txtDataCompra.Text = produtoBE.DataCompra.Value.ToString("dd/MM/yyyy");
            this.cmbTipoProduto.SelectedIndex = this.cmbTipoProduto.FindString(produtoBE.TipoProduto);
            this.cmbFornecedor.SelectedIndex = this.cmbFornecedor.FindString(produtoBE.CodigoNomeFornecedor);
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
            cmbFornecedor.DisplayMember = "CodigoNome";
            cmbFornecedor.ValueMember = "Id";
            cmbFornecedor.SelectedIndex = 0;
        }

        /// <summary>
        /// Método responsável por validar os campos
        /// </summary>
        /// <returns></returns>
        public bool Validar()
        {
            if (String.IsNullOrEmpty(this.txtNome.Text))
            {
                MessageBox.Show("O campo Nome é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (this.cmbFornecedor.SelectedIndex == 0)
            {
                MessageBox.Show("O campo Fornecedor é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (this.cmbTipoProduto.SelectedIndex == 0)
            {
                MessageBox.Show("O campo Tipo Produto é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(this.txtValorCompra.Text))
            {
                MessageBox.Show("O campo Valor de Compra é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(this.txtValorVenda.Text))
            {
                MessageBox.Show("O campo Valor de Venda é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(this.txtDataCompra.Text))
            {
                MessageBox.Show("O campo Data da Compra é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(this.txtCodigo.Text))
            {
                MessageBox.Show("O campo Código é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Convert.ToDecimal(this.txtValorCompra.Text) <= 0)
            {
                MessageBox.Show("O campo Valor de Compra deve ser maior que zero.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Convert.ToDecimal(this.txtValorVenda.Text) <= 0)
            {
                MessageBox.Show("O campo Valor de Venda deve ser maior que zero.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            ProdutoBO produtoBO = new ProdutoBO();
            ProdutoBE produtoBE = produtoBO.Consultar(null, this.txtCodigo.Text, Convert.ToInt32(((BertoniAcessorios.BE.FornecedorBE)this.cmbFornecedor.SelectedItem).Id));

            if (!String.IsNullOrEmpty(produtoBE.Codigo) && this.id != produtoBE.Id)
            {
                MessageBox.Show("Já existe um produto cadastrado com este código.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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
            produtoBE.IdTipoProduto = Convert.ToInt32(((BertoniAcessorios.BE.TipoProdutoBE)this.cmbTipoProduto.SelectedItem).Id);
            produtoBE.IdFornecedor = Convert.ToInt32(((BertoniAcessorios.BE.FornecedorBE)this.cmbFornecedor.SelectedItem).Id);
            produtoBE.ValorCompra = Convert.ToDecimal(this.txtValorCompra.Text);
            produtoBE.ValorVenda = Convert.ToDecimal(this.txtValorVenda.Text);
            produtoBE.DataCompra = Convert.ToDateTime(this.txtDataCompra.Text);
            produtoBE.Id = this.id;
            return produtoBE;
        }

        /// <summary>
        /// Método responsável por salvar
        /// </summary>
        public void Salvar(ProdutoBE produtoBE)
        {
            ProdutoBO produtoBO = new ProdutoBO();
            produtoBO.Salvar(produtoBE);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                ProdutoBE produtoBE = this.PreencherDados();
                this.Salvar(produtoBE);
                MessageBox.Show("Produto salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmListaProduto frmListaProduto = new frmListaProduto();
                frmListaProduto.Show();
            }
        }
    }
}
