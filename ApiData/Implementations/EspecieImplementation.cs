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
    public class EspecieImplementation : BaseRepository<EspecieEntity>, IEspecieRepository
    {
        private DbSet<EspecieEntity> _dataset;

        public EspecieImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<EspecieEntity>();
        }

       
    }
}