﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Light: Device
    {
        public string Color { get; set; }
        public int Brightness { get; set; }

        public Light(int Id, string Name, string Type, int Status, int ActiveTime, string Color, int Brightness)
        {
            this.Id = Id;
            this.Name = Name;
            this.Type = Type;
            this.Status = Status;
            this.ActiveTime = ActiveTime;

            this.Color = Color;
            this.Brightness = Brightness;
        }
    }
}