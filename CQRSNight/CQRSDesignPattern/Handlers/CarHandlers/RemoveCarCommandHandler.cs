using CQRSNight.CQRSDesignPattern.Commands.CarCommands;
using CQRSNight.Dal.Context;

namespace CQRSNight.CQRSDesignPattern.Handlers.CarHandlers
{
    public class RemoveCarCommandHandler
    {
        private readonly CQRSContext _context;
        public RemoveCarCommandHandler(CQRSContext context)
        {
            _context = context;
        }
        public void Handle(RemoveCarCommand command)
        {
            var vv = _context.Cars.Find(command.Id);
            _context.Cars.Remove(vv);
            _context.SaveChanges();
        }
    }
}
