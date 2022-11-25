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
    public class ClienteImplementation : BaseRepository<ClienteEntity>, IClienteRepository
    {
        private DbSet<ClienteEntity> _dataset;

        public ClienteImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<ClienteEntity>();
        }

    }
}