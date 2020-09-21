using System;

namespace 桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PenSize size1 = new PenSize(20);
            PenColor color1 = new PenColor("Orange");
            Crayon crayon = new Crayon(size1, color1);
            PenSize size2 = new PenSize(32);
            PenColor color2 = new PenColor("White");
            Brush brush = new Brush(size2, color2);
            crayon.Draw();
            brush.Draw();
        }
    }
}
