namespace CQRSNight.MediatorDesignPattern.Results.ScheduleResult
{
    public class GetScheduleQueryResult
    {
        public int Id { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public int CarId { get; set; }
    }
}
