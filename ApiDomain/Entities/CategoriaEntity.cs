using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Entities
{
    public class CategoriaEntity : BaseEntity
    {
        [Required]
        [MaxLength(45)]
        public string Nome { get; set; }
        public IEnumerable<ProdutoEntity> Produtos { get; set; }
    }
}
