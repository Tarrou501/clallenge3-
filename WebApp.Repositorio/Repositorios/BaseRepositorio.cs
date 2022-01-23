using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApp.Dominio.Contratos;
using WebApp.Repositorio.Contexto;

namespace WebApp.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly WebAppContexto WebAppContexto;


        public BaseRepositorio(WebAppContexto webAppContexto)
        {
            WebAppContexto = webAppContexto;
        }

        public void Adicionar(TEntity entity)
        {
            WebAppContexto.Set<TEntity>().Add(entity);
            WebAppContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            WebAppContexto.Set<TEntity>().Update(entity);
            WebAppContexto.SaveChanges();
        }


        public TEntity ObterPorId(int id)
        {
            return WebAppContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return WebAppContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            WebAppContexto.Set<TEntity>().Remove(entity);
            WebAppContexto.SaveChanges();

        }

        public void Dispose()
        {
            WebAppContexto.Dispose();
        }
    }
}
