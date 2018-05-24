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
    public class FornecedorDALC
    {
        public void Salvar(FornecedorBE fornecedorBE)
        { 
            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_FORNECEDOR_SALVAR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 0, "Id"));
                command.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar, 200, "Nome"));
                command.Parameters.Add(new SqlParameter("@Descricao", SqlDbType.VarChar, 500, "Descricao"));
                command.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 10, "Codigo"));

                command.Parameters["@Id"].Value = fornecedorBE.Id;
                command.Parameters["@Nome"].Value = fornecedorBE.Nome;
                command.Parameters["@Descricao"].Value = fornecedorBE.Descricao;
                command.Parameters["@Codigo"].Value = fornecedorBE.Codigo;

                int id = command.ExecuteNonQuery();
            }
        }

        public List<FornecedorBE> Listar(FornecedorBE fornecedorBE)
        {
            List<FornecedorBE> listaFornecedorBE = new List<FornecedorBE>();

            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_FORNECEDOR_LISTAR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar, 200, "Nome"));
                command.Parameters.Add(new SqlParameter("@Descricao", SqlDbType.VarChar, 500, "Descricao"));
                command.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 10, "Codigo"));
                command.Parameters.Add(new SqlParameter("@Ativo", SqlDbType.Bit, 0, "Ativo"));

                command.Parameters["@Nome"].Value = fornecedorBE.Nome;
                command.Parameters["@Descricao"].Value = fornecedorBE.Descricao;
                command.Parameters["@Codigo"].Value = fornecedorBE.Codigo;
                command.Parameters["@Ativo"].Value = fornecedorBE.Ativo;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    FornecedorBE fornecedorRetornoBE = new FornecedorBE();
                    fornecedorRetornoBE.Id = Convert.ToInt32(reader["Id"]);
                    fornecedorRetornoBE.Nome = reader["nome"].ToString();
                    fornecedorRetornoBE.Descricao = reader["descricao"].ToString();
                    fornecedorRetornoBE.Codigo = reader["codigo"].ToString();
                    fornecedorRetornoBE.DataInclusao = Convert.ToDateTime(reader["dtinclusao"]);
                    if(reader["dtalteracao"] != DBNull.Value)
                    {
                        fornecedorRetornoBE.DataAlteracao = Convert.ToDateTime(reader["dtalteracao"]);
                    }
                    fornecedorRetornoBE.Ativo = Convert.ToBoolean(reader["ativo"]);
                    
                    listaFornecedorBE.Add(fornecedorRetornoBE);
                }

                reader.Close();
            }

            return listaFornecedorBE;
        }

        public FornecedorBE Consultar(int? id, string codigo)
        {
            FornecedorBE fornecedorRetornoBE = new FornecedorBE();

            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_FORNECEDOR_CONSULTAR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 200, "Id"));
                command.Parameters.Add(new SqlParameter("@Codigo", SqlDbType.VarChar, 10, "Codigo"));

                command.Parameters["@Id"].Value = id;
                command.Parameters["@Codigo"].Value = codigo;

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    fornecedorRetornoBE.Id = Convert.ToInt32(reader["Id"]);
                    fornecedorRetornoBE.Nome = reader["nome"].ToString();
                    fornecedorRetornoBE.Descricao = reader["descricao"].ToString();
                    fornecedorRetornoBE.Codigo = reader["codigo"].ToString();
                    fornecedorRetornoBE.DataInclusao = Convert.ToDateTime(reader["dtinclusao"]);
                    if (reader["dtalteracao"] != DBNull.Value)
                    {
                        fornecedorRetornoBE.DataAlteracao = Convert.ToDateTime(reader["dtalteracao"]);
                    }
                }

                reader.Close();
            }
            return fornecedorRetornoBE;
        }

        public void Excluir(int id)
        {
            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_FORNECEDOR_EXCLUIR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 0, "Id"));

                command.Parameters["@Id"].Value = id;

                command.ExecuteNonQuery();
            }
        }
    }
}
