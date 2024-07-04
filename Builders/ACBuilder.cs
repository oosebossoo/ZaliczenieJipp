using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builders
{
    public class ACBuilder : IACBuilder
    {
        private AirConditioning device = new AirConditioning();

        public void BuildName()
        {
            device.Name = "Klimatyzacja w dużym pokoju";
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
