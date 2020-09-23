using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    interface IObserver
    {
        void Update(Observable sender, object e);
    }
}
