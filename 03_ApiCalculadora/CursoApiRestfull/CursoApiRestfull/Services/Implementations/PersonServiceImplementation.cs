using CursoApiRestfull.Model;

namespace CursoApiRestfull.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long Id)
        {

        }

        public List<Person> FindAll()
        {
            var pessoas = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
            }
            return pessoas;
        }



        public Person FindById(long Id)
        {
            var pessoa = new Person();
            pessoa.Id = 1;
            pessoa.Nome = "Eduardo";
            pessoa.Sobrenome = "Brito";
            pessoa.Endereço = "São Paulo";
            pessoa.Genero = "Masculino";
            return pessoa;
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                Nome = "Nome"+i,
                Sobrenome = "Eduardo" + i,
                Endereço = "Endereço" + i,
                Genero = "Genero"
            };
        }
        public long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }

    }
}
