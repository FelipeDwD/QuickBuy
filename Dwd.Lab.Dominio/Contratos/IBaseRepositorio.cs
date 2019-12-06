using System;
using System.Collections.Generic;

namespace Dwd.Lab.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Salvar(TEntity entity);
        TEntity RetornarPorId(int id);
        IEnumerable<TEntity> RetornarTodos();
        void Alterar(TEntity entity);
        void Remover(TEntity entity);
        

    }
}
