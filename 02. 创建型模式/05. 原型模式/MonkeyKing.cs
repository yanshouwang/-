// 深拷贝和浅拷贝，MemberwiseClone 和 Clone

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace 原型模式
{
    class MonkeyKing
    {
        public string Name { get; set; }

        public MonkeyKing(string name)
        {
            Console.WriteLine("花果山上的一个石头");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("吸收了 100 年日月精华");
            }
            this.Name = name;
            Console.WriteLine("吃饱了，蹦出来个石猴");
        }

        public MonkeyKing Copy()
        {
            return (MonkeyKing)this.MemberwiseClone();
        }
    }
}
