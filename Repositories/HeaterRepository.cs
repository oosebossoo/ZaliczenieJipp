﻿using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repositories
{
    public class HeaterRepository : IHeaterRepository
    {
        public BaseRepository baseRepository { get; set; }

        public HeaterRepository(BaseRepository baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public List<Heater> GetAllHeaters()
        {
            List<Device> all = this.baseRepository.GetAll();
            List<Heater> heaters = new List<Heater>();
            foreach (var device in all)
            {
                if (this.typeCheck(device))
                {
                    heaters.Add((device as Heater));
                }
            }
            return heaters;
        }

        private bool typeCheck(Device device)
        {
            return device.GetType().Name == Heater.ClassName();
        }
    }
}
