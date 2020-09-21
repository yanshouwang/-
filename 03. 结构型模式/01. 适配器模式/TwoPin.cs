using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式
{
    class TwoPin
    {
        public string Zero { get; }
        public string Fire { get; }

        public TwoPin()
        {
            Zero = "两针插头的零线";
            Fire = "两针插头的火线";
        }

        public void Connect(ITwoHole twoHole)
        {
            Console.WriteLine($"{this.Zero} 连接到 {twoHole.Zero}");
            Console.WriteLine($"{this.Fire} 连接到 {twoHole.Fire}");
            Console.WriteLine("成功接通");
        }
    }
}
