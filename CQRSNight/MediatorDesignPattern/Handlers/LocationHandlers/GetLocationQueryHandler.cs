using CQRSNight.Dal.Context;
using CQRSNight.MediatorDesignPattern.Queries.LocationQueries;
using CQRSNight.MediatorDesignPattern.Results.LocationResult;
using CQRSNight.MediatorDesignPattern.Results.ScheduleResult;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSNight.MediatorDesignPattern.Handlers.LocationHandlers
{
    public class GetLocationQueryHandler:IRequestHandler<GetLocationQuery,List<GetLocationQueryResult>>
    {
        private readonly CQRSContext _context;

        public GetLocationQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
        {
            return await _context.Locations.Select(x => new GetLocationQueryResult
            {
                Address = x.Address,
                Id = x.Id,
            }).ToListAsync();
        }
    }
}
