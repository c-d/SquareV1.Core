using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MeyerCorp.Square.V1.Models
{
    /// <summary>
    /// Represents one of a business' employees.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// The employee's unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The employee's first name.
        /// </summary>
        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// The employee's last name.
        /// </summary>
        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// The ids of the employee's associated roles. Currently, you can specify only one or zero roles per employee.
        /// </summary>
        [JsonProperty(PropertyName = "role_ids")]
        public IEnumerable<string> RoleIds { get; set; }

        /// <summary>
        /// The IDs of the locations the employee is allowed to clock in at.
        /// </summary>
        [JsonProperty(PropertyName = "authorized_location_ids")]
        public IEnumerable<string> AuthorizedLocationids { get; set; }

        /// <summary>
        /// The employee's email address.
        /// </summary>
        /// <remarks>
        /// You cannot edit this value with the Connect API.You can only set its initial value when creating an employee with the Create Employee endpoint.
        /// </remarks>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Whether the employee is ACTIVE or INACTIVE.Inactive employees cannot sign in to Square Point of Sale.
        /// </summary>
        /// <remarks>
        /// Merchants update this field from the Square Dashboard.You cannot modify it with the Connect API.
        /// </remarks>
        [JsonProperty(PropertyName = "status")]
        public EmployeeStatusType Status { get; set; }

        /// <summary>
        /// An ID the merchant can set to associate the employee with an entity in another system.
        /// </summary>
        /// <remarks>
        /// You cannot set this value with the Connect API.
        /// </remarks>
        [JsonProperty(PropertyName = "external_id")]
        public string ExternalId { get; set; }

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
