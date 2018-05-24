using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BertoniAcessorios.DALC;
using BertoniAcessorios.BE;

namespace BertoniAcessorios.BO
{
    public class VendaBO
    {
        public void Salvar(VendaBE vendaBE)
        {
            VendaDALC vendaDALC = new VendaDALC();
            vendaDALC.Salvar(vendaBE);
        }

        public List<VendaBE> Listar(VendaBE vendaBE)
        {
            VendaDALC vendaDALC = new VendaDALC();
            return vendaDALC.Listar(vendaBE);
        }

        public VendaBE Consultar(int? id, int? idProduto)
        {
            VendaDALC vendaDALC = new VendaDALC();
            return vendaDALC.Consultar(id, idProduto);
        }

        public void Excluir(int id)
        {
            VendaDALC vendaDALC = new VendaDALC();
            vendaDALC.Excluir(id);
        }
    }
}
