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
    public partial class frmFornecedor : Form
    {
        public int? id;

        public frmFornecedor(int? idFornecedor)
        {
            InitializeComponent();

            if(idFornecedor != null)
            {
                id = idFornecedor;
                this.CarregarDados(idFornecedor);   
            }
        }

        public void CarregarDados(int? idFornecedor)
        {
            FornecedorBO fornecedorBO = new FornecedorBO();
            FornecedorBE fornecedorBE = fornecedorBO.Consultar(id.Value, null);

            this.txtNome.Text = fornecedorBE.Nome;
            this.txtDescricao.Text = fornecedorBE.Descricao;
            this.txtCodigo.Text = fornecedorBE.Codigo;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(this.Validar())
            {
                FornecedorBE fornecedorBE = this.PreencherDados();
                this.Salvar(fornecedorBE);
                MessageBox.Show("Fornecedor salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                frmListaFornecedor frmListaFornecedor = new frmListaFornecedor();
                frmListaFornecedor.Show();
            }
        }

        /// <summary>
        /// Método responsável por validar os campos
        /// </summary>
        /// <returns></returns>
        public bool Validar()
        {
            if(String.IsNullOrEmpty(this.txtNome.Text))
            {
                MessageBox.Show("O campo Nome é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(this.txtDescricao.Text))
            {
                MessageBox.Show("O campo Descrição é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (String.IsNullOrEmpty(this.txtCodigo.Text))
            {
                MessageBox.Show("O campo Código é obrigatório.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            FornecedorBO fornecedorBO = new FornecedorBO();
            FornecedorBE fornecedorBE = fornecedorBO.Consultar(null, this.txtCodigo.Text);

            if(!String.IsNullOrEmpty(fornecedorBE.Codigo) && this.id != fornecedorBE.Id)
            {
                MessageBox.Show("Já existe um fornecedor cadastrado com este código.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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
            fornecedorBE.Id = this.id;
            return fornecedorBE;
        }

        /// <summary>
        /// Método responsável por salvar
        /// </summary>
        public void Salvar(FornecedorBE fornecedorBE)
        {
            FornecedorBO fornecedorBO = new FornecedorBO();
            fornecedorBO.Salvar(fornecedorBE);
        }
    }
}
