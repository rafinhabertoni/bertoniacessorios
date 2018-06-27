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
    public class VendaDALC
    {
        public void Salvar(VendaBE vendaBE)
        {
            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_VENDA_SALVAR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 0, "Id"));
                command.Parameters.Add(new SqlParameter("@IdVendedor", SqlDbType.Int, 0, "IdVendedor"));
                command.Parameters.Add(new SqlParameter("@IdProduto", SqlDbType.Int, 0, "IdProduto"));
                command.Parameters.Add(new SqlParameter("@ValorVenda", SqlDbType.Decimal, 16, "ValorVenda"));
                command.Parameters.Add(new SqlParameter("@ValorComissao", SqlDbType.Decimal, 16, "ValorComissao"));
                command.Parameters.Add(new SqlParameter("@DataVenda", SqlDbType.DateTime, 16, "DataVenda"));

                command.Parameters["@Id"].Value = vendaBE.Id;
                command.Parameters["@IdVendedor"].Value = vendaBE.IdVendedor;
                command.Parameters["@IdProduto"].Value = vendaBE.IdProduto;
                command.Parameters["@ValorVenda"].Value = vendaBE.ValorVenda;
                command.Parameters["@ValorComissao"].Value = vendaBE.ValorComissao;
                command.Parameters["@DataVenda"].Value = vendaBE.DataVenda;

                int id = command.ExecuteNonQuery();
            }
        }

        public List<VendaBE> Listar(VendaBE vendaBE)
        {
            List<VendaBE> listaVendaBE = new List<VendaBE>();

            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_VENDA_LISTAR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@IdVendedor", SqlDbType.Int, 0, "IdVendedor"));
                command.Parameters.Add(new SqlParameter("@IdProduto", SqlDbType.Int, 0, "IdProduto"));
                command.Parameters.Add(new SqlParameter("@Ativo", SqlDbType.Bit, 0, "Ativo"));
                if (vendaBE.DataInclusao.HasValue)
                {
                    command.Parameters.Add(new SqlParameter("@DtVenda", SqlDbType.DateTime, 0, "DtVenda"));
                }
                command.Parameters.Add(new SqlParameter("@IdFornecedor", SqlDbType.Int, 0, "IdFornecedor"));

                command.Parameters["@IdVendedor"].Value = vendaBE.IdVendedor;
                command.Parameters["@IdProduto"].Value = vendaBE.IdProduto;
                command.Parameters["@Ativo"].Value = vendaBE.Ativo;
                if (vendaBE.DataInclusao.HasValue)
                {
                    command.Parameters["@DtVenda"].Value = vendaBE.DataInclusao;
                }
                command.Parameters["@IdFornecedor"].Value = vendaBE.IdFornecedor;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    VendaBE vendaRetornoBE = new VendaBE();
                    vendaRetornoBE.Id = Convert.ToInt32(reader["Id"]);
                    vendaRetornoBE.Ativo = Convert.ToBoolean(reader["Ativo"]);
                    vendaRetornoBE.IdVendedor = Convert.ToInt32(reader["IdVendedor"]);
                    vendaRetornoBE.IdProduto = Convert.ToInt32(reader["IdProduto"]);
                    vendaRetornoBE.ValorVenda = Convert.ToDecimal(reader["ValorVenda"]);
                    vendaRetornoBE.ValorComissao = Convert.ToDecimal(reader["ValorComissao"]);
                    vendaRetornoBE.NomeVendedor = reader["NomeVendedor"].ToString();
                    vendaRetornoBE.NomeProduto = reader["NomeProduto"].ToString();
                    vendaRetornoBE.DataInclusao = Convert.ToDateTime(reader["dtinclusao"]);
                    if (reader["dtalteracao"] != DBNull.Value)
                    {
                        vendaRetornoBE.DataAlteracao = Convert.ToDateTime(reader["dtalteracao"]);
                    }
                    vendaRetornoBE.CodigoNomeProduto = reader["CodigoNomeProduto"].ToString();
                    vendaRetornoBE.IdFornecedor = Convert.ToInt32(reader["idfornecedor"]);
                    vendaRetornoBE.NomeFornecedor = reader["NomeFornecedor"].ToString();
                    vendaRetornoBE.DataVenda = Convert.ToDateTime(reader["dtvenda"]);

                    listaVendaBE.Add(vendaRetornoBE);
                }

                reader.Close();
            }

            return listaVendaBE;
        }

        public VendaBE Consultar(int? id, int? idProduto)
        {
            VendaBE vendaRetornoBE = new VendaBE();

            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_VENDA_CONSULTAR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 200, "Id"));
                if (idProduto.HasValue)
                {
                    command.Parameters.Add(new SqlParameter("@IdProduto", SqlDbType.Int, 10, "IdProduto"));
                }

                command.Parameters["@Id"].Value = id;
                if (idProduto.HasValue)
                {
                    command.Parameters["@IdProduto"].Value = idProduto;
                }

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    vendaRetornoBE.Id = Convert.ToInt32(reader["Id"]);
                    vendaRetornoBE.Ativo = Convert.ToBoolean(reader["Ativo"]);
                    vendaRetornoBE.IdVendedor = Convert.ToInt32(reader["IdVendedor"]);
                    vendaRetornoBE.IdProduto = Convert.ToInt32(reader["IdProduto"]);
                    vendaRetornoBE.ValorVenda = Convert.ToDecimal(reader["ValorVenda"]);
                    vendaRetornoBE.ValorComissao = Convert.ToDecimal(reader["ValorComissao"]);
                    vendaRetornoBE.NomeVendedor = reader["NomeVendedor"].ToString();
                    vendaRetornoBE.NomeProduto = reader["NomeProduto"].ToString();
                    vendaRetornoBE.DataInclusao = Convert.ToDateTime(reader["dtinclusao"]);
                    if (reader["dtalteracao"] != DBNull.Value)
                    {
                        vendaRetornoBE.DataAlteracao = Convert.ToDateTime(reader["dtalteracao"]);
                    }
                    vendaRetornoBE.CodigoNomeProduto = reader["CodigoNomeProduto"].ToString();
                    vendaRetornoBE.IdFornecedor = Convert.ToInt32(reader["idfornecedor"]);
                    vendaRetornoBE.NomeFornecedor = reader["NomeFornecedor"].ToString();
                    vendaRetornoBE.DataVenda = Convert.ToDateTime(reader["dtvenda"]);
                    vendaRetornoBE.CodigoNomeFornecedor = reader["CodigoNomeFornecedor"].ToString();
                }

                reader.Close();
            }
            return vendaRetornoBE;
        }

        public void Excluir(int id)
        {
            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_VENDA_EXCLUIR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 0, "Id"));

                command.Parameters["@Id"].Value = id;

                command.ExecuteNonQuery();
            }
        }
    }
}
