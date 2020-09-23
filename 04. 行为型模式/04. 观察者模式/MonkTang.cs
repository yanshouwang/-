using System;
using System.Collections.Generic;
using System.Text;

namespace 观察者模式
{
    class MonkTang : IObserver
    {
        public string Name { get; }

        public MonkTang(string name)
        {
            this.Name = name;
        }

        public void Update(Observable sender, object e)
        {
            WeatherState state = (WeatherState)e;
            if (state == WeatherState.Rainy)
            {
                Console.WriteLine($"{this.Name}：打雷啦，下雨啦，回家收衣服啦！");
            }
        }
    }
}
