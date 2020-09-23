using System;

namespace 迭代器模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            object[] objs = new[] { "Hello World", "OMG", "How are you" };
            IList list = new ArrayList(objs);
            IIterator iterator = list.GetIterator();
            while (iterator.MoveNext())
            {
                string str = (string)iterator.Current;
                Console.WriteLine(str);
            }
        }
    }
}
