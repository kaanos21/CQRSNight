using CQRSNight.Dal.Context;
using CQRSNight.MediatorDesignPattern.Queries.LocationQueries;
using CQRSNight.MediatorDesignPattern.Results.LocationResult;
using MediatR;
using NuGet.Protocol.Plugins;

namespace CQRSNight.MediatorDesignPattern.Handlers.LocationHandlers
{
    public class GetLocatonByIdQueryHandler:IRequestHandler<GetLocationByIdQuery,GetLocationByIdQueryResult>
    {
        private readonly CQRSContext _context;

        public GetLocatonByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<GetLocationByIdQueryResult> Handle(GetLocationByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Locations.FindAsync(request.Id);
            return new GetLocationByIdQueryResult
            {
                Id = values.Id,
                Address = values.Address
            };
        }
    }
}
