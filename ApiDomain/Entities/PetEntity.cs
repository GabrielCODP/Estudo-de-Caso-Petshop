using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Entities
{
    public class PetEntity : BaseEntity
    {


        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }

        [Required]
        public int Idade { get; set; }

        [Required]
        public Guid RacaId { get; set; }
        public RacaEntity Raca { get; set; }

        [Required]
        public Guid EspecieId { get; set; }
        public EspecieEntity Especie { get; set; }

    

        public ServicoEntity Servico { get; set; }
    }
}
