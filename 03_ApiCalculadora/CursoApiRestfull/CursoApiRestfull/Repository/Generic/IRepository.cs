using CursoApiRestfull.Model.Base;

namespace CursoApiRestfull.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindById(long Id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long Id);
        public bool Exists(long Id);
    }

}
