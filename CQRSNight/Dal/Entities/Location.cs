namespace CQRSNight.Dal.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public List<Car> Cars { get; set; }
    }
}
