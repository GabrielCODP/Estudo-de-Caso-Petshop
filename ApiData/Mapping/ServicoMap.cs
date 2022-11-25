using ApiDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Mapping
{
    public class ServicoMap : IEntityTypeConfiguration<ServicoEntity>
    {
        public void Configure(EntityTypeBuilder<ServicoEntity> builder)
        {
            builder.ToTable("Servico");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Descricao).IsRequired().HasMaxLength(60);

            //builder.HasIndex(u => u.CategoriaId);
        }
    }
}