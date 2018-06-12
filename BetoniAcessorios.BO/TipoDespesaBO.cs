using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BertoniAcessorios.DALC;
using BertoniAcessorios.BE;

namespace BertoniAcessorios.BO
{
    public class TipoDespesaBO
    {
        public List<TipoDespesaBE> Listar(TipoDespesaBE tipoDespesaBE)
        {
            TipoDespesaDALC tipoDespesaDALC = new TipoDespesaDALC();
            return tipoDespesaDALC.Listar(tipoDespesaBE);
        }
    }
}
