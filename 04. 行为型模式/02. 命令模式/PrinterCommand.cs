using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    class PrinterCommand : Command
    {
        private readonly Printer _printer;

        public PrinterCommand(Printer printer)
        {
            this._printer = printer;
        }

        public override void Execute()
        {
            this._printer.Print();
        }
    }
}
