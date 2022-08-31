using CursoApiRestfull.Model;

namespace CursoApiRestfull.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long Id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long Id);
        public bool Exists(long Id);   
    }
}
