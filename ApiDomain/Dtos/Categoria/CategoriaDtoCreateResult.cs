using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Categoria
{
    public class CategoriaDtoCreateResult
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
