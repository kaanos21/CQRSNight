using CQRSNight.CQRSDesignPattern.Results.BrandResults;
using CQRSNight.Dal.Context;

namespace CQRSNight.CQRSDesignPattern.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler
    {
        private readonly CQRSContext _context;

        public GetBrandQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public List<GetBrandQueryResult> Handle()
        {
            var values = _context.Brands.Select(x => new GetBrandQueryResult
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
            return values;
        }
    }
}
