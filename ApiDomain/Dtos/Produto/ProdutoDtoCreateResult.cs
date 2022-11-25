using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Produto
{
    public class ProdutoDtoCreateResult
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public Guid CategoriaId { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
