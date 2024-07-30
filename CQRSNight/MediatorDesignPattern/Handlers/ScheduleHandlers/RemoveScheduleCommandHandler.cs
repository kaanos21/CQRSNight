using CQRSNight.Dal.Context;
using CQRSNight.MediatorDesignPattern.Commands;
using CQRSNight.MediatorDesignPattern.Commands.ScheduleCommands;
using MediatR;

namespace CQRSNight.MediatorDesignPattern.Handlers.ScheduleHandlers
{
    public class RemoveScheduleCommandHandler : IRequestHandler<RemoveScheduleCommand>
    {
        private readonly CQRSContext _context;

        public RemoveScheduleCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveScheduleCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Schdules.FindAsync(request.Id);
            _context.Schdules.Remove(value);
            await _context.SaveChangesAsync();
        }
    
    }
}
