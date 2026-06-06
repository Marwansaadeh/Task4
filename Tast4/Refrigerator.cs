using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class Refrigerator : Appliance
    {
        public Refrigerator(string brand, string room) : base(brand, room) {
            
        }
        
        public double Temperature { get; set; }
        public void StartCooling() => Console.WriteLine($"{Brand} Start cooling");
        public void StoptCooling() => Console.WriteLine($"{Brand} stop cooling");
        public void PrintCoolingEnergy()
        {
            Console.WriteLine($"{Brand} refrigerator uses 3.6 kWh per day.");

        }
        public override double GetDailyEnergyUsage() => 3.9;

        public override string GetInfo()
        {
            Temperature = 3.6;
            return $"{Temperature} {base.GetInfo()}";
        }

        public override void TurnOn()
        {
            IsOn = true;
            StartCooling();
        }
        public override void TurnOff()
        {
            IsOn = false;
            StoptCooling();
        }
    }
}
