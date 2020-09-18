// https://blog.51cto.com/cnn237111/1425949

using System;
using System.Collections.Generic;
using System.Text;

namespace 单例模式
{
    class Singleton
    {
        private static volatile Singleton _instance;
        private static readonly object _obj = new object();

        private Singleton()
        {

        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_obj)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, My HashCode is {this.GetHashCode()}");
        }
    }
}
