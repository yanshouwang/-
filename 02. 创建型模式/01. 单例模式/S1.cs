// https://blog.51cto.com/cnn237111/1425949

using System;
using System.Collections.Generic;
using System.Text;

namespace 单例模式
{
    class S1
    {
        private static volatile S1 _instance;
        private static readonly object _obj = new object();

        /// <summary>
        /// 懒汉式，通过双 lock 加 if 实现，注意静态字段中的 volatile 关键字
        /// </summary>
        public static S1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_obj)
                    {
                        if (_instance == null)
                        {
                            _instance = new S1();
                        }
                    }
                }
                return _instance;
            }
        }

        private S1()
        {

        }

        public void SayHello()
        {
            Console.WriteLine($"S1, HashCode: {this.GetHashCode()}");
        }
    }
}
