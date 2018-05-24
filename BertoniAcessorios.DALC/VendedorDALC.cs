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
    public class VendedorDALC
    {
        public List<VendedorBE> Listar(VendedorBE vendedorBE)
        {
            List<VendedorBE> listaVendedorBE = new List<VendedorBE>();

            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_VENDEDOR_LISTAR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Nome", SqlDbType.VarChar, 200, "Nome"));
                command.Parameters.Add(new SqlParameter("@Ativo", SqlDbType.Bit, 0, "Ativo"));

                command.Parameters["@Nome"].Value = vendedorBE.Nome;
                command.Parameters["@Ativo"].Value = vendedorBE.Ativo;

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    VendedorBE vendedorRetornoBE = new VendedorBE();
                    vendedorRetornoBE.Id = Convert.ToInt32(reader["Id"]);
                    vendedorRetornoBE.Nome = reader["nome"].ToString();
                    vendedorRetornoBE.Porcentagem = Convert.ToDecimal(reader["porcentagem"]);
                    vendedorRetornoBE.Ativo = Convert.ToBoolean(reader["ativo"].ToString());
                    vendedorRetornoBE.DataInclusao = Convert.ToDateTime(reader["dtinclusao"]);
                    if (reader["dtalteracao"] != DBNull.Value)
                    {
                        vendedorRetornoBE.DataAlteracao = Convert.ToDateTime(reader["dtalteracao"]);
                    }

                    listaVendedorBE.Add(vendedorRetornoBE);
                }

                reader.Close();
            }

            return listaVendedorBE;
        }
    }
}
