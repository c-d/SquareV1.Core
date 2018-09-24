using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MeyerCorp.Square.V1.Models
{
    public class EmployeeRole
    {
        /// <summary>
        /// The role's unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        string Id { get; set; }

        /// <summary>
        /// The role's merchant-defined name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        string Name { get; set; }

        /// <summary>
        /// The permissions that the role has been granted.
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        IEnumerable<EmployeeRolePermission> Permissions { get; set; }

        /// <summary>
        /// If true, employees with this role have all permissions, regardless of the values indicated in permissions.
        /// </summary>
        [JsonProperty(PropertyName = "is_owner")]
        bool IsOwner { get; set; }

        /// <summary>
        /// The time when the employee entity was created, in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "created_at")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The time when the employee entity was most recently updated, in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "updated_at")]
        public DateTime Updated { get; set; }
    }
}