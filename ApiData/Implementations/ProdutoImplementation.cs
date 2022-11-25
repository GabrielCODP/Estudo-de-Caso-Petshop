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
    public class ProdutoImplementation : BaseRepository<ProdutoEntity>, IProdutoRepository
    {
        private DbSet<ProdutoEntity> _dataset;

        public ProdutoImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<ProdutoEntity>();
        }

    }
}