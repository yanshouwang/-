using System;
using System.Collections.Generic;
using System.Text;

namespace 备忘录模式
{
    class Memento
    {
        public string State { get; set; }

        public Memento(string state)
        {
            this.State = state;
        }
    }
}
