using System;
using System.Collections.Generic;
using System.Text;

namespace 代理模式
{
    public class MathProxy
    {
        private readonly Math _math;

        public MathProxy()
        {
            _math = new Math();
        }

        public int Add(int x,int y)
        {
            return _math.Add(x, y);
        }
    }
}
