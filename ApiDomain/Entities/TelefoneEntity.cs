using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Entities
{
    public class TelefoneEntity : BaseEntity
    {
        [Required]
        public string Numero { get; set; }

        [Required]
        public Guid PessoaId { get; set; }
        public PessoaEntity Pessoa { get; set; }

    }
}
