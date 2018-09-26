namespace MeyerCorp.Square.V1.Subscription
{
    /// <summary>
    /// The status of a merchant's subscription.
    /// </summary>
    public enum SubscriptionsStatusType
    {
        /// <summary>
        /// The merchant has an active, fully paid subscription.
        /// </summary>
        Active,

        /// <summary>
        /// The merchant's automatic monthly subscription payment failed (possibly due to an invalid payment method). The merchant is in a fifteen-day grace period, during which their subscription is considered active.
        /// </summary>
        InGrace,

        /// <summary>
        /// The merchant's subscription has become inactive because the merchant did not successfully pay the subscription fee by the end of the fifteen-day grace period.
        /// </summary>
        /// <remarks>
        /// This value is no longer returned by the Connect API. Delinquent subscriptions are now returned as CANCELED.
        /// </remarks>
        Delinquent,

        /// <summary>
        /// The merchant's subscription was canceled.
        /// </summary>
        Canceled,

        /// <summary>
        /// The merchant's subscription was terminated.
        /// </summary>
        Terminated,

        /// <summary>
        /// The subscription has a status that does not match any other value.
        /// </summary>
        Other
    }
}