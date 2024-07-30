using CQRSNight.CQRSDesignPattern.Commands.CarCommands;
using CQRSNight.Dal.Context;

namespace CQRSNight.CQRSDesignPattern.Handlers.CarHandlers
{
    public class UpdateCarCommandHandler
    {
        private readonly CQRSContext _context;
        public UpdateCarCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(UpdateCarCommand command)
        {
            var values = _context.Cars.Find(command.Id);
            values.Km=command.Km;
            values.Seat=command.Seat;
            values.Price=command.Price;
            values.Transmission=command.Transmission;
            values.Color=command.Color;
            values.BrandId=command.BrandId;
            values.LocationId=command.LocaionId;
            values.ProductionYear=command.ProductionYear;
            _context.SaveChanges();
        }
    }
}
