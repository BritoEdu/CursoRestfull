using CursoApiRestfull.Model;
using CursoApiRestfull.Model.Context;

namespace CursoApiRestfull.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private SqlContext _sqlContext;


        public PersonServiceImplementation(SqlContext sqlContext)
        {
            _sqlContext = sqlContext;
        }
        public Person Create(Person person)
        {
            try
            {
                _sqlContext.Persons.Add(person);
                _sqlContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

            return person;
        }

        public void Delete(long Id)
        {
            try
            {
                var person = _sqlContext.Persons.Where(d => d.Id == Id).FirstOrDefault();
                _sqlContext.Remove(person);
                _sqlContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Person> FindAll()
        {
            try
            {
                return _sqlContext.Persons.ToList();
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
                pessoa = _sqlContext.Persons.SingleOrDefault(d => d.Id.Equals(Id));
            }
            catch (Exception)
            {
                throw;
            }

            return pessoa;
        }

        public Person Update(Person person)
        {
            try
            {
                _sqlContext.Persons.Update(person);
                _sqlContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

            return person;
        }
    }
}
