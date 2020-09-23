namespace 访问者模式
{
    class Mouse : IDevice
    {
        public void Accept(IDeviceVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}