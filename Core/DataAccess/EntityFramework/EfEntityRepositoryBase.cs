using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //IDisposable pattern implementation c#
            using (TContext contex = new TContext())
            {
                var addEntity = contex.Entry(entity);
                addEntity.State = EntityState.Added;
                contex.SaveChanges();

            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext contex = new TContext())
            {
                var deleteEntity = contex.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                contex.SaveChanges();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext contex = new TContext())
            {
                return contex.Set<TEntity>().SingleOrDefault(filter);

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext contex = new TContext())
            {
                return filter == null
                    ? contex.Set<TEntity>().ToList()
                    : contex.Set<TEntity>().Where(filter).ToList();

            }
        }

        public void Update(TEntity entity)
        {
            using (TContext contex = new TContext())
            {
                var updateEntity = contex.Entry(entity);
                updateEntity.State = EntityState.Modified;
                contex.SaveChanges();

            }
        }
    }
}
