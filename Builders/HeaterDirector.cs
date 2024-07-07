using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builders
{
    public class HeaterDirector
    {
        private IHeaterBuilder builder;

        public void SetBuilder(IHeaterBuilder builder)
        {
            this.builder = builder;
        }

        public Device GetDevice()
        {
            return builder.GetDevice();
        }

        public void ConstructHeater(string Name, string Type)
        {
            builder.BuildName(Name);
            builder.BuildType(Type);
        }
    }
}
