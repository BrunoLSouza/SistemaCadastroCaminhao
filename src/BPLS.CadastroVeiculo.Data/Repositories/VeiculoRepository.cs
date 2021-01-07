using BPLS.CadastroVeiculo.Dominio.Entities;
using BPLS.CadastroVeiculo.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPLS.CadastroVeiculo.Data.Repositories
{
    public class VeiculoRepository : BaseRepository<Veiculo>, IVeiculoRepository
    {
        

        //public Veiculo Atualizar(Veiculo veiculo)
        //{
        //    return Atualizar(veiculo);
        //}

        //public void Excluir(long IdVeiculo)
        //{
        //    Excluir(IdVeiculo);
        //}

        //public ICollection<Veiculo> ListarTodos()
        //{
        //    return ObterTodos().ToList();
        //}

        //public Veiculo ObterPorId(long IdVeiculo)
        //{
        //    return ObterPorId(IdVeiculo);
        //}

        //public Veiculo Salvar(Veiculo veiculo)
        //{
        //    return Adicionar(veiculo);
        //}
    }
}
