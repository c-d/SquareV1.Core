﻿using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeyerCorp.Square.V1.Item
{
    public class VariationOperations : Operations, IVariationOperations
    {
        const string _UriFormat = "{0}/payments";

        /// <summary>
        /// Initializes a new instance of the OrdersOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        public VariationOperations(Client client) : base(client) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="values"></param>
        /// <returns>https://connect.squareup.com/v1/{{location_id}}/payments</returns>
        protected override Uri GetUri(params string[] values)
        {
            switch (values.Length)
            {
                case 1: return BaseUri.Append(values[0], "payments");
                default: throw new ArgumentException();
            }
        }

        public Task<HttpOperationResponse<IList<Variation>>> GetWithHttpMessagesAsync(string locationId,
            DateTime? beginTime,
            DateTime? endTime,
            ListOrderType? listOrder,
            short? limit,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            var uri = GetUri(locationId)
                .AppendDateRange("begin_time", beginTime, "end_time",endTime)
                .AppendOrderOrLimit(limit, listOrder);

            return GetWithHttpMessagesAsync<IList<Variation>>(uri, customHeaders, cancellationToken);
        }

        public Task<HttpOperationResponse<Variation>> GetWithHttpMessagesAsync(string locationId,
            string paymentId,
            Dictionary<string, List<string>> customHeaders = null,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            return GetWithHttpMessagesAsync(locationId: locationId, paymentId: paymentId, customHeaders: customHeaders, cancellationToken: cancellationToken);
        }

        public Task<HttpOperationResponse> PostWithHttpMessagesAsync(string locationId, Variation value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotSupportedException();
        }

        public Task<HttpOperationResponse> PutWithHttpMessagesAsync(string locationId, Variation value, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotSupportedException();
        }

        public Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string locationId, string paymentId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotSupportedException();
        }
    }
}