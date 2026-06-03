using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class Refrigerator
    {
        public string Brand { get; set; }
        public double Temperature { get; set; }
        public void StartCooling() => Console.WriteLine($"{Brand} Start cooling");
        public void StoptCooling() => Console.WriteLine($"{Brand} stop cooling");
        public void PrintCoolingEnergy()
        {
            Console.WriteLine($"{Brand} refrigerator uses 3.6 kWh per day.");

        }

    }
}
