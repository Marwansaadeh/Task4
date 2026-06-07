using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class Appliance
    {
        public string Brand { get; }
        public string Room { get; }
        public bool IsOn { get; protected set; }

        public Appliance(string brand, string room)
        {
            // TODO: 
            // Sätt Brand, Room och IsOn.
            Brand=brand;
            Room=room;
            IsOn =false;
        }
        public Appliance()
        {
            
        }

        public virtual string GetInfo()
        {
            // TODO: 
            // Returnera en generell text om apparaten. 
            // Exempel: "LG in Laundry room" 
            return $"{Brand} in {Room}";
        }

        public void TurnOn()
        {
            // TODO: 
            // Sätt IsOn till true. 
            // Skriv ut ett generellt startmeddelande.
            IsOn = true;
            Console.WriteLine($"Turning on {Brand} in {Room}.");
        }
        // when I change from vitual to non-virtual, I get a compile error in the child class because it is trying to override a non-virtual method.

        public virtual void TurnOff()
        {
            // TODO: 
            // Sätt IsOn till false. 
            // Skriv ut ett generellt stoppmeddelande.
            IsOn = false;
            Console.WriteLine($"Turning off {Brand} in {Room}.");
        }

        public virtual double GetDailyEnergyUsage()
        {
            // TODO: 
            // Returnera 0 som standardvärde. 
            return 0;
        }
    }
}
