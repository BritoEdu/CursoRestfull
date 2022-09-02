using Microsoft.AspNetCore.Mvc.Filters;

namespace CursoApiRestfull.Hypermedia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutingContext context);
        Task Enrich(ResultExecutingContext context);

    }
}
