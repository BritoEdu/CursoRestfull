using CursoApiRestfull.Data.Converter.Implementation;
using CursoApiRestfull.Data.VO;
using CursoApiRestfull.Model;
using CursoApiRestfull.Repository.Generic;

namespace CursoApiRestfull.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;
        private readonly PersonConverter _converter;


        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }
        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);  
        }

        public void Delete(long Id)
        {
           _repository.Delete(Id);  
        }

        public List<PersonVO> FindAll()
        {
            try
            {
                return _converter.Parse(_repository.FindAll());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PersonVO FindById(long Id)
        {
            var person = new PersonVO();
            try
            {
                person = _converter.Parse(_repository.FindById(Id));  
            }
            catch (Exception)
            {
                throw;
            }

            return person;
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }
    }
}
