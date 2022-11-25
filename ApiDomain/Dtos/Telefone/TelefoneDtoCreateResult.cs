using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Telefone
{
    public class TelefoneDtoCreateResult
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public Guid PessoaId { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
