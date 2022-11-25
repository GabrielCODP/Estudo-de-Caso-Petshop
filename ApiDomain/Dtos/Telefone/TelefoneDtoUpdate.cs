using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Dtos.Telefone
{
    public class TelefoneDtoUpdate
    {
        [Required(ErrorMessage = "Id é campo Obrigatorio")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Número é obrigatorio")]
        public string Numero { get; set; }

        [Required(ErrorMessage = "Código da pessoa é obrigatorio")]
        public Guid PessoaId { get; set; }
    }
}
