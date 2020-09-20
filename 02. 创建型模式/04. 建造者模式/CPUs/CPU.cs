using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式.CPUs
{
    abstract class CPU
    {
        public string Name { get; }

        public CPU(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
