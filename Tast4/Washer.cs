using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class Washer: Appliance, ISchedulable
    {
        public Washer(string brand, string room) :base(brand,room)
        {
           
        }
       
        public double CapacityKg { get; set; }
        public DateTime NextRun { get;  set;}

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

        public void TurnOn()
        {
            IsOn = true;
            StartWash();
        }
        // It give me warining that this hides the inherited member from base class.The c# understand that I am hiding the base class method and want to use the derived class method, wants me to know what I am doing.
        public override void TurnOff()
        {
            IsOn = false;
            StoptWash();
        }

        public void Schedule(DateTime time)
        {
            if (time <= DateTime.Now)
            {
                Console.WriteLine("Scheduled time must be in the future.");
                return;
            }
            else if (IsOn)
            {
                Console.WriteLine($"Cannot schedule while the  {GetType().Name} is on.");
                return;
            }
            else
            {
                NextRun = time;
                Console.WriteLine($" {GetType().Name} scheduled to start brewing at {NextRun}.");
            }
        }
    }
}
