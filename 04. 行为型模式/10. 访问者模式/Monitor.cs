namespace 访问者模式
{
    class Monitor : IDevice
    {
        public void Accept(IDeviceVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}