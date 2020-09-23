using System;
using System.Collections.Generic;
using System.Text;

namespace 策略模式
{
    class Context
    {
        private readonly IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public int Execute(int num1, int num2)
        {
            return this._strategy.Execute(num1, num2);
        }
    }
}
