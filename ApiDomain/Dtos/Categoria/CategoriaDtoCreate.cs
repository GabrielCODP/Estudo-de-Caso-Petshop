using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Dtos.Categoria
{
    public class CategoriaDtoCreate
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }
    }
}
