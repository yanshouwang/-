using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式
{
    class StopState : IState
    {
        public void Execute(Context context)
        {
            Console.WriteLine("Player is in stop state");
            context.State = this;
        }
    }
}
