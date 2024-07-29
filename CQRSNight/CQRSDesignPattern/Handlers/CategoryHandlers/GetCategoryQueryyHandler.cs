using CQRSNight.CQRSDesignPattern.Results.CategoryResults;
using CQRSNight.Dal.Context;

namespace CQRSNight.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class GetCategoryQueryyHandler
    {
        private readonly CQRSContext _context;

        public GetCategoryQueryyHandler(CQRSContext context)
        {
            _context = context;
        }
        public List<GetCategoryQueryResult> Handle()
        {
            //deneme
            var values = _context.Categories.Select(x => new GetCategoryQueryResult
            {
                CategoryId = x.CategoryId,
            });
            return values.ToList();
        }
    }
}
