﻿// <auto-generated />
using BPLS.CadastroVeiculo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BPLS.CadastroVeiculo.Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("BPLS.CadastroVeiculo.Dominio.Modelo", b =>
                {
                    b.Property<long>("IdModelo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdModelo");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("BPLS.CadastroVeiculo.Dominio.TipoVeiculo", b =>
                {
                    b.Property<long>("IdTipoVeiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)");

                    b.HasKey("IdTipoVeiculo");

                    b.ToTable("TiposVeiculo");
                });

            modelBuilder.Entity("BPLS.CadastroVeiculo.Dominio.Veiculo", b =>
                {
                    b.Property<long>("IdVeiculo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<int>("AnoFabricacao")
                        .HasColumnType("INT");

                    b.Property<int>("AnoModelo")
                        .HasColumnType("INT");

                    b.Property<long>("IdModelo")
                        .HasColumnType("bigint");

                    b.Property<long>("IdTipoVeiculo")
                        .HasColumnType("bigint");

                    b.HasKey("IdVeiculo");

                    b.HasIndex("IdModelo");

                    b.HasIndex("IdTipoVeiculo");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("BPLS.CadastroVeiculo.Dominio.Veiculo", b =>
                {
                    b.HasOne("BPLS.CadastroVeiculo.Dominio.Modelo", "Modelo")
                        .WithMany("Veiculos")
                        .HasForeignKey("IdModelo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BPLS.CadastroVeiculo.Dominio.TipoVeiculo", "TipoVeiculo")
                        .WithMany("Veiculos")
                        .HasForeignKey("IdTipoVeiculo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Modelo");

                    b.Navigation("TipoVeiculo");
                });

            modelBuilder.Entity("BPLS.CadastroVeiculo.Dominio.Modelo", b =>
                {
                    b.Navigation("Veiculos");
                });

            modelBuilder.Entity("BPLS.CadastroVeiculo.Dominio.TipoVeiculo", b =>
                {
                    b.Navigation("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
