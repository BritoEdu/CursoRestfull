using CursoApiRestfull.Data.VO;

namespace CursoApiRestfull.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long Id);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long Id);
    }
}
