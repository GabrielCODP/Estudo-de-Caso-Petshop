using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ApiDomain.Entities
{
    public class EspecieEntity : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Descricao { get; set; }

    }
}
