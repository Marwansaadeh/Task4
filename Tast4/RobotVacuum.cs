using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class RobotVacuum : Appliance
    {
        public RobotVacuum(string brand, string room) : base(brand, room) {
           
        }
       
        public double BatteryLevel { get; set; }
        public void StartCleaning() => Console.WriteLine($"{Brand} Start cleaning.");
        public void StoptCleaning() => Console.WriteLine($"{Brand} stop Cleaning");
        public void PrintCleaningEnergy()
        {
            Console.WriteLine($"{Brand} robot vacuum uses 0.4 kWh per cleaning.");
        }
        public override double GetDailyEnergyUsage() => 0.5;

        public override string GetInfo()
        {
            BatteryLevel = 0.4;
            return $"{BatteryLevel} {base.GetInfo()}";
        }
        public override void TurnOn()
        {
            IsOn = true;
            StartCleaning();
        }
        public override void TurnOff()
        {
            IsOn = false;
            StoptCleaning();
        }
    }
}
