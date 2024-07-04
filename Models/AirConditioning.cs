namespace ConsoleApp1.Models
{
    public class AirConditioning: Device
    {
        public int FanSpeed { get; set; }
        public int Temperature { get; set; }
        public int DirectionX { get; set; }
        public int DirectionY { get; set; }

        private static string className { get; set; }

        public AirConditioning(int Id, string Name, string Type, int Status, int ActiveTime, int FanSpeed, int Temperature, int DirectionX, int DirectionY)
        {
            this.Id = Id;
            this.Name = Name;
            this.Type = Type;
            this.Status = Status;
            this.ActiveTime = ActiveTime;

            this.FanSpeed = FanSpeed;
            this.Temperature = Temperature;
            this.DirectionX = DirectionX;
            this.DirectionY = DirectionY;

            className = this.GetType().Name;
        }


        public static string ClassName()
        {
            return className;
        }

        public int GetDirectionX()
        {
            return this.DirectionX;
        }
    }
}
