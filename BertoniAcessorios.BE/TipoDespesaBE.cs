﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertoniAcessorios.BE
{
    public class TipoDespesaBE
    {
        public int? Id { get; set; }

        public string Nome { get; set; }

        public bool Ativo { get; set; }

        public DateTime DataInclusao { get; set; }

        public DateTime? DataAlteracao { get; set; }
    }
}
