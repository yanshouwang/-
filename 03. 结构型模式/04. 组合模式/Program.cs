using System;
using System.IO;

namespace 组合模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DirectoryInfo directory = Directory.CreateDirectory(@"D:\培训\设计模式");

            Print(directory);
        }

        private static void Print(DirectoryInfo directory, string fix = null)
        {
            Console.WriteLine($"{fix}{directory.Name}");
            var directories = directory.GetDirectories();
            if (directories.Length == 0)
            {
                return;
            }
            else
            {
                fix += "- ";
                foreach (var item in directories)
                {
                    Print(item, fix);
                }
            }
        }
    }
}
