using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Especie
{
    public class EspecieDtoUpdateResult
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
