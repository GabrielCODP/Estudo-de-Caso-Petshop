using ApiDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Mapping
{
    public class FuncionarioMap : IEntityTypeConfiguration<FuncionarioEntity>
    {
        public void Configure(EntityTypeBuilder<FuncionarioEntity> builder)
        {
            builder.ToTable("Funcionario");

            builder.HasKey(u => u.Id);
        }
    }
}