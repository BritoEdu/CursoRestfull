using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CursoApiRestfull.Hypermedia.Filters
{
    public class HyperMediaFilter : ResultFilterAttribute
    {
        private readonly HyperMediaFilterOptions _hypermediaFiltersOptions;

        public HyperMediaFilter(HyperMediaFilterOptions hypermediaFiltersOptions)
        {
            _hypermediaFiltersOptions = hypermediaFiltersOptions;   

        }
        public override void OnResultExecuting(ResultExecutingContext context)
        {
            TryEnrichResult(context);
            base.OnResultExecuting(context);
        }

        private void TryEnrichResult(ResultExecutingContext context)
        {
            if (context.Result is OkObjectResult okObjectResult)
            {
                var enricher = _hypermediaFiltersOptions
                    .ContentResponseEnricherList
                    .FirstOrDefault(d => d.CanEnrich(context));
                if (enricher != null) Task.FromResult(enricher.Enrich(context));
            }

        }
    }
}
