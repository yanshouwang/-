using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰器模式
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("画圆形");
        }
    }
}
