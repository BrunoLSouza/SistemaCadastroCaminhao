using BPLS.CadastroVeiculo.Data.Seeds;
using BPLS.CadastroVeiculo.Dominio;
using BPLS.CadastroVeiculo.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BPLS.CadastroVeiculo.Data
{
    public class ApplicationContext : DbContext
    {

        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<TipoVeiculo> TiposVeiculo { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=(localdb)\\mssqllocaldb; Initial Catalog=DBCadastroVeiculo; Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);

            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }

    }
}
