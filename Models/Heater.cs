using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Heater: Device
    {
        public int Temperature { get; set; }
        public int Timer { get; set; }
        private static string className { get; set; }

        public Heater() {}

        public Heater(int Id, string Name, string Type, int Status, int ActiveTime, int Temperature, int Timer)
        {
            this.Id = Id;
            this.Name = Name;
            this.Type = Type;
            this.Status = Status;
            this.ActiveTime = ActiveTime;

            this.Temperature = Temperature;
            this.Timer = Timer;

            className = this.GetType().Name;
        }

        public static string ClassName()
        {
            return className;
        }
    }
}
