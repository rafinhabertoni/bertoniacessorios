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
using Microsoft.Reporting.WinForms;

namespace BertoniAcessorios
{
    public partial class frmRelatorioProduto : Form
    {
        public frmRelatorioProduto()
        {
            InitializeComponent();
            this.CarregarComboFornecedor();
            this.cmbFornecedor.SelectedIndex = 0;
            this.cmbProduto.SelectedIndex = 0;
            this.cmbMes.SelectedIndex = 0;
            this.cmbAno.SelectedIndex = 0;
            this.cmbVendido.SelectedIndex = 1;
        }

        private void frmRelatorioProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bertoniAcessoriosDataSet.PR_VENDA_RELATORIO'. Você pode movê-la ou removê-la conforme necessário.
            this.pR_PRODUTO_RELATORIOTableAdapter.Fill(this.bertoniAcessoriosDataSet.PR_PRODUTO_RELATORIO, null, null, null, null, true);
            this.pR_VENDA_RELATORIO_GRAFICOTableAdapter.Fill(this.bertoniAcessoriosDataSet.PR_VENDA_RELATORIO_GRAFICO, null, null, null, null, null);
            /*ReportDataSource datasource = new ReportDataSource("dsvenda", bertoniAcessoriosDataSet.Tables[0]);
            this.rdlVenda.LocalReport.DataSources.Clear();
            this.rdlVenda.LocalReport.DataSources.Add(datasource);*/
            this.rdlProduto.RefreshReport();
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int? idProduto = null;
            int? idFornecedor = null;
            int? idVendedor = null;
            int? mes = null;
            int? ano = null;
            bool? vendido = null;
            if (this.cmbProduto.SelectedIndex > 0)
            {
                idProduto = Convert.ToInt32(((BertoniAcessorios.BE.ProdutoBE)this.cmbProduto.SelectedItem).Id);
            }
            ReportParameter parametroFornecedor = new ReportParameter();
            if (this.cmbFornecedor.SelectedIndex > 0)
            {
                idFornecedor = Convert.ToInt32(((BertoniAcessorios.BE.FornecedorBE)this.cmbFornecedor.SelectedItem).Id);
            }
            if (this.cmbMes.SelectedIndex > 0)
            {
                mes = this.cmbMes.SelectedIndex;
            }
            if (this.cmbAno.SelectedIndex > 0)
            {
                ano = Convert.ToInt32(this.cmbAno.SelectedItem);
            }
            if (this.cmbVendido.SelectedIndex > 0)
            {
                if(this.cmbVendido.SelectedItem.ToString() == "Sim")
                {
                    vendido = true;
                }
                else
                {
                    vendido = false;
                }
            }

            this.pR_PRODUTO_RELATORIOTableAdapter.Fill(this.bertoniAcessoriosDataSet.PR_PRODUTO_RELATORIO, idFornecedor, idProduto, mes, ano, vendido);

            this.pR_VENDA_RELATORIO_GRAFICOTableAdapter.Fill(this.bertoniAcessoriosDataSet.PR_VENDA_RELATORIO_GRAFICO, idFornecedor, idVendedor, idProduto, mes, ano);

            this.rdlProduto.RefreshReport();
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
