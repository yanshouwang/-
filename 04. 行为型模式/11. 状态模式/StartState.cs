using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式
{
    class StartState : IState
    {
        public void Execute(Context context)
        {
            Console.WriteLine("Player is in start state");
            context.State = this;
        }
    }
}
