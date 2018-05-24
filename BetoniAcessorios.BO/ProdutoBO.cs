using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BertoniAcessorios.DALC;
using BertoniAcessorios.BE;

namespace BertoniAcessorios.BO
{
    public class ProdutoBO
    {
        public void Salvar(ProdutoBE produtoBE)
        {
            ProdutoDALC fornecedorDALC = new ProdutoDALC();
            fornecedorDALC.Salvar(produtoBE);
        }

        public List<ProdutoBE> Listar(ProdutoBE produtoBE)
        {
            ProdutoDALC fornecedorDALC = new ProdutoDALC();
            return fornecedorDALC.Listar(produtoBE);
        }

        public ProdutoBE Consultar(int? id, string codigo, int? idFornecedor)
        {
            ProdutoDALC fornecedorDALC = new ProdutoDALC();
            return fornecedorDALC.Consultar(id, codigo, idFornecedor);
        }

        public void Excluir(int id)
        {
            ProdutoDALC produtoDALC = new ProdutoDALC();
            produtoDALC.Excluir(id);
        }
    }
}
