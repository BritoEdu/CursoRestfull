using CursoApiRestfull.Model;
using CursoApiRestfull.Model.Context;
using CursoApiRestfull.Repository;

namespace CursoApiRestfull.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;


        public PersonBusinessImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }
        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(long Id)
        {
           _repository.Delete(Id);  
        }

        public List<Person> FindAll()
        {
            try
            {
                return _repository.FindAll();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Person FindById(long Id)
        {
            var pessoa = new Person();
            try
            {
                pessoa = _repository.FindById(Id);  
            }
            catch (Exception)
            {
                throw;
            }

            return pessoa;
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
    }
}
