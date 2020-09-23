using System;

namespace 命令模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            Printer printer = new Printer();
            button.Command = new PrinterCommand(printer);
            button.Click();
        }
    }
}
