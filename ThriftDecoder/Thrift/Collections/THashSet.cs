using System;
using System.Collections.Generic;
using System.Collections;

namespace ThriftDecoder.Thrift.Collections
{
    public class THashSet<T> : IEnumerable, IEnumerable<T>, ICollection<T>
    {
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return ((IEnumerable<T>)this.set).GetEnumerator();
        }

        public int Count
        {
            get
            {
                return this.set.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Add(T item)
        {
            this.set.Add(item);
        }

        public void Clear()
        {
            this.set.Clear();
        }

        public bool Contains(T item)
        {
            return this.set.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this.set.CopyTo(array, arrayIndex);
        }

        public IEnumerator GetEnumerator()
        {
            return this.set.GetEnumerator();
        }

        public bool Remove(T item)
        {
            return this.set.Remove(item);
        }

        private HashSet<T> set = new HashSet<T>();
    }
}
