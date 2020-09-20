using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式.GPUs
{
    class GPU
    {
        public string Name { get; }

        public GPU(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
