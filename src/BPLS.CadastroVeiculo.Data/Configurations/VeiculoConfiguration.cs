using BPLS.CadastroVeiculo.Dominio;
using BPLS.CadastroVeiculo.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BPLS.CadastroVeiculo.Data.Configurations
{
    public class VeiculoConfiguration : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("Veiculos");
            builder.HasKey(p => p.IdVeiculo);
            builder.Property(p => p.AnoFabricacao).HasColumnType("INT").IsRequired();
            builder.Property(p => p.AnoModelo).HasColumnType("INT").IsRequired();

            builder.HasOne(p => p.Modelo).WithMany().HasForeignKey(p => p.IdModelo);
            //builder.HasOne(p => p.TipoVeiculo).WithMany().HasForeignKey(p => p.IdTipoVeiculo);
        }
    }
}
