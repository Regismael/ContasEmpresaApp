using ContasEmpresaApp.DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasEmpresaApp.Infra.DATA.Mappings
{
    public class ContasMap : IEntityTypeConfiguration<Conta>
    {
        public void Configure(EntityTypeBuilder<Conta> builder)
        {
            builder.ToTable("CONTA");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("ID")
                .IsRequired();

            builder.Property(c => c.Descricao)
                .HasColumnName("DESCRICAO")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.Valor)
                .HasColumnName("VALOR")
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(c => c.DataVencimento)
                .HasColumnName("DATAVENCIMENTO")
                .HasColumnType("DateTime")
                .IsRequired();

            builder.Property(c => c.DataHoraPagamento)
                .HasColumnName("DATAHORAPAGAMENTO")
                .HasColumnType("DateTime") 
                .IsRequired(false);

        }
    }
}
