// https://zhuanlan.zhihu.com/p/58093669
// 当一个类的构造函数参数个数超过4个，而且这些参数有些是可选的参数，考虑使用构造者模式

using System;
using System.Collections.Generic;
using 建造者模式.CPUs;
using 建造者模式.Disks;
using 建造者模式.GPUs;
using 建造者模式.Motherboards;
using 建造者模式.Memories;
using 建造者模式.Monitors;
using 建造者模式.Powers;
using System.Linq;

namespace 建造者模式
{
    class Computer
    {
        public Motherboard Motherboard { get; set; }
        public CPU CPU { get; set; }
        public GPU GPU { get; set; }
        public IList<Memory> Memories { get; set; }
        public IList<Disk> Disks { get; set; }
        public Power Power { get; set; }
        public Monitor Monitor { get; set; }

        public Computer()
        {
            Memories = new List<Memory>();
            Disks = new List<Disk>();
        }

        public override string ToString()
        {
            string memories = Memories.Aggregate(string.Empty, (total, next) => $"{total}\n{next}");
            return $"主板：{Motherboard}\n处理器:{CPU}\n显卡:{GPU}\n内存：\n硬盘：\n电源：\n显示器：";
        }

        class ComputerBuilder
        {
            private readonly Lazy<Computer> _lazyComputer = new Lazy<Computer>(true);

            private Computer Computer
                => _lazyComputer.Value;

            public void SetMatherboard(Motherboard motherboard)
            {
                this.Computer.Motherboard = motherboard;
            }

            public void SetCPU(CPU cpu)
            {
                this.Computer.CPU = cpu;
            }

            public void SetGPU(GPU gpu)
            {
                this.Computer.GPU = gpu;
            }

            public void AddMemory(Memory memory)
            {
                this.Computer.Memories.Add(memory);
            }

            public void AddDisk(Disk disk)
            {
                this.Computer.Disks.Add(disk);
            }

            public void SetPower(Power power)
            {
                this.Computer.Power = power;
            }

            public void SetMonitor(Monitor monitor)
            {
                this.Computer.Monitor = monitor;
            }

            public Computer Build()
            {
                return this.Computer;
            }
        }
    }
}