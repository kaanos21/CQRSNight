using CQRSNight.CQRSDesignPattern.Results.CarResults;
using CQRSNight.Dal.Context;

namespace CQRSNight.CQRSDesignPattern.Handlers.CarHandlers
{
    public class GetCarQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCarQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public List<GetCarQueryResult> Handle()
        {
            var values = _context.Cars.Select(x => new GetCarQueryResult
            {
                Id = x.Id,
                Km = x.Km,
                Transmission = x.Transmission,
                Price = x.Price,
                ProductionYear = x.ProductionYear,
                Color = x.Color,
                Seat = x.Seat,
                BrandId = x.BrandId,
                LocaionId=x.LocationId,
            }).ToList();
            return values;
        }
    }
}
