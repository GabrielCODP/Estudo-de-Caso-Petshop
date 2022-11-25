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
    public class TelefoneImplementation : BaseRepository<TelefoneEntity>, ITelefoneRepository
    {
        private DbSet<TelefoneEntity> _dataset;

        public TelefoneImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<TelefoneEntity>();
        }

      
    }
}
