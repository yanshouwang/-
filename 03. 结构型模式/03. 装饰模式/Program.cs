using System;

namespace 装饰器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IShape circle = new Circle();
            IShape rectangle = new Rectangle();
            RainShapeDecorator decorator1 = new RainShapeDecorator(circle);
            RainShapeDecorator decorator2 = new RainShapeDecorator(rectangle);
            decorator1.Draw();
            decorator2.Draw();
        }
    }
}
