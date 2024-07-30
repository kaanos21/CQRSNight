using CQRSNight.CQRSDesignPattern.Commands.CarCommands;
using CQRSNight.Dal.Context;
using CQRSNight.Dal.Entities;

namespace CQRSNight.CQRSDesignPattern.Handlers.CarHandlers
{
    public class CreateCarCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateCarCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(CreateCarCommand command)
        {
            _context.Cars.Add(new Car
            {
                Km = command.Km,
                Color = command.Color,
                Seat = command.Seat,
                ProductionYear = command.ProductionYear,
                Price = command.Price,
                Transmission=command.Transmission,
                BrandId = command.BrandId,
                LocationId=command.LocaionId,
            });
            _context.SaveChanges();
        }
    }
}
