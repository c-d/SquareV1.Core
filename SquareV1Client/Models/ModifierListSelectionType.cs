namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Indicates whether more than one modifier option from a single modifier list can be applied to a single item.
    /// </summary>
    public enum ModifierListSelectionType
    {
        /// <summary>
        /// Multiple options from the modifier list can be applied to a given item.
        /// </summary>
        Multiple,

        /// <summary>
        /// Only one option from the modifier list can be applied to a given item.
        /// </summary>
        Single
    }
}
