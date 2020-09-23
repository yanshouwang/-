using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace 模板方法模式
{
    abstract class Control
    {
        public abstract Size Measure(Size availalbeSize);
        public abstract void Draw(Size finalSize);
    }
}
