using System;
using System.Data.Common;

namespace 适配器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TwoPin twoPin = new TwoPin();
            ITwoHole twoHole = new TwoHoleAdapter();
            twoPin.Connect(twoHole);
        }
    }
}
