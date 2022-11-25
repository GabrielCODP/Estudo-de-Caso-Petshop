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
    public class UfImplementation : BaseRepository<UfEntity>, IUfRepository
    {
        private DbSet<UfEntity> _dataset;

        public UfImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<UfEntity>();
        }
    }
}