using ApiDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Mapping
{
    public class PessoaMap : IEntityTypeConfiguration<PessoaEntity>
    {
        public void Configure(EntityTypeBuilder<PessoaEntity> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(u => u.Id);
        }
    }
}
