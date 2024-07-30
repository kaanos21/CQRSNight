using MediatR;

namespace CQRSNight.MediatorDesignPattern.Commands.LocationCommands
{
    public class RemoveLocationCommand:IRequest
    {
        public RemoveLocationCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
