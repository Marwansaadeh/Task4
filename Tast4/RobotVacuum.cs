using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class RobotVacuum
    {
        public string Brand { get; set; }
        public double BatteryLevel { get; set; }
        public void StartCleaning() => Console.WriteLine($"{Brand} Start cleaning.");
        public void StoptCleaning() => Console.WriteLine($"{Brand} stop Cleaning");
        public void PrintCleaningEnergy()
        {
            Console.WriteLine($"{Brand} robot vacuum uses 0.4 kWh per cleaning.");

        }
    }
}
