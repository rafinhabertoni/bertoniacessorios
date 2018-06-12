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
    public class DespesaDALC
    {
        public void Salvar(DespesaBE despesaBE)
        {
            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_DESPESA_SALVAR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 0, "Id"));
                command.Parameters.Add(new SqlParameter("@IdTipoDespesa", SqlDbType.Int, 0, "IdTipoDespesa"));
                command.Parameters.Add(new SqlParameter("@Valor", SqlDbType.Decimal, 16, "Valor"));
                command.Parameters.Add(new SqlParameter("@DtDespesa", SqlDbType.DateTime, 0, "DtDespesa"));

                command.Parameters["@Id"].Value = despesaBE.Id;
                command.Parameters["@IdTipoDespesa"].Value = despesaBE.IdTipoDespesa;
                command.Parameters["@Valor"].Value = despesaBE.ValorDespesa;
                command.Parameters["@DtDespesa"].Value = despesaBE.DataDespesa;

                int id = command.ExecuteNonQuery();
            }
        }

        public List<DespesaBE> Listar(DespesaBE despesaBE)
        {
            List<DespesaBE> listaDespesaBE = new List<DespesaBE>();

            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_DESPESA_LISTAR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@IdTipoDespesa", SqlDbType.Int, 0, "IdTipoDespesa"));
                command.Parameters.Add(new SqlParameter("@Ativo", SqlDbType.Bit, 0, "Ativo"));
                if (despesaBE.DataDespesa.HasValue)
                {
                    command.Parameters.Add(new SqlParameter("@DtDespesa", SqlDbType.DateTime, 0, "DtDespesa"));
                }

                command.Parameters["@IdTipoDespesa"].Value = despesaBE.IdTipoDespesa;
                command.Parameters["@Ativo"].Value = despesaBE.Ativo;
                if (despesaBE.DataDespesa.HasValue)
                {
                    command.Parameters["@DtDespesa"].Value = despesaBE.DataDespesa;
                }

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DespesaBE despesaRetornoBE = new DespesaBE();
                    despesaRetornoBE.Id = Convert.ToInt32(reader["Id"]);
                    despesaRetornoBE.Ativo = Convert.ToBoolean(reader["Ativo"]);
                    despesaRetornoBE.IdTipoDespesa = Convert.ToInt32(reader["IdTipoDespesa"]);
                    despesaRetornoBE.ValorDespesa = Convert.ToDecimal(reader["Valor"]);
                    despesaRetornoBE.NomeTipoDespesa = reader["NomeTipoDespesa"].ToString();
                    despesaRetornoBE.DataInclusao = Convert.ToDateTime(reader["dtinclusao"]);
                    despesaRetornoBE.DataDespesa = Convert.ToDateTime(reader["dtdespesa"]);
                    if (reader["dtalteracao"] != DBNull.Value)
                    {
                        despesaRetornoBE.DataAlteracao = Convert.ToDateTime(reader["dtalteracao"]);
                    }

                    listaDespesaBE.Add(despesaRetornoBE);
                }

                reader.Close();
            }

            return listaDespesaBE;
        }

        public DespesaBE Consultar(int? id, int? idTipoDespesa, DateTime? dtDespesa)
        {
            DespesaBE despesaRetornoBE = new DespesaBE();

            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_DESPESA_CONSULTAR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 200, "Id"));
                command.Parameters.Add(new SqlParameter("@IdTipoDespesa", SqlDbType.Int, 200, "IdTipoDespesa"));
                command.Parameters.Add(new SqlParameter("@DtDespesa", SqlDbType.DateTime, 200, "DtDespesa"));

                command.Parameters["@Id"].Value = id;
                if (idTipoDespesa.HasValue)
                {
                    command.Parameters["@IdTipoDespesa"].Value = idTipoDespesa.Value;
                }
                if (dtDespesa.HasValue)
                {
                    command.Parameters["@DtDespesa"].Value = dtDespesa.Value;
                }

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    despesaRetornoBE.Id = Convert.ToInt32(reader["Id"]);
                    despesaRetornoBE.Ativo = Convert.ToBoolean(reader["Ativo"]);
                    despesaRetornoBE.IdTipoDespesa = Convert.ToInt32(reader["IdTipoDespesa"]);
                    despesaRetornoBE.ValorDespesa = Convert.ToDecimal(reader["Valor"]);
                    despesaRetornoBE.NomeTipoDespesa = reader["NomeTipoDespesa"].ToString();
                    despesaRetornoBE.DataInclusao = Convert.ToDateTime(reader["dtinclusao"]);
                    despesaRetornoBE.DataDespesa = Convert.ToDateTime(reader["dtdespesa"]);
                    if (reader["dtalteracao"] != DBNull.Value)
                    {
                        despesaRetornoBE.DataAlteracao = Convert.ToDateTime(reader["dtalteracao"]);
                    }
                }

                reader.Close();
            }
            return despesaRetornoBE;
        }

        public void Excluir(int id)
        {
            var connection = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                SqlCommand command = new SqlCommand("PR_DESPESA_EXCLUIR", con);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int, 0, "Id"));

                command.Parameters["@Id"].Value = id;

                command.ExecuteNonQuery();
            }
        }
    }
}
