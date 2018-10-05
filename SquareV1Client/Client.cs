using MeyerCorp.Square.V1.Batching;
using MeyerCorp.Square.V1.Business;
using MeyerCorp.Square.V1.Item;
using MeyerCorp.Square.V1.Subscription;
using MeyerCorp.Square.V1.Transaction;
using MeyerCorp.Square.V1.Webhooks;
using Microsoft.Rest;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace MeyerCorp.Square.V1
{
    public partial class Client : ServiceClient<Client>, IClient, IDisposable
    {
        /// <summary> The base URI of the service. </summary>
        public Uri BaseUri { get; set; } = new Uri("https://connect.squareup.com/v1/");

        /// <summary>
        /// Initializes a new instance of the Client public class.
        /// </summary>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected Client(params DelegatingHandler[] handlers) : base(handlers) { Initialize(); }

        /// <summary>
        /// Initializes a new instance of the Client public class.
        /// </summary>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected Client(HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : base(rootHandler, handlers) { Initialize(); }

        /// <summary>
        /// Initializes a new instance of the Client public class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected Client(Uri baseUri, params DelegatingHandler[] handlers) : this(handlers)
        {
            BaseUri = baseUri ?? throw new ArgumentNullException("baseUri");
        }

        /// <summary>
        /// Initializes a new instance of the Client public class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        protected Client(Uri baseUri, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            BaseUri = baseUri ?? throw new ArgumentNullException("baseUri");
        }

        /// <summary>
        /// Initializes a new instance of the Client public class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public Client(ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            Credentials = credentials ?? throw new ArgumentNullException("credentials");
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the Client public class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public Client(ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            Credentials = credentials ?? throw new ArgumentNullException("credentials");
            if (Credentials != null)
            {
                Credentials.InitializeServiceClient(this);
            }
        }

        /// <summary>
        /// Initializes a new instance of the Client public class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public Client(Uri baseUri, ServiceClientCredentials credentials, params DelegatingHandler[] handlers) : this(handlers)
        {
            BaseUri = baseUri ?? throw new ArgumentNullException("baseUri");
            Credentials = credentials ?? throw new ArgumentNullException("credentials");

            if (Credentials != null) { Credentials.InitializeServiceClient(this); }
        }

        /// <summary>
        /// Initializes a new instance of the Client public class.
        /// </summary>
        /// <param name='baseUri'>
        /// Optional. The base URI of the service.
        /// </param>
        /// <param name='credentials'>
        /// Required. Subscription credentials which uniquely identify client subscription.
        /// </param>
        /// <param name='rootHandler'>
        /// Optional. The http client handler used to handle http transport.
        /// </param>
        /// <param name='handlers'>
        /// Optional. The delegating handlers to add to the http client pipeline.
        /// </param>
        public Client(Uri baseUri, ServiceClientCredentials credentials, HttpClientHandler rootHandler, params DelegatingHandler[] handlers) : this(rootHandler, handlers)
        {
            BaseUri = baseUri ?? throw new ArgumentNullException("baseUri");
            Credentials = credentials ?? throw new ArgumentNullException("credentials");
            if (Credentials != null) { Credentials.InitializeServiceClient(this); }
        }

        /// <summary>
        /// Initializes client properties.
        /// </summary>
        private void Initialize()
        {
            PaymentOperations = new PaymentOperations(this);
            LocationOperations = new LocationOperations(this);
            BusinessOperations = new BusinessOperations(this);
            RoleOperations = new RoleOperations(this);
            EmployeeOperations = new EmployeeOperations(this);
            WebhookOperations = new WebhookOperations(this);
            ItemOperations = new ItemOperations(this);
            RefundOperations = new RefundOperations(this);
            SettlementOperations = new SettlementOperations(this);
            SubscriptionOperations = new SubscriptionOperations(this);
            PlanOperations = new PlanOperations(this);
            CategoryOperations = new CategoryOperations(this);
            CellOperations = new CellOperations(this);
            DiscountOperations = new DiscountOperations(this);
            FeeOperations = new FeeOperations(this);
            InventoryOperations = new InventoryOperations(this);
            ModifierListOperations = new ModifierListOperations(this);
            ModifierOptionOperations = new ModifierOptionOperations(this);
            PageOperations = new PageOperations(this);
            VariationOperations = new VariationOperations(this);
            CashDrawerShiftOperations = new CashDrawerShiftOperations(this);
            TimecardOperations = new TimecardOperations(this);
            BatchOperations = new BatchOperations(this);

            SerializationSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                {
                    new Iso8601TimeSpanConverter()
                }
            };

            DeserializationSettings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
                ContractResolver = new ReadOnlyJsonContractResolver(),
                Converters = new List<JsonConverter>
                {
                    new Iso8601TimeSpanConverter()
                }
            };
        }

        /// <summary>
        /// Subscription credentials which uniquely identify client subscription.
        /// </summary>
        public ServiceClientCredentials Credentials { get; private set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        public JsonSerializerSettings SerializationSettings { get; private set; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        public JsonSerializerSettings DeserializationSettings { get; private set; }

        public IPaymentOperations PaymentOperations { get; private set; }

        public ILocationOperations LocationOperations { get; private set; }

        public IBusinessOperations BusinessOperations { get; private set; }

        public IRoleOperations RoleOperations { get; private set; }

        public IEmployeeOperations EmployeeOperations { get; private set; }

        public IWebhookOperations WebhookOperations { get; private set; }

        public IItemOperations ItemOperations { get; private set; }

        public IRefundOperations RefundOperations { get; private set; }

        public ISettlementOperations SettlementOperations { get; private set; }

        public ISubscriptionOperations SubscriptionOperations { get; private set; }

        public IPlanOperations PlanOperations { get; private set; }

        public ICategoryOperations CategoryOperations { get; private set; }

        public ICellOperations CellOperations { get; private set; }

        public IDiscountOperations DiscountOperations { get; private set; }

        public IFeeOperations FeeOperations { get; private set; }

        public IInventoryOperations InventoryOperations { get; private set; }

        public IModifierListOperations ModifierListOperations { get; private set; }

        public IModifierOptionOperations ModifierOptionOperations { get; private set; }

        public IPageOperations PageOperations { get; private set; }

        public IVariationOperations VariationOperations { get; private set; }

        public ICashDrawerShiftOperations CashDrawerShiftOperations { get; private set; }

        public ITimecardOperations TimecardOperations { get; private set; }

        public IBatchOperations BatchOperations { get; private set; }
    }
}
