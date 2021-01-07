using BPLS.CadastroVeiculo.Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BPLS.CadastroVeiculo.Data.Seeds
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {           
            modelBuilder.Entity<Modelo>().HasData(
                new Modelo { IdModelo = 1, Descricao = "FH"},
                new Modelo { IdModelo = 2,Descricao = "FM" }
            );

            modelBuilder.Entity<TipoVeiculo>().HasData(
               new TipoVeiculo { IdTipoVeiculo = 1, Descricao = "Caminhão" }
           );

            modelBuilder.Entity<Veiculo>().HasData(
               new Veiculo { IdVeiculo = 1, AnoFabricacao = 2021, AnoModelo = 2020, IdModelo = 1, IdTipoVeiculo = 1 }
           );

        }

    }
}
