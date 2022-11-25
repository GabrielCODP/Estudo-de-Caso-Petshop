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
    public class ServicoImplementation : BaseRepository<ServicoEntity>, IServicoRepository
    {
        private DbSet<ServicoEntity> _dataset;
        public ServicoImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<ServicoEntity>();
        }
    }
}