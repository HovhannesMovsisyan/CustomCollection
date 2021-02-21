using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace CustomCollection
{
    public class MyCollection<T> : ICollection<T>
    {
        public MyCollection()
        {
            _list = new List<T>();
        }

        protected List<T> _list { get; }

        public T this[int index]
        {
            get
            {
                try
                {
                    return _list[index];
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw;
                }
                
            }
        }

        public int Count => _list.Count;

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            if (item != null)
            {
                _list.Add(item);
            }
        }

        public List<T> AddMember(T item)
        {
            if (item != null)
            {
                _list.Add(item);
            }
            var newList = _list.Concat(new[] {item}).ToList();
            _list.Sort();
            return newList;
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item) => _list.Contains(item);

        public IEnumerator<T> GetEnumerator() => new MyCollectionEnumerator<T>(this);

        public bool Remove(T item)
        {
            if (item != null && Contains(item))
            {
                _list.Remove(item);
                return true;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator() => new MyCollectionEnumerator<T>(this);

        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }
        
    }
}
