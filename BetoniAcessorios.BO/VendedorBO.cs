using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BertoniAcessorios.DALC;
using BertoniAcessorios.BE;

namespace BertoniAcessorios.BO
{
    public class VendedorBO
    {
        public List<VendedorBE> Listar(VendedorBE vendedorBE)
        {
            VendedorDALC vendedorDALC = new VendedorDALC();
            return vendedorDALC.Listar(vendedorBE);
        }
    }
}
