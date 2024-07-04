using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builders
{
    public class HeaterBuilder : IHeaterBuilder
    {
        private Heater device = new Heater();

        public void BuildName()
        {
            device.Name = "Grzejnik w małym pokoju";
        }

        public void BuildType()
        {
            device.Type = "indoor";
        }

        public Device GetDevice()
        {
            return device;
        }
    }
}
