using MediatR;

namespace CQRSNight.MediatorDesignPattern.Commands.LocationCommands
{
    public class CreateLocationCommand :IRequest
    {
        public int Id { get; set; }
        public string Address { get; set; }
    }
}
