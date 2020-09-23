using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式
{
    interface IStrategy
    {
        int Execute(int num1, int num2);
    }
}
