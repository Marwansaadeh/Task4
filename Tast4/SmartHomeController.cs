using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Task4
{
    public class SmartHomeController
    {
        private List<Appliance> _devices = new List<Appliance>();

        public void AddDevice(Appliance device)
        {
            // TODO: 
            // Lägg till device i listan.
            _devices.Add(device);
        }

        public void TurnOnAll()
        {
            // TODO: 
            // Loopa igenom alla devices och starta dem. 
            // Du får inte använda if/switch på specifika klasser. 
            foreach (Appliance device in _devices)
            {
                device.TurnOn();
            }
        }

        public void TurnOffAll()
        {
            // TODO: 
            // Loopa igenom alla devices och stäng av dem. 
            foreach (Appliance device in _devices)
            {
                device.TurnOff();
            }
        }

        public void PrintStatusReport()
        {
            // TODO: 
            // Loopa igenom alla devices. 
            // Skriv ut GetInfo() och om apparaten är på eller av. 
            foreach (Appliance device in _devices)
            {
                string status = device.IsOn ? "On" : "Off";
                Console.WriteLine($"{device.GetInfo()} - Status: {status}");
            }
        }

        public double GetTotalDailyEnergyUsage()
        {
            // TODO: 
            // Räkna ihop GetDailyEnergyUsage() för alla devices. 
            // Returnera totalsumman. 
            return _devices.Sum(x => x.GetDailyEnergyUsage());
        }

        //public void ScheduleAllDevicesWrong(DateTime time)
        //{
        //    foreach (Appliance device in _devices)
        //    {
        //        _devices.Schedule(time);
        //    }
        //}
        // the above code doesn't work because _deveice list is the type of Appliance, and doesn't have the schedule method.

        public void ScheduleAllSchedulableDevices(DateTime time)
        {
            foreach (Appliance device in _devices)
            {
                // TODO: 
                // 1. Kontrollera om device implementerar ISchedulable. 
                // 2. Casta device till ISchedulable. 
                // 3. Anropa Schedule(time). 
                if (device is ISchedulable schedulable)
                {
                    schedulable.Schedule(time);
                }
            }
        }
        internal List<ISchedulable> GetSchedulableDevices()
        {

            List<ISchedulable> result = new List<ISchedulable>();
            foreach (Appliance device in _devices)
            {
                // TODO: 
                // Om device implementerar ISchedulable, 
                // lägg till det i result. 
                if(device is ISchedulable schedulable)
                result.Add(schedulable);
            }
            return result;
        }

        public Appliance FindDeviceByBrand(string brand)
        {
            return _devices.FirstOrDefault(x => x.Brand == brand) 
            ?? throw new KeyNotFoundException($"No device found with brand '{brand}'.");
        }

    }
}
