using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式
{
    class InfoLogger : Logger
    {
        public InfoLogger()
            : base(LogLevel.INFO)
        {
        }

        protected override void Log(string message)
        {
            Console.WriteLine($"[INFO] : {message}");
        }
    }
}
