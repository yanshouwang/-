using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式.Monitors
{
    class Monitor
    {
        public string Name { get; }

        public Monitor(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
