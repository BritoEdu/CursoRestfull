using CursoApiRestfull.Data.Converter.Contract;
using CursoApiRestfull.Data.VO;
using CursoApiRestfull.Model;

namespace CursoApiRestfull.Data.Converter.Implementation
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public Person Parse(PersonVO origin)
        {
            if (origin == null) return null;
            return new Person
            {
                Id = origin.Id,
                Nome = origin.Nome,
                Sobrenome = origin.Sobrenome,
                Endereço = origin.Endereço,
                Genero = origin.Genero
            };
        }

        public PersonVO Parse(Person origin)
        {
            if (origin == null) return null;
            return new PersonVO
            {
                Id = origin.Id,
                Nome = origin.Nome,
                Sobrenome = origin.Sobrenome,
                Endereço = origin.Endereço,
                Genero = origin.Genero
            };
        }

        public List<Person> Parse(List<PersonVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<PersonVO> Parse(List<Person> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
