using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Dtos.Produto
{
    public class ProdutoDtoCreate
    {
        [Required]
        [StringLength(60, ErrorMessage = "Nome de Município deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Required]
        public double Preco { get; set; }

        [Required]
        public Guid CategoriaId { get; set; }
    }
}
