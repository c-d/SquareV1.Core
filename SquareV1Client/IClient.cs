using MeyerCorp.Square.V1.Batching;
using MeyerCorp.Square.V1.Business;
using MeyerCorp.Square.V1.Item;
using MeyerCorp.Square.V1.Subscription;
using MeyerCorp.Square.V1.Transaction;
using MeyerCorp.Square.V1.Webhooks;
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

        IRoleOperations RoleOperations { get; }

        IItemOperations ItemOperations { get; }

        IWebhookOperations WebhookOperations { get; }

        IRefundOperations RefundOperations { get; }

        ISettlementOperations SettlementOperations { get; }

        ISubscriptionOperations SubscriptionOperations { get; }

        IPlanOperations PlanOperations { get; }

        ICategoryOperations CategoryOperations { get; }

        ICellOperations CellOperations { get; }

        IDiscountOperations DiscountOperations { get; }

        IFeeOperations FeeOperations { get; }

        IInventoryOperations InventoryOperations { get; }

        IModifierListOperations ModifierListOperations { get; }

        IModifierOptionOperations ModifierOptionOperations { get; }

        IPageOperations PageOperations { get; }

        IVariationOperations VariationOperations { get; }

        ICashDrawerShiftOperations CashDrawerShiftOperations { get; }

        IEmployeeOperations EmployeeOperations { get; }

        ITimecardOperations TimecardOperations { get; }

        IBatchOperations BatchOperations { get; }
    }
}
