using CQRSNight.CQRSDesignPattern.Commands.BrandCommands;
using CQRSNight.Dal.Context;
using CQRSNight.Dal.Entities;

namespace CQRSNight.CQRSDesignPattern.Handlers.BrandHandlers
{
    public class CreateBrandCommandHandler
    {
        private readonly CQRSContext _context;

        public CreateBrandCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(CreateBrandCommand command)
        {
            _context.Brands.Add(new Brand
            {
                Name = command.Name,
            });
            _context.SaveChanges();
        }
    }
}
