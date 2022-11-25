using ApiDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Mapping
{
    public class TelefoneMap : IEntityTypeConfiguration<TelefoneEntity>
    {
        public void Configure(EntityTypeBuilder<TelefoneEntity> builder)
        {
            builder.ToTable("Telefone");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.Numero).IsUnique();
        }
    }
}