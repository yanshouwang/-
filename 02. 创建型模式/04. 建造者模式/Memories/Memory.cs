using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式.Memories
{
    class Memory
    {
        public string Name { get; }

        public Memory(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
