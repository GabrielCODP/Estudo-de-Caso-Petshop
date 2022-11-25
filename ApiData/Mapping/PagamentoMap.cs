using ApiDomain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiData.Mapping
{
    public class PagamentoMap : IEntityTypeConfiguration<PagamentoEntity>
    {
        public void Configure(EntityTypeBuilder<PagamentoEntity> builder)
        {
            builder.ToTable("Pagamento");

            builder.HasKey(u => u.Id);


        }
    }
}