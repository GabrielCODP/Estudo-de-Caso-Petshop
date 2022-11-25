using ApiData.Mapping;
using ApiData.Seeds;
using ApiDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserEntity>(new UserMap().Configure);


            modelBuilder.Entity<UfEntity>(new UfMap().Configure);

            modelBuilder.Entity<MunicipioEntity>(new MunicipioMap().Configure);

            modelBuilder.Entity<CepEntity>(new CepMap().Configure);

            modelBuilder.Entity<TelefoneEntity>(new TelefoneMap().Configure);

            modelBuilder.Entity<PessoaEntity>(new PessoaMap().Configure);

            modelBuilder.Entity<CategoriaEntity>(new CategoriaMap().Configure);

            modelBuilder.Entity<ProdutoEntity>(new ProdutoMap().Configure);

            modelBuilder.Entity<RacaEntity>(new RacaMap().Configure);

            modelBuilder.Entity<EspecieEntity>(new EspecieMap().Configure);

            modelBuilder.Entity<PetEntity>(new PetMap().Configure);

            modelBuilder.Entity<ServicoEntity>(new ServicoMap().Configure);

            modelBuilder.Entity<PagamentoEntity>(new PagamentoMap().Configure);

            modelBuilder.Entity<ClienteEntity>(new ClienteMap().Configure);

            modelBuilder.Entity<FuncionarioEntity>(new FuncionarioMap().Configure);

            modelBuilder.Entity<UserEntity>().HasData(new UserEntity
            {

                Id = Guid.NewGuid(),
                Name = "DexterAdmin",
                Email = "Dexter@gmail.com",
                CreateAt = DateTime.Now,
                UpdateAt = DateTime.Now,
            });


            UfSeeds.Ufs(modelBuilder);
        }

    }
}
