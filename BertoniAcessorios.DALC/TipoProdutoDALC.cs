using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BertoniAcessorios.BE;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace BertoniAcessorios.DALC
{
    public class TipoProdutoDALC
    {
        public List<TipoProdutoBE> Listar(TipoProdutoBE tipoProdutoBE)
        {
            List<TipoProdutoBE> listaTipoProdutoBE = new List<TipoProdutoBE>();

            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_TIPOPRODUTO_LISTAR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar, 200, "Nome"));
                command.Parameters.Add(new SqlParameter("@Sigla", SqlDbType.VarChar, 10, "Codigo"));

                command.Parameters["@Nome"].Value = tipoProdutoBE.Nome;
                command.Parameters["@Sigla"].Value = tipoProdutoBE.Sigla;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TipoProdutoBE tipoProdutoRetornoBE = new TipoProdutoBE();
                    tipoProdutoRetornoBE.Id = Convert.ToInt32(reader["Id"]);
                    tipoProdutoRetornoBE.Nome = reader["nome"].ToString();
                    tipoProdutoRetornoBE.Sigla = reader["sigla"].ToString();
                    tipoProdutoRetornoBE.DataInclusao = Convert.ToDateTime(reader["dtinclusao"]);
                    if (reader["dtalteracao"] != DBNull.Value)
                    {
                        tipoProdutoRetornoBE.DataAlteracao = Convert.ToDateTime(reader["dtalteracao"]);
                    }

                    listaTipoProdutoBE.Add(tipoProdutoRetornoBE);
                }

                reader.Close();
            }

            return listaTipoProdutoBE;
        }
    }
}
