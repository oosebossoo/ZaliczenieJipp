using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    public interface IAirConditioningRepository
    {
        public List<AirConditioning> GetAllAirConditioning();
        public void changeDirection(int Id, int x, int y);
    }
}
