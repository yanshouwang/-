using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式
{
    class TwoHole : ITwoHole
    {
        public string Zero { get; }
        public string Fire { get; }

        public TwoHole()
        {
            Zero = "两孔插座的零线";
            Fire = "两孔插座的火线";
        }
    }
}
