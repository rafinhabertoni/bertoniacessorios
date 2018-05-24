using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BertoniAcessorios.DALC;
using BertoniAcessorios.BE;

namespace BertoniAcessorios.BO
{
    public class TipoProdutoBO
    {
        public List<TipoProdutoBE> Listar(TipoProdutoBE tipoProdutoBE)
        {
            TipoProdutoDALC tipoProdutoDALC = new TipoProdutoDALC();
            return tipoProdutoDALC.Listar(tipoProdutoBE);
        }
    }
}
