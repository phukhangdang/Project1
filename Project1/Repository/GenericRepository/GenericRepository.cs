using Microsoft.EntityFrameworkCore;
using Project1.DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Repository.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal DatabaseContext dbContext;
        internal DbSet<TEntity> dbSet;
        public GenericRepository(DatabaseContext context)
        {
            this.dbContext = context;
            this.dbSet = context.Set<TEntity>();
        }
        public virtual void Create(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void DeleteByID(int id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            dbSet.Remove(entityToDelete);
        }

        public virtual IEnumerable<TEntity> Get()
        {
            return dbSet.ToList();
        }

        public virtual TEntity GetByID(int id)
        {
            return dbSet.Find(id);
        }

        public virtual void Update(TEntity entityToUpdate)
        {
            dbSet.Attach(entityToUpdate);
            dbContext.Entry(entityToUpdate).State = EntityState.Modified;
        }
    }
}
