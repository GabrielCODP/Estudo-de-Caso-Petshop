using ApiData.Context;
using ApiData.Repository;
using ApiDomain.Entities;
using ApiDomain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Implementations
{
    public class PetImplementation : BaseRepository<PetEntity>, IPetRepository
    {
        private DbSet<PetEntity> _dataset;

        public PetImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<PetEntity>();
        }

    }
}