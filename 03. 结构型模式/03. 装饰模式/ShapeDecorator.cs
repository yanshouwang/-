using System;
using System.Collections.Generic;
using System.Text;

namespace 装饰器模式
{
    abstract class ShapeDecorator : IShape
    {
        private readonly IShape _shape;

        public ShapeDecorator(IShape shape)
        {
            this._shape = shape;
        }

        public void Draw()
        {
            this._shape.Draw();
            // 装饰
            this.Decorate();
        }

        protected abstract void Decorate();
    }
}
