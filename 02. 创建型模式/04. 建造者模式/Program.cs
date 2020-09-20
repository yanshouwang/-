using System;

namespace 建造者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ComputerBuilder builder1 = new ComputerBuilder();
            ComputerBuilder builder2 = new ComputerBuilder();
            Computer computer1 = builder1.SetLevel(GameLevel.GTA5).Build();
            Computer computer2 = builder2.SetLevel(GameLevel.MineSweeper).Build();
            Console.WriteLine(computer1);
            Console.WriteLine("==================================");
            Console.WriteLine(computer2);
        }
    }
}
