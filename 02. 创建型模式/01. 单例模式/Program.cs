using System;
using System.Threading;

namespace 单例模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 0; i < 3; i++)
            {
                SayHello();
            }
            Console.ReadLine();
        }

        private static void SayHello()
        {
            new Thread(() =>
            {
                S1 s1 = S1.Instance;
                S2 s2 = S2.Instance;
                S3 s3 = S3.Instance;
                s1.SayHello();
                s2.SayHello();
                s3.SayHello();
            }).Start();
        }
    }
}
