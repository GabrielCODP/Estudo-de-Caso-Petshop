using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Entities
{
    public class ClienteEntity : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Tipo { get; set; }

        [Required]
        public Guid PessoaId { get; set; }
        public PessoaEntity Pessoa { get; set; }
    }
}
