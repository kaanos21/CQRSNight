using CQRSNight.Dal.Context;
using CQRSNight.MediatorDesignPattern.Queries.ScheduleQueries;
using CQRSNight.MediatorDesignPattern.Results;
using CQRSNight.MediatorDesignPattern.Results.ScheduleResult;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CQRSNight.MediatorDesignPattern.Handlers.ScheduleHandlers
{
    public class GetScheduleQueryHandler : IRequestHandler<GetScheduleQuery, List<GetScheduleQueryResult>>
    {
        private readonly CQRSContext _context;

        public GetScheduleQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task<List<GetScheduleQueryResult>> Handle(GetScheduleQuery request, CancellationToken cancellationToken)
        {
            return await _context.Schdules.Select(x => new GetScheduleQueryResult
            {
                DropOffDate = x.DropOffDate,
                PickUpDate = x.PickUpDate,
                CarId = x.CarId,
                Id = x.Id,
            }).ToListAsync();
        }
    }
}
