using CursoApiRestfull.Data.Converter.Implementation;
using CursoApiRestfull.Data.VO;
using CursoApiRestfull.Model;
using CursoApiRestfull.Repository;
using CursoApiRestfull.Repository.Generic;
using System;

namespace CursoApiRestfull.Business.Implementations
{
    public class LivroBusinessImplementation : ILivroBusiness
    {
        private readonly IRepository<Livro> _repository;
        private readonly LivroConverter _converter;

        public LivroBusinessImplementation(IRepository<Livro> repository)
        {
            _repository = repository;
            _converter = new LivroConverter();
        }

        public LivroVO Create(LivroVO livro)
        {
            var LivroEntity = _converter.Parse(livro);
            LivroEntity = _repository.Create(LivroEntity);
            return _converter.Parse(LivroEntity);
        }

        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        public List<LivroVO> FindAll()
        {
           return _converter.Parse(_repository.FindAll());  
        }

        public LivroVO FindById(long Id)
        {
           return _converter.Parse(_repository.FindById(Id));
        }

        public LivroVO Update(LivroVO livro)
        {
            var LivroEntity = _converter.Parse(livro);
            LivroEntity = _repository.Update(LivroEntity);
            return _converter.Parse(LivroEntity);
        }
    }
}
