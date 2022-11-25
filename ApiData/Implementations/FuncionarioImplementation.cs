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
    public class FuncionarioImplementation : BaseRepository<FuncionarioEntity>, IFuncionarioRepository
    {
        private DbSet<FuncionarioEntity> _dataset;

        public FuncionarioImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<FuncionarioEntity>();
        }

    }
}