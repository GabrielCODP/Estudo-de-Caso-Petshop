using ApiDomain.Dtos.Uf;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Municipio
{
    public class MunicipioDtoCompleto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int CodIBGE { get; set; }
        public Guid UfId { get; set; }
        public UfDto Uf { get; set; }

    }
}