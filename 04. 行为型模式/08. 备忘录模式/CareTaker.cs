using System;
using System.Collections.Generic;
using System.Text;

namespace 备忘录模式
{
    class CareTaker
    {
        private readonly IList<Memento> _mementos;

        public CareTaker()
        {
            this._mementos = new List<Memento>();
        }

        public void Add(Memento memento)
        {
            this._mementos.Add(memento);
        }

        public Memento Get(int i)
        {
            return this._mementos[i];
        }
    }
}
