using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式
{
    class HongQiCarFactory : ICarFactory
    {
        public Car CreateCar()
        {
            return new HongQiCar();
        }
    }
}
