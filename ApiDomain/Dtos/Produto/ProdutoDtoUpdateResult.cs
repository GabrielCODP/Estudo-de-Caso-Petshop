using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Produto
{
    public class ProdutoDtoUpdateResult
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Guid CategoriaId { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
