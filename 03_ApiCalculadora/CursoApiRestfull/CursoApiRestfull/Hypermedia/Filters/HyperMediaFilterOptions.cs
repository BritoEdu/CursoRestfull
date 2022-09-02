using CursoApiRestfull.Hypermedia.Abstract;

namespace CursoApiRestfull.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();   
    }
}
