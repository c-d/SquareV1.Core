using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Item
{
    public class CellOperations : Operations, ICellOperations
    {
        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public CellOperations(Client client) : base(client) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns>https://connect.squareup.com/v1/{{location_id}}/payments</returns>
        protected override Uri GetUri(params string[] values)
        {
            switch (values.Length)
            {
                case 1: return BaseUri.Append(values[0], "pages", values[1], "cells");
                default: throw new ArgumentException();
            }
        }

        public Task<HttpOperationResponse> PutWithHttpMessagesAsync(string locationId, string pageId, PageCell value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId, pageId);

            return PutWithHttpMessagesAsync<PageCell>(uri, value, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string locationId, string pageId, short row, short column, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId, pageId)
                .AppendParameters("row", row.ToString(), "column", row.ToString());

            return DeleteWithHttpMessagesAsync<PageCell>(uri, customHeaders, cancellationToken);
        }
    }
}