using System;

namespace 模板方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Layout layout = new Layout();
            Control circle = new Circle();
            Control line = new Line();
            layout.Add(circle);
            Console.WriteLine("=====================================");
            layout.Add(line);
        }
    }
}
