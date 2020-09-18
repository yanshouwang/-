using System;
using System.Collections.Generic;
using System.Text;

namespace _03._抽象工厂模式
{
    abstract class Car
    {
        public abstract string Name { get; }

        public void Run()
        {
            Console.WriteLine($"{this.Name} 行驶中...");
        }
    }
}
