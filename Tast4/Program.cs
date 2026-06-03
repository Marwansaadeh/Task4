using Task4;

Console.WriteLine("Hello, World!");
List<object> device = new List<object>()
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
    }
};

{
    List<object> devices = new List<object>();

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