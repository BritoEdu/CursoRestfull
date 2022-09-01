using CursoApiRestfull.Model;

namespace CursoApiRestfull.Business
{
    public interface ILivroBusiness
    {
        LivroVO Create(LivroVO livro);
        LivroVO FindById(long Id);
        List<LivroVO> FindAll();
        LivroVO Update(LivroVO livro);
        void Delete(long Id);
    }
}
