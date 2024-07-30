namespace CQRSNight.CQRSDesignPattern.Commands.CarCommands
{
    public class RemoveCarCommand
    {
        public RemoveCarCommand(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
