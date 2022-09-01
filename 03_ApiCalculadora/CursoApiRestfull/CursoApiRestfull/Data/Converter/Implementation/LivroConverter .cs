using CursoApiRestfull.Data.Converter.Contract;
using CursoApiRestfull.Model;

namespace CursoApiRestfull.Data.Converter.Implementation
{
    public class LivroConverter : Iparser<LivroVO, Livro>, Iparser<Livro, LivroVO>
    {
        public Livro Parse(LivroVO origin)
        {
            if (origin == null) return null;
            return new Livro
            {
                Id = origin.Id,
                Titulo = origin.Titulo,
                Autor = origin.Autor,
                Preco = origin.Preco,
                DataLancamento = origin.DataLancamento

            };
        }



        public LivroVO Parse(Livro origin)
        {
            if (origin == null) return null;
            return new LivroVO
            {
                Id = origin.Id,
                Titulo = origin.Titulo,
                Autor = origin.Autor,
                Preco = origin.Preco,
                DataLancamento = origin.DataLancamento
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
