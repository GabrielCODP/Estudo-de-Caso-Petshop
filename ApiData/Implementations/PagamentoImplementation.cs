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
    public class PagamentoImplementation : BaseRepository<PagamentoEntity>, IPagamentoRepository
    {
        private DbSet<EspecieEntity> _dataset;

        public PagamentoImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<EspecieEntity>();
        }


    }
}
