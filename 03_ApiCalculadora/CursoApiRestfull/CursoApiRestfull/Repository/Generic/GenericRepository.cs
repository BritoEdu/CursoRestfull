using CursoApiRestfull.Model;
using CursoApiRestfull.Model.Base;
using CursoApiRestfull.Model.Context;
using Microsoft.EntityFrameworkCore;

namespace CursoApiRestfull.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        private SqlContext _sqlContext;
        private DbSet<T> _dbSet;

        public GenericRepository(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
            _dbSet = _sqlContext.Set<T>();
        }
        public T Create(T item)
        {
            try
            {
                _dbSet.Add(item);
                _sqlContext.SaveChanges();
                return item;
            }
            catch (Exception)
            {
                throw;
            }


        }

        public void Delete(long Id)
        {
            var result = _dbSet.Where(d => d.Id == Id).FirstOrDefault();

            if (result != null)
            {
                try
                {
                    _dbSet.Remove(result);
                    _sqlContext.SaveChanges();

                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<T> FindAll()
        {
            return _dbSet.ToList();
        }

        public T FindById(long Id)
        {
            return  _dbSet.SingleOrDefault(d => d.Id == Id);
        }

        public T Update(T item)
        {
          //  var result = _dbSet.SingleOrDefault(d => d.Id == item.Id);
            if (item != null)
            {
                try
                {
                    _dbSet.Update(item);
                    _sqlContext.SaveChanges();
                    return item;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                return null;
            }
          
        }

        public bool Exists(long Id)
        {
            return _dbSet.Any(d => d.Id == Id);
        }
    }
}
