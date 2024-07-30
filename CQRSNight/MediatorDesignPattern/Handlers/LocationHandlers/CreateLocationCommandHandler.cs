using CQRSNight.Dal.Context;
using CQRSNight.Dal.Entities;
using CQRSNight.MediatorDesignPattern.Commands.LocationCommands;
using MediatR;

namespace CQRSNight.MediatorDesignPattern.Handlers.LocationHandlers
{
    public class CreateLocationCommandHandler:IRequestHandler<CreateLocationCommand>
    {
        private readonly CQRSContext _context;

        public CreateLocationCommandHandler(CQRSContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateLocationCommand request, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Location
            {
                Address = request.Address,
            });
            _context.SaveChanges();
        }
    }
}
