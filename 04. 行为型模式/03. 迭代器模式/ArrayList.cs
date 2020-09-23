namespace 迭代器模式
{
    class ArrayList : IList
    {
        private readonly object[] _objs;

        public int Length
            => _objs.Length;

        public ArrayList(object[] objs)
        {
            this._objs = objs;
        }

        public IIterator GetIterator()
        {
            return new Iterator(this);
        }

        public object this[int index]
        {
            get => this._objs[index];
            set => this._objs[index] = value;
        }

        class Iterator : IIterator
        {
            private readonly ArrayList _list;
            private int _index;

            public Iterator(ArrayList list)
            {
                this._list = list;
            }

            public object Current
                => _list[_index];

            public bool MoveNext()
            {
                if (_index < _list.Length - 1)
                {
                    _index++;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                _index = 0;
            }
        }
    }
}