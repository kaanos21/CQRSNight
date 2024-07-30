using CQRSNight.Dal.Context;
using CQRSNight.Dal.Entities;
using CQRSNight.MediatorDesignPattern.Queries.CarFilterQueries;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSNight.MediatorDesignPattern.Handlers.CarFilterHandlers
{
    public class GetCarWithFilterQueryHandler : IRequestHandler<GetCarWithFilterQuery, List<Car>>
    {
        private readonly CQRSContext _context;

        public GetCarWithFilterQueryHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task<List<Car>> Handle(GetCarWithFilterQuery request, CancellationToken cancellationToken)
        {
            var cars = await _context.Cars
                .Include(x => x.Schdules).Include(x=>x.Brand).Include(x=>x.Location)
                .Where(x => x.LocationId == request.PickUpLocationId &&
                            x.Schdules.Any(s => s.PickUpDate <= request.PickUpDate && s.DropOffDate >= request.DropOffDate))
                .ToListAsync(cancellationToken);

            return cars;
        }
    }
}
