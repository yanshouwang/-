namespace 访问者模式
{
    class Keyboard : IDevice
    {
        public void Accept(IDeviceVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}