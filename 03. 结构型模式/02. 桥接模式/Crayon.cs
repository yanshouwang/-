using System;
using System.Collections.Generic;
using System.Text;

namespace 桥接模式
{
    class Crayon
    {
        public PenSize Size { get; set; }
        public PenColor Color { get; set; }

        public Crayon(PenSize size, PenColor color)
        {
            this.Size = size;
            this.Color = color;
        }

        public void Draw()
        {
            Console.WriteLine($"蜡笔，{this.Size.Size}，{this.Color.Color}");
        }
    }
}
