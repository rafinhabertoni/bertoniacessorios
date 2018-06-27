using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BertoniAcessorios.BE;

namespace BertoniAcessorios.DALC
{
    public class ProdutoDALC
    {
        public void Salvar(ProdutoBE produtoBE)
        {
            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_PRODUTO_SALVAR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 0, "Id"));
                command.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar, 200, "Nome"));
                command.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 10, "Codigo"));
                command.Parameters.Add(new SqlParameter("@IdTipoProduto", SqlDbType.Int, 0, "IdTipoProduto"));
                command.Parameters.Add(new SqlParameter("@IdFornecedor", SqlDbType.Int, 0, "IdFornecedor"));
                command.Parameters.Add(new SqlParameter("@ValorCompra", SqlDbType.Decimal, 16, "ValorCompra"));
                command.Parameters.Add(new SqlParameter("@ValorVenda", SqlDbType.Decimal, 16, "ValorVenda"));
                command.Parameters.Add(new SqlParameter("@DtCompra", SqlDbType.DateTime, 0, "DtCompra"));

                command.Parameters["@Id"].Value = produtoBE.Id;
                command.Parameters["@Nome"].Value = produtoBE.Nome;
                command.Parameters["@Codigo"].Value = produtoBE.Codigo;
                command.Parameters["@IdTipoProduto"].Value = produtoBE.IdTipoProduto;
                command.Parameters["@IdFornecedor"].Value = produtoBE.IdFornecedor;
                command.Parameters["@ValorCompra"].Value = produtoBE.ValorCompra;
                command.Parameters["@ValorVenda"].Value = produtoBE.ValorVenda;
                command.Parameters["@DtCompra"].Value = produtoBE.DataCompra;

                int id = command.ExecuteNonQuery();
            }
        }

        public List<ProdutoBE> Listar(ProdutoBE produtoBE)
        {
            List<ProdutoBE> listaProdutoBE = new List<ProdutoBE>();

            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_PRODUTO_LISTAR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar, 200, "Nome"));
                command.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 10, "Codigo"));
                command.Parameters.Add(new SqlParameter("@IdTipoProduto", SqlDbType.Int, 0, "IdTipoProduto"));
                command.Parameters.Add(new SqlParameter("@IdFornecedor", SqlDbType.Int, 0, "IdFornecedor"));
                command.Parameters.Add(new SqlParameter("@Ativo", SqlDbType.Bit, 0, "Ativo"));
                if (produtoBE.DataCompra.HasValue)
                {
                    command.Parameters.Add(new SqlParameter("@DtCompra", SqlDbType.DateTime, 0, "DtCompra"));
                }

                command.Parameters["@Nome"].Value = produtoBE.Nome;
                command.Parameters["@Codigo"].Value = produtoBE.Codigo;
                command.Parameters["@IdTipoProduto"].Value = produtoBE.IdTipoProduto;
                command.Parameters["@IdFornecedor"].Value = produtoBE.IdFornecedor;
                command.Parameters["@Ativo"].Value = produtoBE.Ativo;
                if (produtoBE.DataCompra.HasValue)
                {
                    command.Parameters["@DtCompra"].Value = produtoBE.DataCompra;
                }

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ProdutoBE produtoRetornoBE = new ProdutoBE();
                    produtoRetornoBE.Id = Convert.ToInt32(reader["Id"]);
                    produtoRetornoBE.Nome = reader["nome"].ToString();
                    produtoRetornoBE.Codigo = reader["codigo"].ToString();
                    produtoRetornoBE.Ativo = Convert.ToBoolean(reader["Ativo"]);
                    produtoRetornoBE.IdTipoProduto = Convert.ToInt32(reader["IdTipoProduto"]);
                    produtoRetornoBE.IdFornecedor = Convert.ToInt32(reader["IdFornecedor"]);
                    produtoRetornoBE.ValorCompra = Convert.ToDecimal(reader["ValorCompra"]);
                    produtoRetornoBE.ValorVenda = Convert.ToDecimal(reader["ValorVenda"]);
                    produtoRetornoBE.TipoProduto = reader["TipoProduto"].ToString();
                    produtoRetornoBE.NomeFornecedor = reader["nomefornecedor"].ToString();
                    produtoRetornoBE.DataInclusao = Convert.ToDateTime(reader["dtinclusao"]);
                    produtoRetornoBE.DataCompra = Convert.ToDateTime(reader["dtcompra"]);
                    if (reader["dtalteracao"] != DBNull.Value)
                    {
                        produtoRetornoBE.DataAlteracao = Convert.ToDateTime(reader["dtalteracao"]);
                    }
                    produtoRetornoBE.CodigoNome = reader["CodigoNome"].ToString();

                    listaProdutoBE.Add(produtoRetornoBE);
                }

                reader.Close();
            }

            return listaProdutoBE;
        }

        public ProdutoBE Consultar(int? id, string codigo, int? idfornecedor)
        {
            ProdutoBE produtoRetornoBE = new ProdutoBE();

            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_PRODUTO_CONSULTAR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 200, "Id"));
                command.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 10, "Codigo"));
                command.Parameters.Add(new SqlParameter("@IdFornecedor", SqlDbType.Int, 200, "IdFornecedor"));

                command.Parameters["@Id"].Value = id;
                command.Parameters["@Codigo"].Value = codigo;
                if (idfornecedor.HasValue)
                {
                    command.Parameters["@IdFornecedor"].Value = idfornecedor.Value;
                }

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    produtoRetornoBE.Id = Convert.ToInt32(reader["Id"]);
                    produtoRetornoBE.Nome = reader["nome"].ToString();
                    produtoRetornoBE.Codigo = reader["codigo"].ToString();
                    produtoRetornoBE.Ativo = Convert.ToBoolean(reader["Ativo"]);
                    produtoRetornoBE.IdTipoProduto = Convert.ToInt32(reader["IdTipoProduto"]);
                    produtoRetornoBE.IdFornecedor = Convert.ToInt32(reader["IdFornecedor"]);
                    produtoRetornoBE.ValorCompra = Convert.ToDecimal(reader["ValorCompra"]);
                    produtoRetornoBE.ValorVenda = Convert.ToDecimal(reader["ValorVenda"]);
                    produtoRetornoBE.TipoProduto = reader["TipoProduto"].ToString();
                    produtoRetornoBE.NomeFornecedor = reader["nomefornecedor"].ToString();
                    produtoRetornoBE.DataInclusao = Convert.ToDateTime(reader["dtinclusao"]);
                    produtoRetornoBE.DataCompra = Convert.ToDateTime(reader["dtcompra"]);
                    if (reader["dtalteracao"] != DBNull.Value)
                    {
                        produtoRetornoBE.DataAlteracao = Convert.ToDateTime(reader["dtalteracao"]);
                    }
                    produtoRetornoBE.CodigoNome = reader["CodigoNome"].ToString();
                    produtoRetornoBE.CodigoNomeFornecedor = reader["CodigoNomeFornecedor"].ToString();
                }

                reader.Close();
            }
            return produtoRetornoBE;
        }

        public void Excluir(int id)
        {
            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_Produto_EXCLUIR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 0, "Id"));

                command.Parameters["@Id"].Value = id;

                command.ExecuteNonQuery();
            }
        }
    }
}
