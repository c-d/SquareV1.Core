namespace MeyerCorp.Square.V1.Item
{
    /// <summary>
    /// Indicates the color of an item's label color in Square Point of Sale, in six-character hexadecimal format. Colors other than those listed are not supported.
    /// </summary>
    public enum ItemColorType
    {
        /// <summary>
        /// A gray color.
        /// </summary>
        Gray = 0x9da2a6,

        /// <summary>
        /// A lighter green color.
        /// </summary>
        LightGreen = 0x4ab200,

        /// <summary>
        /// A darker green color.
        /// </summary>
        DarkGreen = 0x0b8000,

        /// <summary>
        /// A lighter blue color.
        /// </summary>
        LightBlue = 0x13b1bf,

        /// <summary>
        /// A darker blue color.
        /// </summary>
        DarkBlue = 0x2952cc,

        /// <summary>
        /// A purple color.
        /// </summary>
        Purple = 0xa82ee5,

        /// <summary>
        /// A lighter red color.
        /// </summary>
        LightRed = 0xe5457a,

        /// <summary>
        /// A dark red color.
        /// </summary>
        DarkRed = 0xb21212,

        /// <summary>
        /// A gold color.
        /// </summary>
        Gold = 0xe5BF00,

        /// <summary>
        /// A brown color.
        /// </summary>
        Brown = 0x593c00,
    }
}
