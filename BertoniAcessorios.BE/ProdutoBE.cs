using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertoniAcessorios.BE
{
    public class ProdutoBE
    {
        public int? Id { get; set; }

        public string Nome { get; set; }

        public string Codigo { get; set; }

        public int? IdTipoProduto { get; set; }

        public int? IdFornecedor { get; set; }

        public string TipoProduto { get; set; }

        public string NomeFornecedor { get; set; }

        public decimal ValorCompra { get; set; }

        public decimal ValorVenda { get; set; }

        public bool Ativo { get; set; }

        public DateTime? DataCompra { get; set; }

        public DateTime DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public string CodigoNome { get; set; }
    }
}
