using BPLS.CadastroVeiculo.Dominio;
using BPLS.CadastroVeiculo.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BPLS.CadastroVeiculo.Data.Configurations
{
    public class TipoVeiculoConfiguration : IEntityTypeConfiguration<TipoVeiculo>
    {
        public void Configure(EntityTypeBuilder<TipoVeiculo> builder)
        {
            builder.ToTable("TiposVeiculo");
            builder.HasKey(p => p.IdTipoVeiculo);
            builder.Property(p => p.Descricao)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();
        }
    }
}
