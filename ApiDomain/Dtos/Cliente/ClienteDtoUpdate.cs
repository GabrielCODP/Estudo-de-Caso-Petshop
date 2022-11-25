using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Cliente
{
    public class ClienteDtoUpdate
    {
        public Guid Id { get; set; }
        public string Tipo { get; set; }

        public Guid PessoaId { get; set; }
    }
}
