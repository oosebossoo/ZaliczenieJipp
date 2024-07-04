using ConsoleApp1.Models;
using ConsoleApp1.Repositories;

BaseRepository baseRepository = new BaseRepository();
AirConditioningRepository airConditioningRepository = new AirConditioningRepository(baseRepository);

Light device1 = new Light(baseRepository.GetAll().Count() + 1, "bath_room_light_1", "indoor", 0, 0, "FFFFFF", 255);
baseRepository.Add(device1);

AirConditioning device2 = new AirConditioning(baseRepository.GetAll().Count() + 1, "living_room_ac_1", "indoor", 0, 0, 1, 22, 2, 2);
baseRepository.Add(device2);

Heater device3 = new Heater(baseRepository.GetAll().Count() + 1, "living_room_ac_1", "indoor", 0, 0, 25, 0);
baseRepository.Add(device3);

Console.WriteLine($"device amount: {baseRepository.GetAll().Count}");

Console.WriteLine("old directions");
Console.WriteLine($"x: {airConditioningRepository.GetAllAirConditioning().First().DirectionX}");
Console.WriteLine($"y: {airConditioningRepository.GetAllAirConditioning().First().DirectionY}");

airConditioningRepository.changeDirection(device2.Id, 10, 10);

Console.WriteLine("new directions");
Console.WriteLine($"x: {device2.DirectionX}");
Console.WriteLine($"y: {device2.DirectionY}");

//int input;
//while (true)
//{
//    input = Convert.ToInt32(Console.ReadKey());
//    if (input < 0)
//        break;
//}