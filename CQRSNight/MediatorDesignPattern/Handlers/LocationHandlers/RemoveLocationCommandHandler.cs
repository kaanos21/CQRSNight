using CQRSNight.Dal.Context;
using CQRSNight.MediatorDesignPattern.Commands.LocationCommands;
using MediatR;
using NuGet.Protocol.Plugins;

namespace CQRSNight.MediatorDesignPattern.Handlers.LocationHandlers
{
    public class RemoveLocationCommandHandler : IRequestHandler<RemoveLocationCommand>
    {
        private readonly CQRSContext _context;

        public RemoveLocationCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(RemoveLocationCommand request, CancellationToken cancellationToken)
        {
            var value = await _context.Locations.FindAsync(request.Id);
            _context.Locations.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
