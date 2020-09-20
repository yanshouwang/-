using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式.Motherboards
{
    class Motherboard
    {
        public string Name { get; }

        public Motherboard(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
