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
    public class TipoDespesaDALC
    {
        public List<TipoDespesaBE> Listar(TipoDespesaBE tipoDespesaBE)
        {
            List<TipoDespesaBE> listaTipoDespesaBE = new List<TipoDespesaBE>();

            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_TIPODESPESA_LISTAR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar, 200, "Nome"));
                command.Parameters.Add(new SqlParameter("@Ativo", SqlDbType.Bit, 10, "Ativo"));

                command.Parameters["@Nome"].Value = tipoDespesaBE.Nome;
                command.Parameters["@Ativo"].Value = tipoDespesaBE.Ativo;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    TipoDespesaBE tipoDespesaRetornoBE = new TipoDespesaBE();
                    tipoDespesaRetornoBE.Id = Convert.ToInt32(reader["Id"]);
                    tipoDespesaRetornoBE.Nome = reader["nome"].ToString();
                    tipoDespesaRetornoBE.Ativo = Convert.ToBoolean(reader["ativo"]);
                    tipoDespesaRetornoBE.DataInclusao = Convert.ToDateTime(reader["dtinclusao"]);
                    if (reader["dtalteracao"] != DBNull.Value)
                    {
                        tipoDespesaRetornoBE.DataAlteracao = Convert.ToDateTime(reader["dtalteracao"]);
                    }

                    listaTipoDespesaBE.Add(tipoDespesaRetornoBE);
                }

                reader.Close();
            }

            return listaTipoDespesaBE;
        }
    }
}
