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
            this.Memories = new List<Memory>();
            this.Disks = new List<Disk>();
        }

        public override string ToString()
        {
            string memories = this.Memories.Aggregate(string.Empty, (total, next) => $"{total}\t{next}\n", result => result.TrimEnd());
            string disks = this.Disks.Aggregate(string.Empty, (total, next) => $"{total}\t{next}\n", result => result.TrimEnd());
            return $"主板：{this.Motherboard}\n处理器：{this.CPU}\n显卡：{this.GPU}\n内存：\n{memories}\n硬盘：\n{disks}\n电源：{this.Power}\n显示器：{this.Monitor}";
        }
    }
}