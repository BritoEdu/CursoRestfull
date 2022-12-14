using CursoApiRestfull.Business;
using CursoApiRestfull.Hypermedia.Filters;
using CursoApiRestfull.Model;
using CursoApiRestfull.Repository;
using CursoApiRestfull.Repository.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CursoApiRestfull.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class LivroController : ControllerBase
    {
        private readonly ILogger<LivroController> _logger;
        private ILivroBusiness _iLivrosRepository;
        public LivroController(ILogger<LivroController> logger, ILivroBusiness iLivrosRepository)
        {
            _logger = logger;
            _iLivrosRepository = iLivrosRepository;
        }
        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_iLivrosRepository.FindAll());
        }

        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long Id)
        {
            var livro = _iLivrosRepository.FindById(Id);
            if (livro == null)
            {
                return NotFound();
            }
            return Ok(livro);
        }

        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] LivroVO livro)
        {
            if (livro == null) return BadRequest();
            return Ok(_iLivrosRepository.Create(livro));
        }

        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] LivroVO livro)
        {
            if (livro == null) return BadRequest();
            return Ok(_iLivrosRepository.Update(livro));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long Id)
        {
            _iLivrosRepository.Delete(Id);
            return NoContent();
        }
    }
}
