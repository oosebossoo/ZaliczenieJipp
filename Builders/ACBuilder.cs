using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

namespace ConsoleApp1.Builders
{
    public class ACBuilder : IACBuilder
    {
        private AirConditioning device = new AirConditioning();

        public Device BuildName(string Name)
        {
            device.Name = Name;
            return device;
        }

        public Device BuildType(string Type)
        {
            device.Type = "indoor";
            return device;
        }

        public Device GetDevice()
        {
            return device;
        }
    }
}
