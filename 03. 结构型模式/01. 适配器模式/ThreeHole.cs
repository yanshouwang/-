using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式
{
    class ThreeHole
    {
        public string Zero { get; }
        public string Fire { get; }
        public string Ground { get; }

        public ThreeHole()
        {
            Zero = "三孔插座的零线";
            Fire = "三孔插座的火线";
            Ground = "三孔插座的地线";
        }
    }
}
