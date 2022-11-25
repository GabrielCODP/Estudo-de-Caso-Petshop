using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Raca
{
    public class RacaDtoCreateResult
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
