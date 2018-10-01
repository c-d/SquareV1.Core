using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace MeyerCorp.Square.V1
{
    /// <summary>
    /// Typed list which yeilds an active enumerator.
    /// </summary>
    /// <remarks>
    /// If the Is Continous flag is set and this enumerator can no longer move next, it checks its next URI property and if available, it calls that in a GET request.
    /// The resulting data is now used as the new internal collection, the next URI is replaced with the new next URI and the current property is set to the first item in the new collection.
    /// This repeats until there is no next URI returned. This allows the ActiveList object to seamlessly enumerate over all possible data regardless of how many GET requests are required.
    /// </remarks>
    /// <typeparam name="T"></typeparam>
    public class ActiveList<T> : IList<T>
    {
        /// <summary>
        /// Collection which to base this list upon.
        /// </summary>
        internal IList<T> Collection { get; set; }

        /// <summary>
        /// The initial URI used by the Active Enumerator.
        /// </summary>
        internal string InitialUri { get; set; }

        /// <summary>
        /// The next URI used by the Active Enumerator.
        /// </summary>
        internal string NextUri { get; set; }

        /// <summary>
        /// The operations object used by the Active Enumerator.
        /// </summary>
        internal IOperations Operations { get; set; }

        /// <summary>
        /// Cancellation token.
        /// </summary>
        internal CancellationToken CancellationToken { get; set; } = default(CancellationToken);
        internal bool IsContinous { get; set; }

        /// <summary>
        /// Indexer.
        /// </summary>
        /// <param name="index">Collection index to return.</param>
        /// <returns>Item at the <paramref name="index"/>.</returns>
        public T this[int index] { get => Collection[index]; set => Collection[index] = value; }

        /// <summary>
        /// Number of items in the collection.
        /// </summary>
        public int Count => Collection.Count;

        /// <summary>
        /// This is a read-only collection.
        /// </summary>
        public bool IsReadOnly => true;

        /// <summary>
        /// Not supported.
        /// </summary>
        /// <param name="item">Item to add.</param>
        /// <exception cref="NotSupportedException"></exception>
        public void Add(T item) { throw new NotSupportedException(); }

        /// <summary>
        /// Not supported.
        /// </summary>
        /// <exception cref="NotSupportedException"></exception>
        public void Clear() { throw new NotSupportedException(); }

        /// <summary>
        /// Determines if the collection contains a certain item.
        /// </summary>
        /// <param name="item">Item in question.</param>
        /// <returns>Whether it contains the item or not.</returns>
        public bool Contains(T item) { throw new NotImplementedException(); }

        /// <summary>
        /// Copy to another collection.
        /// </summary>
        /// <param name="array">Array to coppy to.</param>
        /// <param name="arrayIndex">Starting index.</param>
        public void CopyTo(T[] array, int arrayIndex) { Collection.CopyTo(array, arrayIndex); }

        /// <summary>
        /// Return an active enumerator.
        /// </summary>
        /// <returns>An active enumerator capable of continous GET request to return continuing data from a GET request.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new ActiveEnumerator<T>(Collection, Operations, InitialUri, NextUri, IsContinous, CancellationToken);
        }

        /// <summary>
        /// Return the index of a particular item.
        /// </summary>
        /// <param name="item">Item in question.</param>
        /// <returns>Index of <paramref name="item"/></returns>
        public int IndexOf(T item) { return Collection.IndexOf(item); }

        /// <summary>
        /// Not supported.
        /// </summary>
        /// <param name="index">Index at which to insert <paramref name="item"/></param>
        /// <param name="item">Item to insert.</param>
        /// <exception cref="NotSupportedException"></exception>
        public void Insert(int index, T item) { throw new NotSupportedException(); }

        /// <summary>
        /// Not supported
        /// </summary>
        /// <param name="item">Item to remove.</param>
        /// <returns>
        /// true if item was successfully removed, otherwise, false. This method also returns false if item is not found in the collection.
        /// </returns>
        /// <exception cref="NotSupportedException"></exception>
        public bool Remove(T item) { throw new NotSupportedException(); }

        /// <summary>
        /// Not supported.
        /// </summary>
        /// <param name="index">Index of item to remove.</param>
        public void RemoveAt(int index) { Collection.RemoveAt(index); }

        /// <summary>
        /// Return an active enumerator.
        /// </summary>
        /// <returns>An active enumerator capable of continous GET request to return continuing data from a GET request.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new ActiveEnumerator<T>(Collection, Operations, InitialUri, NextUri, IsContinous, CancellationToken);
        }
    }
}