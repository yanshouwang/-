using System;

namespace 策略模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IStrategy addStrategy = new AddStrategy();
            IStrategy subStrategy = new SubtractStrategy();
            IStrategy mulStrategy = new MultiplyStrategy();

            Context context = new Context(addStrategy);
            int r1 = context.Execute(10, 5);
            Console.WriteLine($"10 + 5 = {r1}");

            context = new Context(subStrategy);
            int r2 = context.Execute(10, 5);
            Console.WriteLine($"10 - 5 = {r2}");

            context = new Context(mulStrategy);
            int r3 = context.Execute(10, 5);
            Console.WriteLine($"10 * 5 = {r3}");
        }
    }
}
