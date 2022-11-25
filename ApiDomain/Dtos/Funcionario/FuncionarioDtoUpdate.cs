using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Funcionario
{
    public class FuncionarioDtoUpdate
    {
        public Guid Id { get; set; }
        public string Funcao { get; set; }

        public Guid PessoaId { get; set; }
    }
}
