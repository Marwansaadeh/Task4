using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class Washer
    {
        public string Brand { get; set; }
        public double CapacityKg { get; set; }
        public void StartWash() =>Console.WriteLine($"{Brand} start washing");
        public void StoptWash() => Console.WriteLine($"{Brand} stop washing");
        public void PrintWashEnergy()
        {
            Console.WriteLine($"{Brand} washer uses 1.2 kWh per wash.");
        }
    }
}
