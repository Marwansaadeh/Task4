using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class Oven : Appliance
    {
        public Oven(string brand, string room): base(brand, room) 
        {
        }
        
        public double MaxTemperature { get; set; }
        public void StartHeating() => Console.WriteLine($"{Brand} Start heating.");
        public void StoptHeating() => Console.WriteLine($"{Brand} stop heating");
        public void PrintHeatingEnergy()
        {
            Console.WriteLine($"{ Brand} oven uses 2.5 kWh per hour.");
        }
        public override double GetDailyEnergyUsage() => 1.2;

        public override string GetInfo()
        {
            MaxTemperature = 2.5;
            return $"{MaxTemperature} {base.GetInfo()}";
        }
        public sealed override void TurnOn()
        {
            IsOn = true;
            StartHeating();
        }
        public override void TurnOff()
        {
            IsOn = false;
            StoptHeating();
        }
    }
}
