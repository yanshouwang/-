using System;
using System.Collections.Generic;
using System.Text;

namespace 解释器模式
{
    abstract class Expression
    {
        public abstract string Interpret(string str);
    }
}
