using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Repository
{
    public class EFRepository<TEntity> where TEntity : class
    {
        private SchoolContext _dbContext;

        public EFRepository(string connectionString)
        {
            _dbContext = new SchoolContext(connectionString);
        }

        public TEntity GetById(object id)
        {
            return _dbContext.Find<TEntity>(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>();
        }

        public void Insert(TEntity data)
        {
            _dbContext.Add<TEntity>(data);
            _dbContext.SaveChanges();
        }
    }
}
