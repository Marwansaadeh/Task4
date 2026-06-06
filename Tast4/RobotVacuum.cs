using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class RobotVacuum : Appliance, ISchedulable
    {
        public RobotVacuum(string brand, string room) : base(brand, room) {
           
        }
       
        public double BatteryLevel { get; set; }
        public DateTime NextRun { get; set; }

        public void StartCleaning() => Console.WriteLine($"{Brand} Start cleaning.");
        public void StoptCleaning() => Console.WriteLine($"{Brand} stop Cleaning");
        public void PrintCleaningEnergy()
        {
            Console.WriteLine($"{Brand} robot vacuum uses 0.4 kWh per cleaning.");
        }
        public override double GetDailyEnergyUsage() => 0.5;

        public override string GetInfo()
        {
            BatteryLevel = 0.4;
            return $"{BatteryLevel} {base.GetInfo()}";
        }
        public override void TurnOn()
        {
            IsOn = true;
            StartCleaning();
        }
        public override void TurnOff()
        {
            IsOn = false;
            StoptCleaning();
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
