using System;
using System.Collections.Generic;
using System.Text;

namespace _03._抽象工厂模式
{
    class HondaCarFactory : ICarFactory
    {
        public Car CreateCar()
        {
            return new HondaCar();
        }
    }
}
