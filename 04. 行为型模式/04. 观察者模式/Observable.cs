using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    abstract class Observable
    {
        private readonly IList<IObserver> _observers;

        public Observable()
        {
            this._observers = new List<IObserver>();
        }

        public void AddObservaer(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void RemoveObservaer(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void NotifyObservers(object e)
        {
            foreach (var observer in _observers)
            {
                observer.Update(this, e);
            }
        }
    }
}
