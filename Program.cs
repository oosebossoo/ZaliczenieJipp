using ConsoleApp1.Builders;
using ConsoleApp1.Models;
using ConsoleApp1.Repositories;

// ---------
// ZADANIE 3
// ---------

BaseRepository baseRepository = new BaseRepository();

AirConditioningRepository airConditioningRepository = new AirConditioningRepository(baseRepository);
HeaterRepository heaterRepository = new HeaterRepository(baseRepository);

//    Light device1 = new Light(baseRepository.GetAll().Count() + 1, "bath_room_light_1", "indoor", 0, 0, "FFFFFF", 255);
//    baseRepository.Add(device1);

//    AirConditioning device2 = new AirConditioning(baseRepository.GetAll().Count() + 1, "living_room_ac_1", "indoor", 0, 0, 1, 22, 2, 2);
//    baseRepository.Add(device2);

//    Heater device3 = new Heater(baseRepository.GetAll().Count() + 1, "living_room_ac_1", "indoor", 0, 0, 25, 0);
//    baseRepository.Add(device3);

//    Console.WriteLine($"device amount: {baseRepository.GetAll().Count}");

//    Console.WriteLine("old directions");
//    Console.WriteLine($"x: {airConditioningRepository.GetAllAirConditioning().First().DirectionX}");
//    Console.WriteLine($"y: {airConditioningRepository.GetAllAirConditioning().First().DirectionY}");

//    airConditioningRepository.changeDirection(device2.Id, 10, 10);

//    Console.WriteLine("new directions");
//    Console.WriteLine($"x: {device2.DirectionX}");
//    Console.WriteLine($"y: {device2.DirectionY}");
//}

// ---------
// ZADANIE 4
// ---------
//ACDirector director = new ACDirector();
//ACBuilder acBuilder = new ACBuilder();

//director.SetBuilder(acBuilder);
//director.ConstructReport();
//AirConditioning ac = (director.GetDevice() as AirConditioning);

//HeaterDirector directorH = new HeaterDirector();
//HeaterBuilder hBuilder = new HeaterBuilder();

//directorH.SetBuilder(hBuilder);
//directorH.ConstructReport();
//Heater heater = (directorH.GetDevice() as Heater);

//Console.WriteLine(ac.Name + " - " + ac.Type);
//Console.WriteLine(heater.Name + " - " + heater.Type);

// --------
// Projekct
// --------


int input;
while (true)
{
    input = Convert.ToInt32(Console.ReadKey());

    Console.WriteLine("1 - lista urządzeń");
    Console.WriteLine("2 - wybierz urządzenie");
    Console.WriteLine("2 - dodaj urządzenie");
    Console.WriteLine("3 - usuń urządzenie");
    Console.WriteLine("0 - wyjdź z programu");

    if (input == 1)
    {

    }
    if (input == 2)
    {

    }
    if (input == 3)
    {

    }
    if (input == 4)
    {

    }
    if (input < 0)
        break;
}