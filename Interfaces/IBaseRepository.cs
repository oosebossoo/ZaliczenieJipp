using ConsoleApp1.Models;

namespace ConsoleApp1.Interfaces
{
    public interface IBaseRepository
    {
        public void Add(Device device);
        public void Delete(int Id);
        public void Update(Device device);
        public List<Device> GetAll();
        public Device GetById(int id);
    }
}
