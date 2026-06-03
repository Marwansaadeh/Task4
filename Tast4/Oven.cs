using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class Oven
    {
        public string Brand { get; set; }
        public double MaxTemperature { get; set; }
        public void StartHeating() => Console.WriteLine($"{Brand} Start heating.");
        public void StoptHeating() => Console.WriteLine($"{Brand} stop heating");
        public void PrintHeatingEnergy()
        {
            Console.WriteLine($"{ Brand} oven uses 2.5 kWh per hour.");
        }
    }
}
