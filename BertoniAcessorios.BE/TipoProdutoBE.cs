using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertoniAcessorios.BE
{
    public class TipoProdutoBE
    {
        public int? Id { get; set; }

        public string Nome { get; set; }

        public string Sigla { get; set; }

        public DateTime DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }
    }
}
