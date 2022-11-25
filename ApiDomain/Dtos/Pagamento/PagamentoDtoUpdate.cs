using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Dtos.Pagamento
{
    public class PagamentoDtoUpdate
    {
        [Required(ErrorMessage = "Id é campo Obrigatorio")]
        public Guid Id { get; set; }
        [Required]
        public bool SituacaoDoPagamento { get; set; }

        [Required(ErrorMessage = "Código é campo Obrigatorio")]
        public Guid ServicoId { get; set; }
    }
}
