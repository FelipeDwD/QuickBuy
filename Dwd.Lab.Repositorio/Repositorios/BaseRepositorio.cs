using System.Collections.Generic;
using System.Linq;
using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Repositorio.Contexto;

namespace Dwd.Lab.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {

        protected readonly LabDataContext LabDataContext;

        public BaseRepositorio(LabDataContext labDataContext)
        {
            LabDataContext = labDataContext;
        }
        public void Adicionar(TEntity entity)
        {
            LabDataContext.Set<TEntity>().Add(entity);
            LabDataContext.SaveChanges();
        }
        public void Atualizar(TEntity entity)
        {
            LabDataContext.Set<TEntity>().Update(entity);
            LabDataContext.SaveChanges();
        }       

        public void Remover(TEntity entity)
        {
            LabDataContext.Remove(entity);
            LabDataContext.SaveChanges();
        }

        public TEntity RetornarPorId(int id)
        {
            return LabDataContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> RetornarTodos()
        {
            return LabDataContext.Set<TEntity>().ToList();
        }       

        public void Dispose()
        {
            LabDataContext.Dispose();
        }
    }
}
