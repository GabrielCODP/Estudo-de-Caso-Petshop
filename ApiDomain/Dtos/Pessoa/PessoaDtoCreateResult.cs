using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Pessoa
{
    public class PessoaDtoCreateResult
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime CreateAt { get; set; }

    }
}
