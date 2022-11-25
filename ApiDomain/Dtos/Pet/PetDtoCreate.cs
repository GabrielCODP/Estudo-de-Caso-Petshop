using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Dtos.Pet
{
    public class PetDtoCreate
    {
        [Required]
        [StringLength(60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Required]
        public int Idade { get; set; }

        [Required]
        public Guid RacaId { get; set; }

        [Required]
        public Guid EspecieId { get; set; }

    }
}
