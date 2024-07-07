using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Builders
{
    public class ACDirector
    {
        private IACBuilder builder;

        public void SetBuilder(IACBuilder builder)
        {
            this.builder = builder;
        }

        public Device GetDevice()
        {
            return builder.GetDevice();
        }

        public void ConstructAC(string Name, string Type)
        {
            builder.BuildName(Name);
            builder.BuildType(Type);
        }
    }
}
