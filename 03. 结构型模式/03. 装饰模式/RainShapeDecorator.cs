using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰器模式
{
    class RainShapeDecorator : ShapeDecorator
    {
        public RainShapeDecorator(IShape shape)
            : base(shape)
        {
        }

        protected override void Decorate()
        {
            Console.WriteLine("画雨滴装饰");
        }
    }
}
