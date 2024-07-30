using CQRSNight.Dal.Context;
using CQRSNight.Dal.Entities;
using CQRSNight.MediatorDesignPattern.Commands.ScheduleCommands;
using MediatR;

namespace CQRSNight.MediatorDesignPattern.Handlers.ScheduleHandlers
{
    public class CreateScheduleCommandHandler : IRequestHandler<CreateScheduleCommand>
    {
        private readonly CQRSContext _context;

        public CreateScheduleCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public async Task Handle(CreateScheduleCommand request, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Schdule
            {
                PickUpDate = request.PickUpDate,
                DropOffDate = request.DropOffDate,
                CarId = request.CarId,
            });
            await _context.SaveChangesAsync();
        }
    }
}
