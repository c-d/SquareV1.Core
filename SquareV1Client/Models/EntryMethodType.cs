namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// The method with which a form of tender was entered.
    /// </summary>
    public enum EntryMethodType
    {
        /// <summary>
        /// The payment information was entered manually.
        /// </summary>
        Manual = 0,

        /// <summary>
        /// The payment information was scanned via barcode.
        /// </summary>
        Scanned,

        /// <summary>
        /// The payment was made via Square Cash.
        /// </summary>
        SquareCash,

        /// <summary>
        /// The payment was made via Square Wallet.
        /// </summary>
        SquareWallet,

        /// <summary>
        /// The payment card was swiped through a card reader.
        /// </summary>
        Swiped,

        /// <summary>
        /// The payment was made via a web form.
        /// </summary>
        WebForm,

        /// <summary>
        /// The payment information was obtained by a method that does not match any other value.
        /// </summary>
        Other,
    }
}