using System;

namespace 解释器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string str = "1.2 * 5.3";
            Expression expression = new MathExpression();
            string result = expression.Interpret(str);
            Console.WriteLine(result);
        }
    }
}
