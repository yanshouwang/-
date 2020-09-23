using System;
using System.Collections.Generic;
using System.Text;

namespace 访问者模式
{
    interface IDevice
    {
        void Accept(IDeviceVisitor visitor);
    }
}
