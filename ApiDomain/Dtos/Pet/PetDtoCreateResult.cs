﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ApiDomain.Dtos.Pet
{
    public class PetDtoCreateResult
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Guid RacaId { get; set; }
        public Guid EspecieId { get; set; }

  
        public DateTime CreateAt { get; set; }

     
    }
}
