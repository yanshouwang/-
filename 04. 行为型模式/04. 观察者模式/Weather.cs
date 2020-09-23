using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    class Weather : Observable
    {
        private WeatherState _state;

        public WeatherState State
        {
            get => this._state;
            set
            {
                if (this._state == value)
                    return;
                Console.WriteLine($"天气改变：{this._state} -> {value}");
                this._state = value;
                this.NotifyObservers(value);
            }
        }
    }
}
