namespace CQRSNight.CQRSDesignPattern.Commands.BrandCommands
{
    public class RemoveBrandCommand
    {
        public RemoveBrandCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
