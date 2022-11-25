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
    public class CategoriaImplementation : BaseRepository<CategoriaEntity>, ICategoriaRepository
    {
        private DbSet<CategoriaEntity> _dataset;

        public CategoriaImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<CategoriaEntity>();
        }

    }
}