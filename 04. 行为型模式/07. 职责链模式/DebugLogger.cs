using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式
{
    class DebugLogger : Logger
    {
        public DebugLogger()
            : base(LogLevel.DEBUG)
        {
        }

        protected override void Log(string message)
        {
            Console.WriteLine($"[DEBUG] : {message}");
        }
    }
}
