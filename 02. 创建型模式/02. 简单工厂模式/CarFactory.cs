using System;
using System.Collections.Generic;
using System.Text;

namespace _02._简单工厂模式
{
    class CarFactory
    {
        public Car CreateCar(CarType type)
        {
            switch (type)
            {
                case CarType.Honda:
                    return new HondaCar();
                case CarType.BMW:
                    return new BMWCar();
                case CarType.HongQi:
                    return new HongQiCar();
                default:
                    return null;
            }
        }
    }
}
