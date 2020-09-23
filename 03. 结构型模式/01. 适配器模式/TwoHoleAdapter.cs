using System;
using System.Collections.Generic;
using System.Text;

namespace 适配器模式
{
    class TwoHoleAdapter : ITwoHole
    {
        private readonly ThreeHole _threeHole;

        public string Zero
            => this._threeHole.Zero;

        public string Fire
            => this._threeHole.Fire;

        public TwoHoleAdapter(ThreeHole threeHole)
        {
            this._threeHole = threeHole;
        }
    }
}
