﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Pessoa
{
    public class PessoaDto
    {
        public Guid Id { get; set; }
        public string  Nome { get; set; }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }
    }
}
