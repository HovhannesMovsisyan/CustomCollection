using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace CustomCollection
{
    public class OrderedCollection<T> : ICollection<T> where T : IComparable
    {
        public OrderedCollection() => List = new List<T>();

        protected List<T> List { get; }

        public T this[int index]
        {
            get
            {
                try
                {
                    return List[index];
                }
                catch (IndexOutOfRangeException)
                {
                    throw;
                }
            }
        }

        public int Count => List.Count;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            if (item is null)
                return;

            List.Add(item);
        }

        //The Method we needed...
        public List<T> AddMember(T item)
        {
            if (item is null)
                throw new ArgumentNullException(nameof(item));

            List.Add(item);
            try
            {
                List.Sort();
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            

            return List;
        }

        public void Clear() => List.Clear();

        public bool Contains(T item) => List.Contains(item);

        public IEnumerator<T> GetEnumerator() => List.GetEnumerator();

        public bool Remove(T item)
        {
            if (item is null && !Contains(item))
                return false;

            return List.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator() => List.GetEnumerator();

        public void CopyTo(T[] array, int arrayIndex) => List.CopyTo(array, arrayIndex);
    }
}