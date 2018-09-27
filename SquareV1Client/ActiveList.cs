using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace MeyerCorp.Square.V1
{
    public class ActiveList<T> : IList<T>
    {
        internal IList<T> Collection { get; set; }
        internal string InitialUri { get; set; }
        internal string NextUri { get; set; }
        internal IOperations Operations { get; set; }
        internal CancellationToken CancellationToken { get; set; } = default(CancellationToken);
        internal bool IsContinous { get; set; }

        public T this[int index] { get => Collection[index]; set => Collection[index] = value; }

        public int Count => Collection.Count;

        public bool IsReadOnly => true;

        public void Add(T item) { throw new NotSupportedException(); }

        public void Clear() { throw new NotSupportedException(); }

        public bool Contains(T item) { return Collection.Contains(item); }

        public void CopyTo(T[] array, int arrayIndex) { Collection.CopyTo(array, arrayIndex); }

        public IEnumerator<T> GetEnumerator()
        {
            return new ActiveEnumerator<T>(Collection, Operations, InitialUri, NextUri, IsContinous, CancellationToken);
        }

        public int IndexOf(T item) { return Collection.IndexOf(item); }

        public void Insert(int index, T item) { Collection.Insert(index, item); }

        public bool Remove(T item) { return Collection.Remove(item); }

        public void RemoveAt(int index) { Collection.RemoveAt(index); }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ActiveEnumerator<T>(Collection, Operations, InitialUri, NextUri, IsContinous, CancellationToken);
        }
    }
}