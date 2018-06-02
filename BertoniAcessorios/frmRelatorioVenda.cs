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
    public partial class frmRelatorioVenda : Form
    {
        public frmRelatorioVenda()
        {
            InitializeComponent();
            this.CarregarComboFornecedor();
            this.CarregarComboVendedor();
            this.cmbTipoRelatorio.SelectedIndex = 0;
        }

        private void frmRelatorioVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bertoniAcessoriosDataSet.PR_VENDA_RELATORIO'. Você pode movê-la ou removê-la conforme necessário.
            this.pR_VENDA_RELATORIOTableAdapter.Fill(this.bertoniAcessoriosDataSet.PR_VENDA_RELATORIO, null, null, null, null);
            /*ReportDataSource datasource = new ReportDataSource("dsvenda", bertoniAcessoriosDataSet.Tables[0]);
            this.rdlVenda.LocalReport.DataSources.Clear();
            this.rdlVenda.LocalReport.DataSources.Add(datasource);*/
            this.rdlVenda.RefreshReport();
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

        public void CarregarComboVendedor()
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int? idProduto = null;
            int? idFornecedor = null;
            int? idVendedor = null;
            if (this.cmbProduto.SelectedIndex != 0)
            {
                idProduto = Convert.ToInt32(((BertoniAcessorios.BE.ProdutoBE)this.cmbProduto.SelectedItem).Id);
            }
            ReportParameter parametroVendedor = new ReportParameter();
            if (this.cmbVendedor.SelectedIndex != 0)
            {
                idVendedor = Convert.ToInt32(((BertoniAcessorios.BE.VendedorBE)this.cmbVendedor.SelectedItem).Id);
            }
            ReportParameter parametroFornecedor = new ReportParameter();
            if (this.cmbFornecedor.SelectedIndex != 0)
            {
                idFornecedor = Convert.ToInt32(((BertoniAcessorios.BE.FornecedorBE)this.cmbFornecedor.SelectedItem).Id);
            }

            this.pR_VENDA_RELATORIOTableAdapter.Fill(this.bertoniAcessoriosDataSet.PR_VENDA_RELATORIO, idFornecedor, idVendedor, idProduto, null);

            /*ReportParameter parametroProduto = new ReportParameter();
            if (this.cmbProduto.SelectedIndex != 0)
            {
                parametroProduto.Name = "idProduto";
                parametroProduto.Values.Add(((BertoniAcessorios.BE.ProdutoBE)this.cmbProduto.SelectedItem).Id.Value.ToString());
            }
            ReportParameter parametroVendedor = new ReportParameter();
            if (this.cmbVendedor.SelectedIndex != 0)
            {
                parametroVendedor.Name = "idVendedor";
                parametroVendedor.Values.Add(((BertoniAcessorios.BE.VendedorBE)this.cmbVendedor.SelectedItem).Id.Value.ToString());
            }
            ReportParameter parametroFornecedor = new ReportParameter();
            if (this.cmbFornecedor.SelectedIndex != 0)
            {
                parametroFornecedor.Name = "idFornecedor";
                parametroFornecedor.Values.Add(((BertoniAcessorios.BE.FornecedorBE)this.cmbFornecedor.SelectedItem).Id.Value.ToString());
            }

            this.rdlVenda.LocalReport.SetParameters(new ReportParameter[] { parametroFornecedor, parametroProduto, parametroVendedor });*/

            this.rdlVenda.RefreshReport();
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
