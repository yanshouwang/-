using System;
using System.Collections.Generic;
using System.Text;

namespace 访问者模式
{
    class DisplayDeviceVisitor : IDeviceVisitor
    {
        public void Visit(Computer computer)
        {
            Console.WriteLine("Visiting Computer");
        }

        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Visiting Mouse");
        }

        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Visiting Keyboard");
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Visiting Monitor");
        }
    }
}
