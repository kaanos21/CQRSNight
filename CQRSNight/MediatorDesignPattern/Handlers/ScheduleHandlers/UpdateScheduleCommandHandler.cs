using CQRSNight.Dal.Context;
using CQRSNight.MediatorDesignPattern.Commands;
using CQRSNight.MediatorDesignPattern.Commands.ScheduleCommands;
using MediatR;

namespace CQRSNight.MediatorDesignPattern.Handlers.ScheduleHandlers
{
    public class UpdateScheduleCommandHandler : IRequestHandler<UpdateScheduleCommand>
    {
        private readonly CQRSContext _context;

        public UpdateScheduleCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateScheduleCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Schdules.FindAsync(request.Id);
            value.DropOffDate=request.DropOffDate;
            value.PickUpDate=request.PickUpDate;
            value.CarId=request.CarId;
            await _context.SaveChangesAsync();
        }
    
    }
}
