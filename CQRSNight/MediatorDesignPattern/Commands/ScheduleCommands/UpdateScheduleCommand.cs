using MediatR;

namespace CQRSNight.MediatorDesignPattern.Commands.ScheduleCommands
{
    public class UpdateScheduleCommand:IRequest
    {
        public int Id { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public int CarId { get; set; }
    }
}
