using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;

namespace ConsoleApp1.Repositories
{
    public class LightRepository : ILightRepository
    {
        public BaseRepository baseRepository { get; set; }

        public LightRepository(BaseRepository baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public List<Light> GetAllLights()
        {
            List<Device> all = this.baseRepository.GetAll();
            List<Light> lights = new List<Light>();
            foreach (var device in all)
            {
                if (this.typeCheck(device))
                {
                    lights.Add((device as Light));
                }
            }
            return lights;
        }

        private bool typeCheck(Device device)
        {
            return device.GetType().Name == Light.ClassName();
        }
    }
}
