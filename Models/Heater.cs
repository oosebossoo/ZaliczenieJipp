using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Heater: Device
    {
        public int Temperature { get; set; }
        public int Timer { get; set; }

        public Heater(int Id, string Name, string Type, int Status, int ActiveTime, int Temperature, int Timer)
        {
            this.Id = Id;
            this.Name = Name;
            this.Type = Type;
            this.Status = Status;
            this.ActiveTime = ActiveTime;

            this.Temperature = Temperature;
            this.Timer = Timer;
        }
    }
}
