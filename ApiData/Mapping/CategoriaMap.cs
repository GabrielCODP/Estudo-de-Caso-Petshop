using ApiDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Mapping
{
    internal class CategoriaMap : IEntityTypeConfiguration<CategoriaEntity>
    {
        public void Configure(EntityTypeBuilder<CategoriaEntity> builder)
        {
            builder.ToTable("Categoria");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome).IsRequired().HasMaxLength(60);
        }
    }
}