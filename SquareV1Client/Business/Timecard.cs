using Newtonsoft.Json;
using System;

namespace MeyerCorp.Square.V1.Business
{
    /// <summary>
    /// Represents a timecard for an employee.
    /// </summary>
    public class Timecard
    {
        /// <summary>
        /// The timecard's unique ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the employee the timecard is associated with.
        /// </summary>
        [JsonProperty(PropertyName = "employee_id")]
        public string EmployeeId { get; set; }

        /// <summary>
        /// If true, the timecard was deleted by the merchant, and it is no longer valid.
        /// </summary>
        [JsonProperty(PropertyName = "deleted")]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// The time the employee clocked in, in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "clockin_time")]
        public DateTime ClockIn { get; set; }

        /// <summary>
        /// The time the employee clocked out, in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "clockout_time")]
        public DateTime ClockOut { get; set; }

        /// <summary>
        /// The ID of the Location the employee clocked in from, if any.Square uses the clockin_location_id to determine a timecard’s timezone and overtime rules.
        /// </summary>
        [JsonProperty(PropertyName = "clockin_location_id")]
        public string ClockInLocationId { get; set; }

        /// <summary>
        /// The ID of the Location the employee clocked out from, if any.
        /// </summary>
        [JsonProperty(PropertyName = "clockout_location_id")]
        public string ClockOutLocationId { get; set; }

        /// <summary>
        /// The total number of regular (non-overtime) seconds worked in the timecard.
        /// </summary>
        [JsonProperty(PropertyName = "regular_seconds_worked")]
        public long RegularSecondWorked { get; set; }

        /// <summary>
        /// The total number of overtime seconds worked in the timecard.
        /// </summary>
        [JsonProperty(PropertyName = "overtime_seconds_worked")]
        public long OvertimeSecondsWorked { get; set; }

        /// <summary>
        /// The total number of doubletime seconds worked in the timecard.
        /// </summary>
        [JsonProperty(PropertyName = "doubletime_seconds_worked")]
        public long DoubleTimeSecondsWorked { get; set; }

        /// <summary>
        /// The time when the timecard was created, in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "created_at")]
        public DateTime Created { get; set; }

        /// <summary>
        /// The time when the timecard was most recently updated, in ISO 8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "updated_at")]
        public DateTime Updated { get; set; }
    }
}
