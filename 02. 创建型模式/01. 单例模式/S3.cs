using System;
using System.Collections.Generic;
using System.Text;

namespace 单例模式
{
    class S3
    {
        private static readonly Lazy<S3> _lazyInstance
            = new Lazy<S3>(() => new S3(), true);

        /// <summary>
        /// 懒汉式，使用 Lazy 懒加载的方式实现
        /// </summary>
        public static S3 Instance
            => _lazyInstance.Value;

        private S3()
        {

        }

        public void SayHello()
        {
            Console.WriteLine($"S3, HashCode: {this.GetHashCode()}");
        }
    }
}
