using CursoApiRestfull.Hypermedia.Abstract;
using CursoApiRestfull.Hypermedia;
using CursoApiRestfull.Model.Base;
using System.Text.Json.Serialization;

namespace CursoApiRestfull.Model
{
    public class LivroVO : ISupportsHyperMedia
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public decimal Preco { get; set; }

        public DateTime DataLancamento { get; set; }
        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}
