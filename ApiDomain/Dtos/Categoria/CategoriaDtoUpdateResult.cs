using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Categoria
{
    public class CategoriaDtoUpdateResult
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
