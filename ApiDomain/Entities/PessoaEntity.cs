using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Entities
{
    public class PessoaEntity : BaseEntity
    {
        [Required]
        [MaxLength(30)]
        public string Nome { get; set; }
        public string Email { get; set; }

        [Required]
        public DateTime Nascimento { get; set; }
        public IEnumerable<CepEntity> Ceps { get; set; }
        public IEnumerable<TelefoneEntity> Telefone { get; set; }
    }
}
