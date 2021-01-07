using BPLS.CadastroVeiculo.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPLS.CadastroVeiculo.Data.Seeds
{
    public class ModeloSeed
    {
        public static void Seed(ApplicationContext context)
        {
            if (!context.Modelos.Any())
            {

                var m1 = new Modelo { Descricao = "FH" };
                var m2 = new Modelo { Descricao = "FM" };

                if (context.Set<Modelo>().Any(x => x.IdModelo == m1.IdModelo))
                    context.Set<Modelo>().Add(m1);
                else
                    context.Set<Modelo>().Update(m1);

                if (context.Set<Modelo>().Any(x => x.IdModelo == m2.IdModelo))
                    context.Set<Modelo>().Add(m2);
                else
                    context.Set<Modelo>().Update(m2);

                context.SaveChanges();
            }
        }
    }
}
