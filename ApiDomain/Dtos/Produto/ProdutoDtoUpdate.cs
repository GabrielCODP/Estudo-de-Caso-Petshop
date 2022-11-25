using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Dtos.Produto
{
    public class ProdutoDtoUpdate
    {
        [Required(ErrorMessage = "Id é campo Obrigatorio")]
        public Guid Id { get; set; }

        public string Nome { get; set; }
        public double Preco { get; set; }

        [Required(ErrorMessage = "Id é campo Obrigatorio")]
        public Guid CategoriaId { get; set; }
    }
}
