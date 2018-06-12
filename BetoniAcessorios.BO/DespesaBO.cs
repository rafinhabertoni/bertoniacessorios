using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BertoniAcessorios.DALC;
using BertoniAcessorios.BE;

namespace BertoniAcessorios.BO
{
    public class DespesaBO
    {
        public void Salvar(DespesaBE despesaBE)
        {
            DespesaDALC despesaDALC = new DespesaDALC();
            despesaDALC.Salvar(despesaBE);
        }

        public List<DespesaBE> Listar(DespesaBE despesaBE)
        {
            DespesaDALC despesaDALC = new DespesaDALC();
            return despesaDALC.Listar(despesaBE);
        }

        public DespesaBE Consultar(int? id, int? idTipoDespesa, DateTime? dtDespesa)
        {
            DespesaDALC despesaDALC = new DespesaDALC();
            return despesaDALC.Consultar(id, idTipoDespesa, dtDespesa);
        }

        public void Excluir(int id)
        {
            DespesaDALC despesaDALC = new DespesaDALC();
            despesaDALC.Excluir(id);
        }
    }
}
