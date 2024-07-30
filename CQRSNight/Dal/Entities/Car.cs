using Microsoft.CodeAnalysis;

namespace CQRSNight.Dal.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int LocationId { get; set; }
        public string Color { get; set; }
        public int Km { get; set; }
        public int Seat { get; set; }
        public int ProductionYear { get; set; }
        public int Price { get; set; }
        public string Transmission { get; set; }
        public Location? Location { get; set; }
        public Brand? Brand { get; set; }
        public List<Schdule> Schdules { get; set; }
    }
}
