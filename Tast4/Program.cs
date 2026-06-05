using Task4;
{
    List<object> devices = new List<object>()
    {
    new Oven
    {
        Brand = "Bosch",
        MaxTemperature = 275.0
    },

    new Refrigerator
    {
        Brand = "Samsung",
        Temperature = 4.0
    },

    new RobotVacuum
    {
        Brand = "Roborock",
        BatteryLevel = 85
    },

    new Washer
    {
        Brand = "LG",
        CapacityKg = 9
    },
    new CoffeeMachine
    {
    Brand = "Moccamaster",
    CupsPerBrew = 8
    }

    };
    // TODO: 
    // Skapa minst fyra objekt: 
    // Washer, Refrigerator, Oven och RobotVacuum. 
    // Lägg till dem i listan devices. 

    RunMorningRoutine(devices);

    Console.WriteLine();

    ReportAllEnergy(devices);
}

static void RunMorningRoutine(List<object> devices)
{
    foreach (object device in devices)
    {
        // TODO: 
        // 1. Kontrollera vilken typ device är. 
        // 2. Casta till rätt typ. 
        // 3. Anropa rätt startmetod. 
        // 4. Anropa rätt stoppmetod. 

        if (device is Oven)
        {
            Oven? oven = device as Oven;
            if (oven != null)
            {
                oven.StartHeating();
                oven.StoptHeating();
            }
        }

        else if (device is Refrigerator)
        {
            Refrigerator? refrigerator = device as Refrigerator;
            if (refrigerator != null)
            {
                refrigerator.StartCooling();
                refrigerator.StoptCooling();
            }
        }

        else if (device is RobotVacuum)
        {
            RobotVacuum? robotVacuum = device as RobotVacuum;
            if (robotVacuum != null)
            {
                robotVacuum.StartCleaning();
                robotVacuum.StoptCleaning();
            }
        }

        else if (device is Washer)
        {
            Washer? washer = device as Washer;
            if (washer != null)
            {
                washer.StartWash();
                washer.StoptWash();
            }
        }
    }
}

static void ReportAllEnergy(List<object> devices)
{
    foreach (object device in devices)
    {
        // TODO: 
        // 1. Kontrollera vilken typ device är. 
        // 2. Casta till rätt typ. 
        // 3. Anropa rätt energimetod. 
        if (device is Refrigerator refrigerator)
        {
            refrigerator.PrintCoolingEnergy();
        }
        else if (device is Oven oven)
        {
            oven.PrintHeatingEnergy();
        }
        else if (device is RobotVacuum robotVacuum)
        {
            robotVacuum.PrintCleaningEnergy();
        }
        else if (device is Washer washer)
        {
            washer.PrintWashEnergy();
        }
    }
}

//1.Varför behövde du kontrollera vilken typ varje objekt hade? 
// To check which type of object it is, so that we can cast it to the correct type and call the appropriate methods for that type. 
//2.  Vad händer om du lägger till en ny klass CoffeeMachine? 
// We need to update exsisting code to print the methods, and it will consume memory when we loop because no type matches.

//3.  Vilka metoder måste du ändra om du lägger till CoffeeMachine? 
// both RunMorningRoutine and ReportAllEnergy methods need to be updated to include the new CoffeeMachine class.

//4.  Vad är problemet med att listan är List<object>? 
// we need to check type of each object and cast it to the correct type before we call the methods.

//5.  Vad händer om du råkar glömma en apparattyp i ReportAllEnergy()?
// It will not report the energy usage for that device type, and it may lead to incomplete or inaccurate energy reporting.

//.........................
// När jag lade till CoffeeMachine behövde jag ändra i RunMorningRoutine och ReportAllEnergy metoderna för att inkludera den nya klassen. I RunMorningRoutine behövde jag lägga till en ny else if-sats för att kontrollera om device är av typen CoffeeMachine, och sedan casta det till CoffeeMachine och anropa start och stopp metoderna. I ReportAllEnergy behövde jag också lägga till en else if-sats för att kontrollera om device är av typen CoffeeMachine, och sedan casta det till CoffeeMachine och anropa PrintBrewEnergy metoden.

Console.WriteLine(".........................");

Console.WriteLine("Adding new device to used inhertence");
Console.WriteLine();
List<Appliance> newDevices = new List<Appliance>()
{
    new Oven("Bosch", "Kitchen"),
    new Refrigerator("Samsung", "Kitchen"),
    new RobotVacuum("Roborock", "Living Room"),
    new Washer("LG", "Laundry Room"),
    new CoffeeMachine("Moccamaster", "Kitchen")
};

foreach (Appliance device in newDevices)
{
    Console.WriteLine (device.GetInfo());
    device.TurnOn();
    Console.WriteLine(device.GetDailyEnergyUsage());
    device.TurnOff();
    Console.WriteLine(".........................");
}

//1.Varför fungerar device.TurnOn() trots att device har typen Appliance? 
// Because the types(derived classes) is inherited from the base class(Appliance), on the run time it will check the actual type and execute the appropriate method.
//2.  Vilken metod körs om objektet egentligen är en RobotVacuum? 
// The TurnOn method of the RobotVacuum, because we override this method, it will check the actual type of the object at runtime and call the appropriate method for that type, even though the variable is of type Appliance.
//3.  Vad blev bättre jämfört med List<object>?
// we don't need to check the type of each object and cast it to the correct type before calling the methods, we can directly call the methods defined in the base class and it will automatically call the overridden methods in the derived classes. This makes the code cleaner and more maintainable.

