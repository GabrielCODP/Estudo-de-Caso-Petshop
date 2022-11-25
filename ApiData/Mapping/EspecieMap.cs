using ApiDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Mapping
{
    public class EspecieMap : IEntityTypeConfiguration<EspecieEntity>
    {
        public void Configure(EntityTypeBuilder<EspecieEntity> builder)
        {
            builder.ToTable("Especie");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Descricao).IsRequired().HasMaxLength(60);

        }
    }
}