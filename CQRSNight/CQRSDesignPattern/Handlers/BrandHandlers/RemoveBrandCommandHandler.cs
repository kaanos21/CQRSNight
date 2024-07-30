using CQRSNight.CQRSDesignPattern.Commands.BrandCommands;
using CQRSNight.Dal.Context;

namespace CQRSNight.CQRSDesignPattern.Handlers.BrandHandlers
{
    public class RemoveBrandCommandHandler
    {
        private readonly CQRSContext _context;
        public RemoveBrandCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(RemoveBrandCommand command)
        {
            var vv = _context.Brands.Find(command.Id);
            _context.Brands.Remove(vv);
            _context.SaveChanges();
        }
    }
}
