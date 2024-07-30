using MediatR;

namespace CQRSNight.MediatorDesignPattern.Commands.ScheduleCommands
{
    public class RemoveScheduleCommand :IRequest
    {
        public RemoveScheduleCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
