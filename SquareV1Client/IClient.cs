using MeyerCorp.Square.V1.Models;
using Microsoft.Rest;
using Newtonsoft.Json;
using System;

namespace MeyerCorp.Square.V1
{
    public partial interface IClient : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IPaymentOperations.
        /// </summary>
        IPaymentOperations PaymentOperations { get; }

        /// <summary>
        /// Gets the ILocationOperations.
        /// </summary>
        ILocationOperations LocationOperations { get; }

        IBusinessOperations BusinessOperations { get; }

    }
}
