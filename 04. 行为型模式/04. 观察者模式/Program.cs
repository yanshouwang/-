using System;

namespace 观察者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Weather weather = new Weather();
            IObserver observer = new MonkTang("唐三藏");
            weather.AddObservaer(observer);
            weather.State = WeatherState.Rainy;
        }
    }
}
