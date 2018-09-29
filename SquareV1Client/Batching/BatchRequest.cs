using Newtonsoft.Json;

namespace MeyerCorp.Square.V1.Batching
{
    /// <summary>
    /// Represents a single request included in a call to the Submit Batch endpoint.
    /// </summary>
    public class BatchRequest
    {
        /// <summary>
        /// The HTTP method of the request(DELETE, GET, POST, or PUT).
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public RequestMethodType Method { get; set; }

        /// <summary>
        /// The path of the request's endpoint, relative to  https://connect.squareup.com.
        /// </summary>
        /// <remarks>
        /// For example, this value is /v1/MERCHANT_ID/payments for the List Payments endpoint(with the proper merchant ID).
        /// For GET and DELETE requests, include any request parameters in a query string appended to the path(for example,  /v1/MERCHANT_ID/payments? order = DESC).
        /// </remarks>
        [JsonProperty(PropertyName = "relative_path")]
        public string RelativePath { get; set; }

        /// <summary>
        /// The access token to use for the request.This can be a personal access token or an access token generated with the OAuth API.
        /// </summary>
        [JsonProperty(PropertyName = "access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// The body of the request, if any.Include parameters for POST and PUT requests here.
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public object Body { get; set; }

        /// <summary>
        /// An optional identifier for the request, returned in the request's corresponding  BatchResponse.  }
        /// </summary>
        [JsonProperty(PropertyName = "request_id")]
        public string RequestId { get; set; }
    }
}