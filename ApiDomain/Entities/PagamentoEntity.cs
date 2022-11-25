using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Entities
{
    public class PagamentoEntity : BaseEntity
    {
        [Required]
        public bool SituacaoDoPagamento { get; set; }
        [Required]
        public Guid ServicoId { get; set; }
        public ServicoEntity Servico { get; set; }

    }
}
