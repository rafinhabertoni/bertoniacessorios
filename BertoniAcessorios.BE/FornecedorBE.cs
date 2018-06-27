using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertoniAcessorios.BE
{
    public class FornecedorBE
    {
        public int? Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Codigo { get; set; }

        public DateTime DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public bool Ativo { get; set; }

        public string CodigoNome { get; set; }
    }
}
