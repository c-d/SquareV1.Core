using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MeyerCorp.Square.V1.Business
{
    /// <summary>
    /// Represents a role that can be assigned to one or more employees. An employee's role indicates which permissions they have.
    /// </summary>
    public class Role
    {
        /// <summary>
        /// The role's unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The role's merchant-defined name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// The permissions that the role has been granted.
        /// </summary>
        public IEnumerable<EmployeeRolePermissionType> Permissions
        {
            get { return EmployeeRolePermissionTypeStrings.Select(erpt => erpt.ToEmployeeRolePermissionType()); }
            set { EmployeeRolePermissionTypeStrings = value.Select(v => v.EnumToString()); }
        }

        [JsonProperty(PropertyName = "permissions")]
        protected IEnumerable<string> EmployeeRolePermissionTypeStrings { get; set; }

        /// <summary>
        /// If true, employees with this role have all permissions, regardless of the values indicated in permissions.
        /// </summary>
        [JsonProperty(PropertyName = "is_owner")]
        public bool IsOwner { get; set; }

        /// <summary>
        /// The time when the role was created, in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "created_at")]
        public string Created { get; set; }

        /// <summary>
        /// The time when the role was most recently updated, in ISO 8601 format.}
        /// </summary>
        [JsonProperty(PropertyName = "updated_at")]
        public DateTime Updated { get; set; }
    }
}
