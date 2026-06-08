using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class PizzaOven : Oven
    {
        public PizzaOven(string brand, string room, int maxTemperature):base(brand, room, maxTemperature)
        {
            
        }
        
        public override void TurnOn()
        {
            Console.WriteLine("Pizza oven starts at extra high temperature.");
        }

        //1.  Vad säger kompilatorn? 
        // there is no contractor in the base class that takes three parameters, and the TurnOn method is sealed in the base class, so it cannot be overridden in the derived class.
        //2.  Varför får PizzaOven inte override:a TurnOn()? 
        // Beacuse TurnOn method is seald in Oven Class, we can assume that maxtemperature should not be more for example, that is why it is seald, no overriding.
        //3.  När kan det vara rimligt att använda sealed override? 
        // As I said above when we don't want the derived class to override the base class for a goal reason.
        //4.  Vad kan PizzaOven fortfarande göra i stället? Kan den override:a någon annan metod?
        // methods that is seald, ovverride, but normal methods, wa can add new keyword in the method in pizzaoven class in order to override it in this class.

    }
}
