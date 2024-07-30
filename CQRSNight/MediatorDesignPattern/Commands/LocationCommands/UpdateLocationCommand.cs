using MediatR;

namespace CQRSNight.MediatorDesignPattern.Commands.LocationCommands
{
    public class UpdateLocationCommand:IRequest
    {
        public int Id { get; set; }
        public string Address { get; set; }
    }
}
