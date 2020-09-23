using System;
using System.Collections.Generic;
using System.Text;

namespace 迭代器模式
{
    interface IList
    {
        IIterator GetIterator();
    }
}
