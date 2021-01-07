using BPLS.CadastroVeiculo.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BPLS.CadastroVeiculo.Dominio.Interfaces
{
    public interface IVeiculoRepository
    {
        ICollection<Veiculo> ObterTodos();
        Veiculo ObterPorIdNoTrack(long id);
    }
}
