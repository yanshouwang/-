using System;

namespace 代理模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MathProxy proxy = new MathProxy();
            int result = proxy.Add(2, 3);
            Console.WriteLine(result);
        }
    }
}
