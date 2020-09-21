using System;

namespace 外观模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ILoggerFacade logger = new ConsoleLogger();
            logger.Log("外观模式", Category.Info, Priority.Low);
        }
    }
}
