using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Dtos.Pessoa
{
    public class PessoaDtoCreate
    {
        [Required(ErrorMessage = "Nome")]
        public string Nome { get; set; }
        public string Email { get; set; }

        [Required(ErrorMessage = "Nascimento")]
        public DateTime Nascimento { get; set; }
    }
}
