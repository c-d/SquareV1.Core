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
    public class ActiveEnumerable<T> : IEnumerable<T>
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
        /// Return an active enumerator.
        /// </summary>
        /// <returns>An active enumerator capable of continous GET request to return continuing data from a GET request.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new ActiveEnumerator<T>(Collection, Operations, InitialUri, NextUri, IsContinous, CancellationToken);
        }

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