using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1
{
    /// <summary>
    /// An enumerator that allow continous loading of the next data set from a GET request for the Square V1 API.
    /// </summary>
    /// <typeparam name="T">Item type of the collection returned by the GET request.</typeparam>
    /// <remarks>
    /// Of the Is Continous flag is set, this enumerator can no longer move next, it checks its next URI property and if available, it calls that in a GET request.
    /// The resulting data is now used as the new internal collection, the next URI is replaced with the new next URI and the current is set to the first item in the new collection.
    /// This repeats until there is no next URI returned. This allows the ActiveList object to seamlessly enumerate over all possible data regardless of how many GET requests are required.
    /// </remarks>
    public class ActiveEnumerator<T> : IEnumerator<T>
    {
        IEnumerator<T> _Enumerator;
        Uri _InitialUri;
        string _NextUri;
        IEnumerable<T> _Collection;

        readonly bool _IsContinuous;
        readonly IOperations _Operations;
        readonly CancellationToken _CancellationToken;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="collection">Initial collection from which this enumerator was begat.</param>
        /// <param name="operations">Operations object which performs the HTTP GET on the URI.</param>
        /// <param name="nextUri">URI which will yeild the next set of data from the inital URI request.</param>
        /// <param name="isContinous">Set to request the enumerator to continue yeilding data until there is no next URI returned from the API endpoint call.</param>
        /// <param name="cancellationToken">Standard cancellation token.</param>
        public ActiveEnumerator(IEnumerable<T> collection, IOperations operations, string initialUri, string nextUri, bool isContinous = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            _Collection = collection;
            _Operations = operations;
            _NextUri = nextUri;
            _InitialUri = new Uri(initialUri);
            _CancellationToken = cancellationToken;
            _IsContinuous = isContinous;

            _Enumerator = _Collection.GetEnumerator();
        }

        /// <summary>
        /// Curent item.
        /// </summary>
        public T Current => _Enumerator.Current;

        /// <summary>
        /// Curent item.
        /// </summary>
        object IEnumerator.Current => _Enumerator.Current;

        /// <summary>
        /// Dispose.
        /// </summary>
        public void Dispose() { if (_Enumerator != null) _Enumerator.Dispose(); }

        /// <summary>
        /// Move current to next item in enumeration.
        /// </summary>
        /// <returns>True if there is another item available and false if not. If the object is running continously, the collection and next URI fields will be set with the next set of data from the API.</returns>
        public bool MoveNext()
        {
            if (_Enumerator.MoveNext())
                return true;
            else
            {
                // If not continous, just return false when the initial collection is done.
                if (_IsContinuous)
                {
                    // If there is another Next URI value...
                    if (_NextUri == null)
                        return false;
                    else
                    {
                        // Reset the enumerator with the data from the call to the next URI field.
                        GetNewEnumerator();

                        return _Enumerator.MoveNext();
                    }
                }
                else
                    return false;
            }
        }

        /// <summary>
        /// Reset the enumerator. 
        /// </summary>
        /// <remarks>
        /// If still on the initial collection, just reset it. Otherwise, reload the collection using the inital URI.
        /// </remarks>
        public void Reset()
        {
            if (_NextUri.Equals(_InitialUri))
                _Enumerator.Reset();
            else
            {
                _NextUri = _InitialUri.AbsoluteUri;

                GetNewEnumerator();
            }
        }

        /// <summary>
        /// Reloads the enumerator fields with data from the next URI endpoint.
        /// </summary>
        void GetNewEnumerator()
        {
            var result = Task
                .Factory
                .StartNew(s => ((IOperations)s).GetWithHttpMessagesAsync<IList<T>>(new Uri(_NextUri), null, _CancellationToken), _Operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default)
                .Unwrap()
                .GetAwaiter()
                .GetResult();

            _NextUri = result.ToNextUri();
            _Collection = result.Body;
            _Enumerator = _Collection.GetEnumerator();
        }
    }
}
