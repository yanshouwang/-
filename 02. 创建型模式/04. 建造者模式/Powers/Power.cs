using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式.Powers
{
    class Power
    {
        public string Name { get; }

        public Power(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
