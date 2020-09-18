using System;
using System.Collections.Generic;
using System.Text;

namespace 抽象工厂模式
{
    class BMWCarFactory : ICarFactory
    {
        public Car CreateCar()
        {
            return new BMWCar();
        }
    }
}
