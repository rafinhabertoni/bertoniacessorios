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
    public partial class frmVenda : Form
    {
        public int? id;

        public frmVenda(int? idVenda)
        {
            InitializeComponent();

            this.CarregarComboProduto(0);
            this.CarregarComboFornecedor();
            this.CarregarComboVedendor();
            if (idVenda != null)
            {
                id = idVenda;
                this.CarregarDados(idVenda);
            }
        }

        public void CarregarDados(int? idProduto)
        {
            VendaBO vendaBO = new VendaBO();
            VendaBE vendaBE = vendaBO.Consultar(id.Value, null);

            this.txtValorComissao.Text = vendaBE.ValorComissao.ToString();
            this.txtValorVenda.Text = vendaBE.ValorVenda.ToString();
            this.cmbVendedor.SelectedIndex = this.cmbVendedor.FindString(vendaBE.NomeVendedor);
            this.cmbFornecedor.SelectedIndex = this.cmbFornecedor.FindString(vendaBE.NomeFornecedor);
            this.cmbProduto.SelectedIndex = this.cmbProduto.FindString(vendaBE.CodigoNomeProduto);
            this.txtDataVenda.Text = vendaBE.DataVenda.Value.ToString("dd/MM/yyyy");
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

        public void CarregarComboProduto(int idFornecedor)
        {
            ProdutoBO produtoBO = new ProdutoBO();
            ProdutoBE produtoBE = new ProdutoBE();
            produtoBE.Ativo = true;
            produtoBE.IdFornecedor = idFornecedor;
            List<ProdutoBE> listaTipoProdutoBE = produtoBO.Listar(produtoBE);

            VendaBO vendaBO = new VendaBO();
            VendaBE vendaBE = new VendaBE();
            vendaBE.Ativo = true;
            vendaBE.IdFornecedor = idFornecedor;
            List<VendaBE> listaVendaBE = vendaBO.Listar(vendaBE);
            if (id.HasValue)
            {
                listaVendaBE.RemoveAll(d => d.Id.Value == id.Value);
            }

            cmbProduto.Items.Clear();
            cmbProduto.Items.Add("Selecione");
            foreach (ProdutoBE produtoRetornoBE in listaTipoProdutoBE)
            {
                if (!listaVendaBE.Exists(d => d.IdProduto == produtoRetornoBE.Id.Value))
                {
                    cmbProduto.Items.Add(produtoRetornoBE);
                }
            }
            cmbProduto.DisplayMember = "CodigoNome";
            cmbProduto.ValueMember = "Id";
            cmbProduto.SelectedIndex = 0;
        }

        public void CarregarComboVedendor()
        {
            VendedorBO vendedorBO = new VendedorBO();
            VendedorBE vendedorBE = new VendedorBE();
            vendedorBE.Ativo = true;
            List<VendedorBE> listaVendedorBE = vendedorBO.Listar(vendedorBE);

            listaVendedorBE = listaVendedorBE.OrderBy(o => o.Nome).ToList();

            cmbVendedor.Items.Add("Selecione");
            foreach (VendedorBE vendedorRetornoBE in listaVendedorBE)
            {
                cmbVendedor.Items.Add(vendedorRetornoBE);
            }
            cmbVendedor.DisplayMember = "Nome";
            cmbVendedor.ValueMember = "Id";
            cmbVendedor.SelectedIndex = 0;
        }

        /// <summary>
        /// Método responsável por validar os campos
        /// </summary>
        /// <returns></returns>
        public bool Validar()
        {
            if (this.cmbVendedor.SelectedIndex == 0)
            {
                MessageBox.Show("O campo Vendedor é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (this.cmbProduto.SelectedIndex == 0)
            {
                MessageBox.Show("O campo Produto é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(this.txtValorVenda.Text))
            {
                MessageBox.Show("O campo Valor de Venda é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(this.txtValorComissao.Text))
            {
                MessageBox.Show("O campo Valor de Comissão é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Convert.ToDecimal(this.txtValorVenda.Text) <= 0)
            {
                MessageBox.Show("O campo Valor de Venda deve ser maior que zero.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (Convert.ToDecimal(this.txtValorComissao.Text) < 0)
            {
                MessageBox.Show("O campo Valor de Comissão deve ser maior ou igual a zero.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(this.txtDataVenda.Text))
            {
                MessageBox.Show("O campo Data da Venda é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            VendaBO vendaBO = new VendaBO();
            VendaBE vendaBE = vendaBO.Consultar(null, Convert.ToInt32(((BertoniAcessorios.BE.ProdutoBE)this.cmbProduto.SelectedItem).Id));

            if (vendaBE.IdProduto.HasValue && this.id != vendaBE.Id)
            {
                MessageBox.Show("Já existe uma venda cadastrada para este produto.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Recupera os dados dos campos
        /// </summary>
        /// <returns></returns>
        public VendaBE PreencherDados()
        {
            VendaBE vendaBE = new VendaBE();
            vendaBE.IdProduto = Convert.ToInt32(((BertoniAcessorios.BE.ProdutoBE)this.cmbProduto.SelectedItem).Id);
            vendaBE.IdVendedor = Convert.ToInt32(((BertoniAcessorios.BE.VendedorBE)this.cmbVendedor.SelectedItem).Id);
            vendaBE.ValorComissao = Convert.ToDecimal(this.txtValorComissao.Text);
            vendaBE.ValorVenda = Convert.ToDecimal(this.txtValorVenda.Text);
            vendaBE.DataVenda = Convert.ToDateTime(this.txtDataVenda.Text);
            vendaBE.Id = this.id;
            return vendaBE;
        }

        /// <summary>
        /// Método responsável por salvar
        /// </summary>
        public void Salvar(VendaBE vendaBE)
        {
            VendaBO vendaBO = new VendaBO();
            vendaBO.Salvar(vendaBE);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                VendaBE vendaBE = this.PreencherDados();
                this.Salvar(vendaBE);
                MessageBox.Show("Venda salva com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmListaVenda frmListaVenda = new frmListaVenda();
                frmListaVenda.Show();
            }
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbProduto.SelectedIndex != 0)
            {
                ProdutoBO produtoBO = new ProdutoBO();
                ProdutoBE produtoBE = produtoBO.Consultar(Convert.ToInt32(((BertoniAcessorios.BE.ProdutoBE)this.cmbProduto.SelectedItem).Id), null, null);

                this.txtValorVenda.Text = produtoBE.ValorVenda.ToString();

                if (Convert.ToDecimal(((BertoniAcessorios.BE.VendedorBE)this.cmbVendedor.SelectedItem).Porcentagem) > 0)
                {
                    this.txtValorComissao.Text = ((produtoBE.ValorVenda * Convert.ToDecimal(((BertoniAcessorios.BE.VendedorBE)this.cmbVendedor.SelectedItem).Porcentagem)) / 100).ToString("#0.00");
                }
                else
                {
                    this.txtValorComissao.Text = "0,00";
                }
            }
            else
            {
                this.txtValorVenda.Text = String.Empty;
                this.txtValorComissao.Text = String.Empty;
            }
        }

        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cmbFornecedor.SelectedIndex = 0;
            this.cmbProduto.SelectedIndex = 0;
            this.txtValorVenda.Text = String.Empty;
            this.txtValorComissao.Text = String.Empty;

            if (cmbVendedor.SelectedIndex == 0)
            {
                this.cmbFornecedor.Enabled = false;
                this.cmbProduto.Enabled = false;
                this.txtValorVenda.Enabled = false;
            }
            else
            {
                this.cmbFornecedor.Enabled = true;
                this.cmbProduto.Enabled = false;
            }
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFornecedor.SelectedIndex <=0)
            {
                this.cmbProduto.Enabled = false;
                this.cmbProduto.SelectedIndex = 0;
                this.txtValorVenda.Text = String.Empty;
                this.txtValorComissao.Text = String.Empty;
            }
            else
            {
                int idFornecedor = 0;
                if (cmbFornecedor.SelectedIndex > 0)
                {
                    idFornecedor = Convert.ToInt32(((BertoniAcessorios.BE.FornecedorBE)this.cmbFornecedor.SelectedItem).Id);
                }
                this.CarregarComboProduto(idFornecedor);
                this.cmbProduto.Enabled = true;
                this.cmbProduto.SelectedIndex = 0;
            }
        }
    }
}
