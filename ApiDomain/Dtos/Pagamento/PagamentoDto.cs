﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Pagamento
{
    public class PagamentoDto
    {
        public Guid Id { get; set; }
        public bool SituacaoDoPagamento { get; set; }
        public Guid ServicoId { get; set; }
    }
}
