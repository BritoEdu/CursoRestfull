using CursoApiRestfull.Hypermedia;
using CursoApiRestfull.Hypermedia.Abstract;

namespace CursoApiRestfull.Data.VO;

public class PersonVO : ISupportsHyperMedia
{

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Endereço { get; set; }

        public string Genero { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }

