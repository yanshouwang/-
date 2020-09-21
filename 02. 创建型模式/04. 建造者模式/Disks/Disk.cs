using System;
using System.Collections.Generic;
using System.Text;

namespace 建造者模式.Disks
{
    abstract class Disk
    {
        public string Name { get; }

        public Disk(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
