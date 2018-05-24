using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BertoniAcessorios.DALC;
using BertoniAcessorios.BE;

namespace BertoniAcessorios.BO
{
    public class FornecedorBO
    {
        public void Salvar(FornecedorBE fornecedorBE)
        {
            FornecedorDALC fornecedorDALC = new FornecedorDALC();
            fornecedorDALC.Salvar(fornecedorBE);
        }

        public List<FornecedorBE> Listar(FornecedorBE fornecedorBE)
        {
            FornecedorDALC fornecedorDALC = new FornecedorDALC();
            return fornecedorDALC.Listar(fornecedorBE);
        }

        public FornecedorBE Consultar(int? id, string codigo)
        {
            FornecedorDALC fornecedorDALC = new FornecedorDALC();
            return fornecedorDALC.Consultar(id, codigo);
        }

        public void Excluir(int id)
        {
            FornecedorDALC fornecedorDALC = new FornecedorDALC();
            fornecedorDALC.Excluir(id);
        }
    }
}
