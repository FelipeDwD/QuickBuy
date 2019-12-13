using System;
using System.Collections.Generic;

namespace Dwd.Lab.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entity);
        TEntity RetornarPorId(int id);
        IEnumerable<TEntity> RetornarTodos();
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);


    }
}
