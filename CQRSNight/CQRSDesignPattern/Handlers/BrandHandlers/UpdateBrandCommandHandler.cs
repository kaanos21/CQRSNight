using CQRSNight.CQRSDesignPattern.Commands.BrandCommands;
using CQRSNight.Dal.Context;

namespace CQRSNight.CQRSDesignPattern.Handlers.BrandHandlers
{
    public class UpdateBrandCommandHandler
    {
        private readonly CQRSContext _context;
        public UpdateBrandCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(UpdateBrandCommand command)
        {
            var values = _context.Brands.Find(command.Id);
            values.Name = command.Name;
            _context.SaveChanges();
        }
    }
}
