namespace MeyerCorp.Square.V1.Subscription
{
    /// <summary>
    /// The form of payment used for a merchant's subscription.
    /// </summary>
    public enum SubscriptionsPaymentMethodType
    {
        /// <summary>
        /// A credit card on file.
        /// </summary>
        Active,

        /// <summary>
        /// Payment is withdrawn from the merchant's bank account as part of the standard merchant settlement process.
        /// </summary>
        InGrace,

        /// <summary>
        /// The merchant used a payment method that does not match any other value.
        /// </summary>
        Delinquent
    }
}