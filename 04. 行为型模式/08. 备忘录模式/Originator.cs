using System;
using System.Collections.Generic;
using System.Text;

namespace 备忘录模式
{
    class Originator
    {
        public string State { get; set; }

        public Memento Save()
        {
            return new Memento(State);
        }

        public void Restore(Memento memento)
        {
            this.State = memento.State;
        }
    }
}
