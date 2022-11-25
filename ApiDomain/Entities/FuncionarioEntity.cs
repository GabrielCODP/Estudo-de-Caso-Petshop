using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Entities
{
    public class FuncionarioEntity : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Funcao { get; set; }

        [Required]
        public Guid PessoaId { get; set; }
        public PessoaEntity Pessoa { get; set; }
    }
}
