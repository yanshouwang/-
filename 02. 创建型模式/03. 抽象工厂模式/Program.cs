using System;

namespace 抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ICarFactory hondaCarFactory = new HondaCarFactory();
            ICarFactory bmwCarFactory = new BMWCarFactory();
            ICarFactory hongQiCarFactory = new HongQiCarFactory();
            Car hondaCar = hondaCarFactory.CreateCar();
            Car bmwCar = bmwCarFactory.CreateCar();
            Car hongQiCar = hongQiCarFactory.CreateCar();
            hondaCar.Run();
            bmwCar.Run();
            hongQiCar.Run();
        }
    }
}
