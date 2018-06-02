using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BertoniAcessorios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            this.lblVersao.Text = String.Format("Versão: {0}", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frmMenu frmMenu = new frmMenu();
            frmMenu.Show();

            this.Hide();
        }
    }
}
