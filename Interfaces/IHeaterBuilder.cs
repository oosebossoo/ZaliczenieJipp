﻿using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    public interface IHeaterBuilder
    {
        Device BuildName(string Name);
        Device BuildType(string Type);
        Device GetDevice();
    }
}
