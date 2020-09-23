using System;

namespace 访问者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDevice computer = new Computer();
            IDeviceVisitor visitor = new DisplayDeviceVisitor();
            computer.Accept(visitor);
        }
    }
}
