using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertoniAcessorios.BE
{
    public class VendedorBE
    {
        public int? Id { get; set; }

        public string Nome { get; set; }

        public decimal Porcentagem { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }
    }
}
