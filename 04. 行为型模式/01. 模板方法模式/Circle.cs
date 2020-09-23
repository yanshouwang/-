using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 模板方法模式
{
    class Circle : Control
    {
        public override void Draw(Size finalSize)
        {
            Console.WriteLine("画了一个圆");
        }

        public override Size Measure(Size availalbeSize)
        {
            return new Size(300, 100);
        }
    }
}
