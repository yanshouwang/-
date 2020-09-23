using System;
using System.Threading;
using System.Threading.Tasks;

namespace 享元模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 0; i < 10000; i++)
            {
                Task.Run(() =>
                {
                    Thread.CurrentThread.IsBackground = false;
                    int id = Thread.CurrentThread.ManagedThreadId;
                    Console.WriteLine(id);
                });
            }
        }
    }
}
