using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Funcionario
{
    public class FuncionarioDtoUpdateResult
    {
        public Guid Id { get; set; }
        public string Funcao { get; set; }
        public Guid PessoaId { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
