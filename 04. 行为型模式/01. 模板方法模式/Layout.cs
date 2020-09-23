using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 模板方法模式
{
    class Layout
    {
        public void Add(Control child)
        {
            Console.WriteLine("布局可用大小：200 * 200");
            Size availableSize = new Size(200, 200);
            Size desiredSize = child.Measure(availableSize);
            Console.WriteLine($"控件期望大小：{desiredSize.Width} * {desiredSize.Height}");
            int finalWidth = Math.Min(desiredSize.Width, availableSize.Width);
            int finalHeight = Math.Min(desiredSize.Height, availableSize.Height);
            Size finalSize = new Size(finalWidth, finalHeight);
            Console.WriteLine($"最终计算大小：{finalSize.Width} * {finalSize.Height}");
            child.Draw(finalSize);
        }
    }
}
