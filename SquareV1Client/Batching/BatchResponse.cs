using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace MeyerCorp.Square.V1.Batching
{
    /// <summary>
    /// Represents the response for a request included in a call to the Submit Batch endpoint.
    /// </summary>
    public class BatchResponse
    {
        /// <summary>
        /// The response's HTTP status code.
        /// </summary>
        [JsonProperty(PropertyName = "status_code")]
        public HttpStatusCode StatusCode { get; set; }

        /// <summary>
        /// Contains any important headers for the response, indexed by header name.For example, if the response includes a pagination header, the header's value is available from headers["Link"].
        /// </summary>
        [JsonProperty(PropertyName = "headers")]
        public IEnumerable<string> Headers { get; set; }

        /// <summary>
        /// The body of the response, if any.
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public string Body { get; set; }

        /// <summary>
        /// The value you provided for request_id in the corresponding BatchRequest, if any.
        /// </summary>
        [JsonProperty(PropertyName = "request_id")]
        public string RequestId { get; set; }
    }
}
