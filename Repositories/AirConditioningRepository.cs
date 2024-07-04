using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApp1.Repositories
{
    public class AirConditioningRepository : IAirConditioningRepository
    {
        public BaseRepository baseRepository { get; set; }

        public AirConditioningRepository(BaseRepository baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public List<AirConditioning> GetAllAirConditioning()
        {
            List<Device> all = this.baseRepository.GetAll();
            List<AirConditioning> acs = new List<AirConditioning>();
            foreach (var device in all)
            {
                if (this.typeCheck(device))
                {
                    acs.Add((device as AirConditioning));
                }
            }
            return acs;
        }

        public void changeDirection(int Id, int x, int y)
        {
            var device = this.baseRepository.GetById(Id);
            if (this.typeCheck(device))
            {
                AirConditioning ac = this.GetAllAirConditioning().Where(x => x.Id == Id).First();
                ac.DirectionX = x;
                ac.DirectionY = y;
            }
        }

        private bool typeCheck(Device device)
        {
            return device.GetType().Name == AirConditioning.ClassName();
        }
    }
}
