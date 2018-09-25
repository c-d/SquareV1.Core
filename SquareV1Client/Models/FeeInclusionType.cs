namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Indicates whether a fee applied to an item is additive or inclusive.
    /// </summary>
    /// <remarks>
    /// <list type="bullet"> 
    /// <item>  
    /// <term>Additive fees</term>  
    /// <description>are added on top of the price of items they're applied to. If an additive 10% fee is applied to a $100 item, the total is $110.</description>  
    /// </item>   
    /// <item>  
    /// <term>Inclusive fees</term>  
    /// <description>are assumed to already be included in the price of the items they apply to. If an inclusive 10% fee is applied to a $100 item, the total is $100, and the actual base cost of the item is assumed to be $90.91. This affects the amount of any additive fees that are also applied to the item.</description>  
    /// </item>  
    /// </list>
    /// </remarks>
    public enum FeeInclusionType
    {
        /// <summary>
        /// The fee is an additive fee.
        /// </summary>
        Additive = 0,

        /// <summary>
        /// The fee is an inclusive fee.
        /// </summary>
        Inclusive ,
    }
}