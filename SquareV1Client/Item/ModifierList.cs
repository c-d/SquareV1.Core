using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeyerCorp.Square.V1.Item
{
    public class ModifierList
    {
        /// <summary>
        /// The modifier list's unique ID.


        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The modifier list's name.


        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The options included in the modifier list.
        /// </summary>
        [JsonProperty(PropertyName = "modifier_options")]
        public IEnumerable<ModifierOption> ModifierOptions{ get; set; }

        /// <summary>
        /// Indicates whether MULTIPLE options or a SINGLE option from the modifier list can be applied to a single item.
        /// </summary>
        public ModifierListSelectionType PricingType
        {
            get { return ModifierListSelectionTypeString.ToModifierListSelectionType(); }
            set {ModifierListSelectionTypeString = value.EnumToString(); }
        }

        [JsonProperty(PropertyName = "selection_type")]
        protected string ModifierListSelectionTypeString { get; set; }
    }
}
