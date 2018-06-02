using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertoniAcessorios.BE
{
    public class VendaBE
    {
        public int? Id { get; set; }

        public int? IdVendedor { get; set; }

        public int? IdProduto { get; set; }

        public string NomeVendedor { get; set; }

        public string NomeProduto { get; set; }

        public decimal ValorVenda { get; set; }

        public decimal ValorComissao { get; set; }

        public bool Ativo { get; set; }

        public DateTime? DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public string CodigoNomeProduto { get; set; }

        public int? IdFornecedor { get; set; }

        public string NomeFornecedor { get; set; }

        public DateTime? DataVenda { get; set; }
    }
}
