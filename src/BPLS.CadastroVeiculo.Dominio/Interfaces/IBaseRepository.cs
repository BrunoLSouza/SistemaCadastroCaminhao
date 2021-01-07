using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BPLS.CadastroVeiculo.Dominio.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {
        TEntity Adicionar(TEntity obj);
        TEntity ObterPorId(long id);
        IEnumerable<TEntity> ObterTodos();
        TEntity Atualizar(TEntity obj);
        void Excluir(long id);
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
    }
}
