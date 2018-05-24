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

namespace BertoniAcessorios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmListaFornecedor frmListaFornecedor = new frmListaFornecedor();
            frmListaFornecedor.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmListaProduto frmListaProduto = new frmListaProduto();
            frmListaProduto.Show();
        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            frmListaVenda frmListaVenda = new frmListaVenda();
            frmListaVenda.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
        }

        private void btnRelatorioVendas_Click(object sender, EventArgs e)
        {
            frmRelatorioVenda frmRelatorioVenda = new frmRelatorioVenda();
            frmRelatorioVenda.Show();
        }
    }
}
