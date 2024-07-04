using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

namespace ConsoleApp1.Repositories
{
    public class BaseRepository : IBaseRepository
    {
        public List<Device> devices;
        public BaseRepository()
        {
            this.devices = new List<Device>();
        }

        public void Add(Device device)
        {
            this.devices.Add(device);
        }

        public void Delete(int Id)
        {
            Device device = this.GetById(Id);
            this.devices.Remove(device);
        }

        public List<Device> GetAll()
        {
            return this.devices.ToList();
        }

        public Device GetById(int id)
        {
            var entity = devices.Where(x => x.Id == id).First();
            return entity;
        }

        public void Update(Device device)
        {
            
        }
    }
}
