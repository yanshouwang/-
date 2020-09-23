namespace 中介者模式
{
    class User
    {
        public string Name { get; }

        public User(string name)
        {
            this.Name = name;
        }

        public void SendMessage(string message)
        {
            ChatRoom.ShowMessage(this, message);
        }
    }
}