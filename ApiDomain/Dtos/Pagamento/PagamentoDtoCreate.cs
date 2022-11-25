using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Dtos.Pagamento
{
    public class PagamentoDtoCreate
    {
        [Required]
        public bool SituacaoDoPagamento { get; set; }

        [Required(ErrorMessage = "Código é campo Obrigatorio")]
        public Guid ServicoId { get; set; }
    }
}
