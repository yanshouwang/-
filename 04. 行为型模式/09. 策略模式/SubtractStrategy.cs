using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式
{
    class SubtractStrategy : IStrategy
    {
        public int Execute(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
