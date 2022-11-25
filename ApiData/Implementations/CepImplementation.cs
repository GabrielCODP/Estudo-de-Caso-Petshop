using ApiData.Context;
using ApiData.Repository;
using ApiDomain.Entities;
using ApiDomain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiData.Implementations
{
    public class CepImplementation : BaseRepository<CepEntity>, ICepRepository
    {
        private DbSet<CepEntity> _dataset;

        public CepImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<CepEntity>();
        }

        public async Task<CepEntity> SelectAsync(string cep)
        {
            return await _dataset.Include(c => c.Municipio)
                                 .ThenInclude(m => m.Uf)
                                 .SingleOrDefaultAsync(u => u.Cep.Equals(cep));
        }
    }
}
