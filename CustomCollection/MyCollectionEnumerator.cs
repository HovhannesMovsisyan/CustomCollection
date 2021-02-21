using System;
using System.Collections.Generic;
using System.Text;

namespace CustomCollection
{
    public class MyCollectionEnumerator<T> : IEnumerator<T> 
    {
        private readonly MyCollection<T> _collection;
        public int Counter = -1;

        public MyCollectionEnumerator(MyCollection<T> collection)
        {
            _collection = collection;
        }

        public object Current => _collection[Counter];

        T IEnumerator<T>.Current => _collection[Counter];

        public void Dispose()
        {
            Counter = -1;
        }

        public bool MoveNext()
        {
            ++Counter;
            if (_collection.Count > Counter)
                return true;
            return false;
        }

        public void Reset()
        {
            Counter = -1;
        }
    }
}
