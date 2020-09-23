using System;
using System.Collections.Generic;
using System.Text;

namespace 命令模式
{
    class Button
    {
        public Command Command { get; set; }

        public void Click()
        {
            Command?.Execute();
        }
    }
}
