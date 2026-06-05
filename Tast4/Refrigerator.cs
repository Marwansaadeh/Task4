using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class Refrigerator : Appliance
    {
        public Refrigerator(string brand, string room) : base(brand, room) {
            Brand = brand;
        }
        public Refrigerator() { }
        public string Brand { get; set; }
        public double Temperature { get; set; }
        public void StartCooling() => Console.WriteLine($"{Brand} Start cooling");
        public void StoptCooling() => Console.WriteLine($"{Brand} stop cooling");
        public void PrintCoolingEnergy()
        {
            Console.WriteLine($"{Brand} refrigerator uses 3.6 kWh per day.");

        }
        public override double GetDailyEnergyUsage() => 3.9;

        public override string GetInfo() => $"{Brand} refrigerator {Temperature} kWh per day, It is loocated in {Room}";

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
