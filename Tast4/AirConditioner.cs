using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class AirConditioner : Appliance,ISchedulable
    {
       public double TargetTemperature { get; set; }
        public AirConditioner(string brand, string room) : base(brand, room)
        {
        }

        public DateTime NextRun { get; set; }

        public override double GetDailyEnergyUsage() => 10;

        public override string GetInfo()
        {
            TargetTemperature = 3.6;
            return $"{TargetTemperature} {base.GetInfo()}";
        }

        public override void TurnOn()
        {
            Console.WriteLine("Air conditioner is cooling to target temperature.");
            IsOn = true;
        }
        public override void TurnOff()
        {
            Console.WriteLine("Air conditioner is off.");

            IsOn = false;
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
