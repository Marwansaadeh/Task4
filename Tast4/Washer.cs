using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class Washer: Appliance
    {
        public Washer(string brand, string room) :base(brand,room)
        {
           
        }
       
        public double CapacityKg { get; set; }
        public void StartWash() =>Console.WriteLine($"{Brand} start washing");
        public void StoptWash() => Console.WriteLine($"{Brand} stop washing");
        public void PrintWashEnergy()
        {
            Console.WriteLine($"{Brand} washer uses 1.2 kWh per wash.");
        }
        public override double GetDailyEnergyUsage() => 1.2;
       
        public override string GetInfo()
        {
            CapacityKg = 1.2;
            return $"{CapacityKg} {base.GetInfo()}";
        } 
        
        public override void TurnOn()
        {
            IsOn = true;
            StartWash();
        }
        public override void TurnOff()
        {
            IsOn = false;
            StoptWash();
        }
    }
}
