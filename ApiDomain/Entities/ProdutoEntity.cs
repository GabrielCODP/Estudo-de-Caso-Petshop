using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Entities
{
    public class ProdutoEntity : BaseEntity
    {
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }

        [Required]
        public double Preco { get; set; }

        [Required]
        public Guid CategoriaId { get; set; }
        public CategoriaEntity Categoria { get; set; }

        public IEnumerable<ServicoEntity> Servico { get; set; }
    }
}
