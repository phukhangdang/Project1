using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Repository.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        public IEnumerable<TEntity> Get();
        public TEntity GetByID(int id);
        public void Create(TEntity entity);
        public void Update(TEntity entityToUpdate);
        public void DeleteByID(int id);

    }
}
