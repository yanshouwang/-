using System;

namespace _02._简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CarFactory factory = new CarFactory();
            Car hondaCar = factory.CreateCar(CarType.Honda);
            Car bmwCar = factory.CreateCar(CarType.BMW);
            Car hongQiCar = factory.CreateCar(CarType.HongQi);
            hondaCar.Run();
            bmwCar.Run();
            hongQiCar.Run();
        }
    }
}
