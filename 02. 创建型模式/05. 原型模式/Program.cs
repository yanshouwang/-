using System;

namespace 原型模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MonkeyKing monkey1 = new MonkeyKing("孙悟空");
            MonkeyKing monkey2 = monkey1.Copy();
            monkey2.Name = "孙悟空的分身";
            Console.WriteLine(monkey1.Name);
            Console.WriteLine(monkey2.Name);
        }
    }
}
