using System;
using System.Collections.Generic;
using System.Text;

namespace 单例模式
{
    class S2
    {
        /// <summary>
        /// 饿汉式，使用静态初始化方式实现，由 CLR 保证线程安全
        /// </summary>
        public static S2 Instance { get; } = new S2();

        private S2()
        {

        }

        public void SayHello()
        {
            Console.WriteLine($"S2, HashCode: {this.GetHashCode()}");
        }
    }
}
