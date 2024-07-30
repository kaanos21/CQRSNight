using CQRSNight.CQRSDesignPattern.Queries.CarQueries;
using CQRSNight.CQRSDesignPattern.Results.CarResults;
using CQRSNight.Dal.Context;

namespace CQRSNight.CQRSDesignPattern.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly CQRSContext _context;

        public GetCarByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public GetCarByIdQueryResult Handle(GetCarByIdQuery query)
        {
            var value = _context.Cars.Find(query.Id);
            return new GetCarByIdQueryResult
            {
               Transmission=value.Transmission,
               Seat=value.Seat,
               Color=value.Color,
               Km=value.Km,
               ProductionYear=value.ProductionYear,
               Price=value.Price,
               Id=value.Id,
               BrandId=value.BrandId,
               LocaionId=value.LocationId,
            };

        }
    }
}
