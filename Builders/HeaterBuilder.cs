using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

namespace ConsoleApp1.Builders
{
    public class HeaterBuilder : IHeaterBuilder
    {
        private Heater device = new Heater();

        public Device BuildName(string Name)
        {
            device.Name = Name;
            return device;
        }

        public Device BuildType(string Type)
        {
            device.Type = Type;
            return device;
        }

        public Device GetDevice()
        {
            return device;
        }
    }
}
