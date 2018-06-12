using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertoniAcessorios.BE
{
    public class DespesaBE
    {
        public int? Id { get; set; }

        public int? IdTipoDespesa { get; set; }

        public decimal ValorDespesa { get; set; }

        public bool Ativo { get; set; }

        public DateTime? DataDespesa { get; set; }

        public DateTime DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public string NomeTipoDespesa { get; set; }
    }
}
