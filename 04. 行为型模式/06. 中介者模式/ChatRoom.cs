using System;
using System.Collections.Generic;
using System.Text;

namespace 中介者模式
{
    class ChatRoom
    {
        public static void ShowMessage(User user,string message)
        {
            Console.WriteLine($"{DateTime.Now} [{user.Name}] : {message}");
        }
    }
}
