using System.Collections.Generic;

namespace 访问者模式
{
    class Computer : IDevice
    {
        private readonly IList<IDevice> _devices;

        public Computer()
        {
            this._devices = new List<IDevice>()
            {
                new Mouse(),
                new Keyboard(),
                new Monitor()
            };
        }

        public void Accept(IDeviceVisitor visitor)
        {
            foreach (var device in this._devices)
            {
                device.Accept(visitor);
            }
            visitor.Visit(this);
        }
    }
}