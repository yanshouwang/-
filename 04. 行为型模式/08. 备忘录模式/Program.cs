using System;

namespace 备忘录模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Originator originator = new Originator();
            CareTaker careTaker = new CareTaker();
            originator.State = "State #1";
            originator.State = "State #2";
            Memento memento1 = originator.Save();
            careTaker.Add(memento1);
            originator.State = "State #3";
            Memento memento2 = originator.Save();
            careTaker.Add(memento2);
            originator.State = "State #4";

            Console.WriteLine($"Current State: {originator.State}");
            Memento memento3 = careTaker.Get(0);
            originator.Restore(memento3);
            Console.WriteLine($"First saved State: {originator.State}");
            Memento memento4 = careTaker.Get(1);
            originator.Restore(memento4);
            Console.WriteLine($"Second saved State: {originator.State}");
        }
    }
}
