using System;

namespace 中介者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            User robert = new User("Robert");
            User john = new User("John");

            robert.SendMessage("Hi, John!");
            john.SendMessage("Hello, Robert!");
        }
    }
}
