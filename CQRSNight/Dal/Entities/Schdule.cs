namespace CQRSNight.Dal.Entities
{
    public class Schdule
    {
        public int Id { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public int CarId { get; set; }
        public Car Cars { get; set; }
    }
}
