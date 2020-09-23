using System;
using System.Collections.Generic;
using System.Text;

namespace 职责链模式
{
    abstract class Logger
    {
        public LogLevel Level { get; }

        public Logger Next { get; set; }

        public Logger(LogLevel level)
        {
            this.Level = level;
        }

        public void Log(LogLevel level, string message)
        {
            if (this.Level == level)
            {
                Log(message);
            }
            else
            {
                Next?.Log(level, message);
            }
        }

        protected abstract void Log(string message);
    }
}
