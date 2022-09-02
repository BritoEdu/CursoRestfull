using CursoApiRestfull.Data.Converter.Contract;
using CursoApiRestfull.Model;

namespace CursoApiRestfull.Data.Converter.Implementation
{
    public class LivroConverter : IParser<LivroVO, Livro>, IParser<Livro, LivroVO>
    {
        public Livro Parse(LivroVO origin)
        {
            if (origin == null) return null;
            return new Livro
            {
                Id = origin.Id,
                Autor = origin.Autor,
                DataLancamento = origin.DataLancamento,
                Preco = origin.Preco,
                Titulo = origin.Titulo
            };
        }

        public LivroVO Parse(Livro origin)
        {
            if (origin == null) return null;
            return new LivroVO
            {
                Id = origin.Id,
                Autor = origin.Autor,
                DataLancamento = origin.DataLancamento,
                Preco = origin.Preco,
                Titulo = origin.Titulo
            };
        }

        public List<Livro> Parse(List<LivroVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<LivroVO> Parse(List<Livro> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
