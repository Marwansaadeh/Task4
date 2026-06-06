using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class CoffeeMachine : Appliance
    {
        public CoffeeMachine(string brand, string room) : base(brand, room) {
        }
        public double CupsPerBrew { get; set; }
        public void StartBrewing() => Console.WriteLine("Startar kaffebryggning ");
        public void StopBrewing() => Console.WriteLine("Stoppar kaffebryggning");
        public void PrintBrewingEnergy() => Console.WriteLine($"Energiförbrukning: {CupsPerBrew} Wh");
        public override double GetDailyEnergyUsage() => 1.2;

        public override string GetInfo()
        {
            CupsPerBrew = 0.3;
            return $"{CupsPerBrew} {base.GetInfo()}";
        }
        public override void TurnOn()
        {
            IsOn = true;
            StartBrewing();
        }
        public override void TurnOff()
        {
            IsOn = false;
            StopBrewing();
        }
    }
}
