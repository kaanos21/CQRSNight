using CQRSNight.Dal.Context;
using CQRSNight.MediatorDesignPattern.Queries.ScheduleQueries;
using CQRSNight.MediatorDesignPattern.Results;
using CQRSNight.MediatorDesignPattern.Results.ScheduleResult;
using MediatR;

namespace CQRSNight.MediatorDesignPattern.Handlers.ScheduleHandlers
{
    public class GetScheduleByIdQueryHandler : IRequestHandler<GetScheduleByIdQuery, GetScheduleByIdQueryResult>
    {
        private readonly CQRSContext _context;

        public GetScheduleByIdQueryHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task<GetScheduleByIdQueryResult> Handle(GetScheduleByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Schdules.FindAsync(request.Id);
            return new GetScheduleByIdQueryResult
            {
                Id = values.Id,
                CarId = values.CarId,
                DropOffDate = values.DropOffDate,
                PickUpDate = values.PickUpDate,
            };
        }
    }
}
