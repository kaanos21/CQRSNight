using CQRSNight.CQRSDesignPattern.Queries.BrandQueries;
using CQRSNight.CQRSDesignPattern.Results.BrandResults;
using CQRSNight.Dal.Context;

namespace CQRSNight.CQRSDesignPattern.Handlers.BrandHandlers
{
    public class GetBrandByIdQueryHandler
    {
        private readonly CQRSContext _context;

        public GetBrandByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public GetBrandByIdQueryResult Handle(GetBrandByIdQuery query)
        {
            var value = _context.Brands.Find(query.Id);
            return new GetBrandByIdQueryResult
            {
                Id = value.Id,
                Name=value.Name,
            };

        }
    }
}
