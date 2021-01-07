using BPLS.CadastroVeiculo.Dominio;
using BPLS.CadastroVeiculo.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BPLS.CadastroVeiculo.Data.Configurations
{
    public class ModeloConfiguration : IEntityTypeConfiguration<Modelo>
    {
        public void Configure(EntityTypeBuilder<Modelo> builder)
        {
            builder.ToTable("Modelos");
            builder.HasKey(p => p.IdModelo);
            builder.Property(p => p.Descricao)
                .HasColumnType("VARCHAR(100)")                
                .IsRequired();
        }
    }
}
 