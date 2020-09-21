using System;
using 建造者模式.CPUs;
using 建造者模式.Disks;
using 建造者模式.GPUs;
using 建造者模式.Memories;
using 建造者模式.Monitors;
using 建造者模式.Motherboards;
using 建造者模式.Powers;

namespace 建造者模式
{
    class ComputerBuilder
    {
        private readonly Lazy<Computer> _lazyComputer = new Lazy<Computer>(true);

        private Computer Computer
            => this._lazyComputer.Value;

        public ComputerBuilder SetLevel(GameLevel level)
        {
            switch (level)
            {
                case GameLevel.GTA5:
                    this.Computer.Motherboard = new X570E();
                    this.Computer.CPU = new Ryzen3950X();
                    this.Computer.GPU = new RX5700XT();
                    this.Computer.Disks.Add(new RD10());
                    this.Computer.Memories.Add(new Corsair3200());
                    this.Computer.Memories.Add(new Corsair3200());
                    this.Computer.Memories.Add(new Corsair3200());
                    this.Computer.Memories.Add(new Corsair3200());
                    this.Computer.Power = new Thor1200P();
                    this.Computer.Monitor = new PG43UQ();
                    break;
                case GameLevel.MineSweeper:
                    this.Computer.Motherboard = new B460F();
                    this.Computer.CPU = new Core480M();
                    this.Computer.GPU = new HD6370M();
                    this.Computer.Disks.Add(new C2000L());
                    this.Computer.Memories.Add(new Kingston1333());
                    this.Computer.Memories.Add(new Kingston1333());
                    this.Computer.Power = new Strix550G();
                    this.Computer.Monitor = new C30SK();
                    break;
                default:
                    break;
            }
            return this;
        }

        public Computer Build()
        {
            return this.Computer;
        }
    }
}
