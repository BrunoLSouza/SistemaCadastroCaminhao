using BPLS.CadastroVeiculo.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BPLS.CadastroVeiculo.Dominio.Interfaces
{
    public interface IVeiculoRepository
    {
        ICollection<Veiculo> ObterTodos();
        //Veiculo Salvar(Veiculo veiculo);
        //void Excluir(long IdVeiculo);
        //Veiculo Atualizar(Veiculo vculo);
        //Veiculo ObterPorId(long IdVeiculo);


    }
}
