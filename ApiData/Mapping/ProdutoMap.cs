using ApiDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<ProdutoEntity>
    {
        public void Configure(EntityTypeBuilder<ProdutoEntity> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Preco).IsRequired();
            builder.Property(u => u.Nome).IsRequired().HasMaxLength(60);

            //builder.HasIndex(u => u.CategoriaId);
        }
    }
}