
namespace Lab_7_Lepilkin_Maksim_ISP_232
{
    internal class Car_DZ_
    {
        public string? Model;
        public int Speed;
        public int MaxSpeed;

        public  Car_DZ_(string Model, int MaxSpeed)
        {
            this.Model = Model;
            Speed = 0;
            this.MaxSpeed = MaxSpeed;
            Console.WriteLine($"Модель: {Model}, Текущая скорость: {MaxSpeed} км/ч");
        }
        public void Accelerate1(int delta)
        {
            Speed += delta;
            if (Speed > MaxSpeed)
                Speed = MaxSpeed;
        }
        public void Brake()
        {
            this.Speed = 0;
            Console.WriteLine($"После торможения: {Speed} км/ч");
        }

    }
}
