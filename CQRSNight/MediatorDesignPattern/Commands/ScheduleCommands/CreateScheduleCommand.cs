using MediatR;

namespace CQRSNight.MediatorDesignPattern.Commands.ScheduleCommands
{
    public class CreateScheduleCommand :IRequest
    {
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public int CarId { get; set; }
    }
}
