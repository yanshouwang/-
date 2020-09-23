using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式
{
    class ErrorLogger : Logger
    {
        public ErrorLogger()
            : base(LogLevel.ERROR)
        {
        }

        protected override void Log(string message)
        {
            Console.WriteLine($"[ERROR] : {message}");
        }
    }
}
