﻿namespace CQRSNight.CQRSDesignPattern.Commands.CarCommands
{
    public class CreateCarCommand
    {
        public int BrandId { get; set; }
        public int LocaionId { get; set; }
        public string Color { get; set; }
        public int Km { get; set; }
        public int Seat { get; set; }
        public int ProductionYear { get; set; }
        public int Price { get; set; }
        public string Transmission { get; set; }
    }
}
