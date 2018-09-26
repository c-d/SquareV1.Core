namespace MeyerCorp.Square.V1.Business
{
    /// <summary>
    /// The type of event that caused a merchant's cash drawer to open.
    /// </summary>
    public enum CashDrawerEventType
    {
        /// <summary>
        /// An employee opened the cash drawer by performing a "No Sale" operation. This also creates a zero-value payment.
        /// </summary>
        NoSale,

        /// <summary>
        /// An employee processed a cash payment.
        /// </summary>
        CashTenderPayment,

        /// <summary>
        /// An employee processed a payment with the OTHER tender type.
        /// </summary>
        OtherTenderPayment,

        /// <summary>
        /// An employee began to process a cash payment that was subsequently canceled.
        /// </summary>
        CashTenderCanceledPayment,

        /// <summary>
        /// An employee began to process a payment with the OTHER tender type that was subsequently canceled.
        /// </summary>
        OtherTenderCanceledPayment,

        /// <summary>
        /// An employee processed a refund for a cash payment.
        /// </summary>
        CashTenderRefund,

        /// <summary>
        /// An employee processed a refund for a payment with the OTHER tender type.
        /// </summary>
        OtherTenderRefund,

        /// <summary>
        /// Money was added to the cash drawer for a non-payment reason (such as to restock it).
        /// </summary>
        PaidIn,

        /// <summary>
        /// Money was removed from the cash drawer for a non-refund reason (such as to pay a delivery person).
        /// </summary>
        PaidOut
    }
}
