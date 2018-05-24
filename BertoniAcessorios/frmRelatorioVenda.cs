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
        }

        private void frmRelatorioVenda_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bertoniAcessoriosDataSet.PR_VENDA_RELATORIO'. Você pode movê-la ou removê-la conforme necessário.
            this.pR_VENDA_RELATORIOTableAdapter.Fill(this.bertoniAcessoriosDataSet.PR_VENDA_RELATORIO);
            /*ReportDataSource datasource = new ReportDataSource("dsvenda", bertoniAcessoriosDataSet.Tables[0]);
            this.rdlVenda.LocalReport.DataSources.Clear();
            this.rdlVenda.LocalReport.DataSources.Add(datasource);*/
            this.rdlVenda.RefreshReport();
        }
    }
}
