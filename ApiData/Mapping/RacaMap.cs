using ApiDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Mapping
{
    public class RacaMap : IEntityTypeConfiguration<RacaEntity>
    {
        public void Configure(EntityTypeBuilder<RacaEntity> builder)
        {
            builder.ToTable("Raca");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Descricao).IsRequired().HasMaxLength(60);

        }
    }
}
