using System;
using System.Diagnostics;
using System.Linq;

namespace 状态模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Context context = new Context();
            IState startState = new StartState();
            startState.Execute(context);
            IState stopState = new StopState();
            stopState.Execute(context);
        }
    }
}
