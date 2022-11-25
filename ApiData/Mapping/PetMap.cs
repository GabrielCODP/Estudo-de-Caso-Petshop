using ApiDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Mapping
{
    public class PetMap : IEntityTypeConfiguration<PetEntity>
    {
        public void Configure(EntityTypeBuilder<PetEntity> builder)
        {
            builder.ToTable("Pet");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome).IsRequired().HasMaxLength(60);

            builder.Property(u => u.Idade).IsRequired();
        }
    }
}
