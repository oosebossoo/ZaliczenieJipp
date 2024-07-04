using ConsoleApp1.Builders;
using ConsoleApp1.Models;
using ConsoleApp1.Repositories;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Linq;

// ---------
// ZADANIE 3
// ---------

BaseRepository baseRepository = new BaseRepository();

AirConditioningRepository airConditioningRepository = new AirConditioningRepository(baseRepository);
HeaterRepository heaterRepository = new HeaterRepository(baseRepository);
LightRepository lightRepository = new LightRepository(baseRepository);

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
    Console.WriteLine("1 - lista urządzeń");
    Console.WriteLine("2 - wybierz urządzenie(in progress)");
    Console.WriteLine("3 - dodaj urządzenie");
    Console.WriteLine("4 - usuń urządzenie");
    Console.WriteLine("5 - wyszukaj po nazwie");
    Console.WriteLine("0 - wyjdź z programu");

    input = Convert.ToInt32(Console.ReadLine());

    if (input == 1)
    {
        showAllView();
    }
    if (input == 2)
    {
        selectDeviceView();
    }
    if (input == 3)
    {
        addDeviceView();
    }
    if (input == 4)
    {
        deleteDeviceView();
    }
    if (input == 5)
    {
        searchByName();
    }
    if (input < 1)
        break;

    Console.Clear();
}

void showAllView()
{
    Console.Clear();
    Console.WriteLine("+-----------------------------------+");
    Console.WriteLine("| id | name | type | status |");
    List<Device> devices = baseRepository.GetAll();
    foreach(Device device in devices)
    {
        Console.Write("| ");
        Console.Write($"{device.Id}");
        Console.Write(" | ");
        Console.Write($"{device.Name}");
        Console.Write(" | ");
        Console.Write($"{device.Type}");
        Console.Write(" | ");
        Console.Write($"{device.Status}");
        Console.WriteLine(" | ");
    }
    Console.WriteLine("+-----------------------------------+");
    Console.ReadKey();
}

void selectDeviceView()
{
    Console.WriteLine("selectDeviceView");

}

void addDeviceView()
{
    Console.Clear();
    Console.WriteLine("1 - żarówka");
    Console.WriteLine("2 - klimatyzacja");
    Console.WriteLine("3 - grzejnik");

    input = Convert.ToInt32(Console.ReadLine());

    if (input == 1)
    {
        addLight();
    }
    if (input == 2)
    {
        addAC();
    }
    if (input == 3)
    {
        addHeater();
    }
}

void addLight()
{
    string name;
    string type;
    Console.WriteLine("Dodawanie światła");
    Console.WriteLine("Podaj nazwe: ");
    name = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Podaj typ(outdoor/indoor): ");
    type = Convert.ToString(Console.ReadLine());
    baseRepository.Add(new Light(baseRepository.GetAll().Count() + 1, name, type, 0, 0, "FFFFFF", 255));
    Console.ReadKey();
}

void addAC()
{
    string name;
    string type;
    Console.WriteLine("Dodawanie Klimatyzacji");
    Console.WriteLine("Podaj nazwe: ");
    name = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Podaj typ(outdoor/indoor): ");
    type = Convert.ToString(Console.ReadLine());
    baseRepository.Add(new AirConditioning(baseRepository.GetAll().Count() + 1, name, type, 0, 0, 5, 20, 5, 5));
    Console.ReadKey();
}

void addHeater()
{
    string name;
    string type;
    Console.WriteLine("Dodawanie Klimatyzacji");
    Console.WriteLine("Podaj nazwe: ");
    name = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Podaj typ(outdoor/indoor): ");
    type = Convert.ToString(Console.ReadLine());
    baseRepository.Add(new Heater(baseRepository.GetAll().Count() + 1, name, type, 0, 0, 30, 0));
    Console.ReadKey();
}

void deleteDeviceView()
{
    showAllView();
    int id;
    Console.WriteLine("Podaj id urządzenia");
    id = Convert.ToInt32(Console.ReadLine());
    baseRepository.Delete(id);
    Console.ReadKey();
}

void searchByName()
{
    string name;
    Console.Clear();
    Console.WriteLine("Podaj nazwe: ");
    name = Convert.ToString(Console.ReadLine());

    List<Device> devices = baseRepository.GetAll();
    foreach(Device device in devices)
    {
        if (device.Name == name)
        {
            Console.Write("| ");
            Console.Write($"{device.Id}");
            Console.Write(" | ");
            Console.Write($"{device.Name}");
            Console.Write(" | ");
            Console.Write($"{device.Type}");
            Console.Write(" | ");
            Console.Write($"{device.Status}");
            Console.WriteLine(" | ");
        }
    }
    Console.ReadKey();
}