using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Especie
{
    public class EspecieDtoCreateResult
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
