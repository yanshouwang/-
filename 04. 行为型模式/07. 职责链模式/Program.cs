using System;

namespace 职责链模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Logger logger = GetLogger();
            logger.Log(LogLevel.INFO, "This is an information.");
            logger.Log(LogLevel.DEBUG, "This is an debug.");
            logger.Log(LogLevel.ERROR, "This is an error.");
        }

        private static Logger GetLogger()
        {
            Logger infoLogger = new InfoLogger();
            Logger debugLogger = new DebugLogger();
            Logger errorLogger = new ErrorLogger();
            infoLogger.Next = debugLogger;
            debugLogger.Next = errorLogger;
            return infoLogger;
        }
    }
}
