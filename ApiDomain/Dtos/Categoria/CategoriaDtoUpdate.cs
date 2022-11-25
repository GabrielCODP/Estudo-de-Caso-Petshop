using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Dtos.Categoria
{
    public class CategoriaDtoUpdate
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Id é campo Obrigatorio")]
        public Guid Id { get; set; }
    }
}
