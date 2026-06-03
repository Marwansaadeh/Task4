using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class CoffeeMachine
    {
        public string Brand { get; set; }
        public double CupsPerBrew { get; set; }
        public void StartBrewing() => Console.WriteLine("Startar kaffebryggning ");
        public void StopBrewing() => Console.WriteLine("Stoppar kaffebryggning");
        public void PrintBrewingEnergy() => Console.WriteLine($"Energiförbrukning: {CupsPerBrew} Wh");
    }
}
