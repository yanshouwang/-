using System;
using System.Collections.Generic;
using System.Text;

namespace 解释器模式
{
    class MathExpression : Expression
    {
        public override string Interpret(string str)
        {
            try
            {
                string[] strs = str.Split(" ");
                double v1 = double.Parse(strs[0]);
                string symbol = strs[1];
                double v2 = double.Parse(strs[2]);
                double result;
                switch (symbol)
                {
                    case "+":
                        result = v1 + v2;
                        break;
                    case "-":
                        result = v1 - v2;
                        break;
                    case "*":
                        result = v1 * v2;
                        break;
                    case "/":
                        result = v1 / v2;
                        break;
                    default:
                        throw new NotImplementedException();
                }
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
