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
    public class RacaImplementation : BaseRepository<RacaEntity>, IRacaRepository
    {
        private DbSet<EspecieEntity> _dataset;

        public RacaImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<EspecieEntity>();
        }


    }
}