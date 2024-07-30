using CQRSNight.Dal.Context;
using CQRSNight.MediatorDesignPattern.Commands.LocationCommands;
using CQRSNight.MediatorDesignPattern.Commands.ScheduleCommands;
using MediatR;

namespace CQRSNight.MediatorDesignPattern.Handlers.LocationHandlers
{
    public class UpdateLocationCommandHandler : IRequestHandler<UpdateLocationCommand>
    {
        private readonly CQRSContext _context;

        public UpdateLocationCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Locations.FindAsync(request.Id);
            value.Address= request.Address;
            await _context.SaveChangesAsync();
        }
    }
}
