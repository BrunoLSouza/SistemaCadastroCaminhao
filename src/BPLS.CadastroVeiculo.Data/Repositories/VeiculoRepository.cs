using BPLS.CadastroVeiculo.Dominio.Entities;
using BPLS.CadastroVeiculo.Dominio.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPLS.CadastroVeiculo.Data.Repositories
{
    public class VeiculoRepository : BaseRepository<Veiculo>, IVeiculoRepository
    {
        public ICollection<Veiculo> ObterTodos()
        {
            return Db.Veiculos.Include(p => p.Modelo).Include(p => p.TipoVeiculo).ToList();
        }

    }
}
