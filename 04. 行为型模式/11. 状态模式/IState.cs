using System;
using System.Collections.Generic;
using System.Text;

namespace 状态模式
{
    interface IState
    {
        void Execute(Context context);
    }
}
