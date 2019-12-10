using System.Collections.Generic;
using Dwd.Lab.Dominio.Contratos;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        public void Alterar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }       

        public void Remover(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity RetornarPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TEntity> RetornarTodos()
        {
            throw new System.NotImplementedException();
        }

        public void Salvar(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }
    }
}
