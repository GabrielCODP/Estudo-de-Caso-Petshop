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
    public class PessoaImplementation : BaseRepository<PessoaEntity>, IPessoaRepository
    {
        private DbSet<PessoaEntity> _dataset;
        public PessoaImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<PessoaEntity>();
        }
    }
}
