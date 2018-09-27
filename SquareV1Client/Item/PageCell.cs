using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Item
{
    /// <summary>
    /// Represents a cell of a Page.
    /// </summary>
    public class PageCell
    {
        /// <summary>
        /// The unique identifier of the page the cell is included on.
        /// </summary>
        [JsonProperty(PropertyName = "page_id")]
        public string PageId { get; set; }

        /// <summary>
        /// The row of the cell.Always an integer between 0 and 4, inclusive.
        /// </summary>
        [JsonProperty(PropertyName = "row")]
        public short Row { get; set; }

        /// <summary>
        /// The column of the cell.Always an integer between 0 and 4, inclusive.
        /// </summary>
        [JsonProperty(PropertyName = "column")]
        public short Column { get; set; }

        /// <summary>
        /// The type of entity represented in the cell (ITEM, DISCOUNT, CATEGORY, or PLACEHOLDER).
        /// </summary>
        public PageCellType ObjectType
        {
            get { return ObjectTypeString.ToPageCellType(); }
            set { ObjectTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "object_type")]
        protected string ObjectTypeString { get; set; }


        /// <summary>
        /// The unique identifier of the entity represented in the cell. Not present for cells with an object_type of PLACEHOLDER.
        /// </summary>
        [JsonProperty(PropertyName = "object_id")]
        public string ObjectId { get; set; }

        /// <summary>
        /// For a cell with an object_type of PLACEHOLDER, this value indicates the cell's special behavior.    }
        /// </summary>
        public PageCellPlaceholderType PlaceholderType
        {
            get { return PageCellPlaceholderTypeString.ToPageCellPlaceholderType(); }
            set { PageCellPlaceholderTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "placeholder_type")]
        protected string PageCellPlaceholderTypeString { get; set; }

    }
}
