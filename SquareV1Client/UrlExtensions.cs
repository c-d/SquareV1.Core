﻿using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeyerCorp.Square.V1
{
    /// <summary>
    /// Extension methods which help format URLs when using an HTTP Client object.
    /// </summary>
    public static class UrlExtensions
    {
        /// <summary>
        /// Append date range parameters to a URI following Square V1 specification.
        /// </summary>
        /// <param name="baseUri">Uri on which to append.</param>
        /// <param name="beginTime">Begin time.</param>
        /// <param name="endTime">End time.</param>
        /// <param name="beginLabel">parameter name.</param>
        /// <param name="endLabel">parameter name.</param>
        /// <returns>New uri with date-range parameters included with values.</returns>
        public static Uri AppendDateRange(this Uri baseUri, string beginLabel, DateTime? beginTime, string endLabel, DateTime? endTime)
        {
            const string format = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffK";

            var parameters = new List<string>();

            if (beginTime.HasValue)
            {
                parameters.Add(beginLabel);
                parameters.Add(beginTime.Value.ToUniversalTime().ToString(format));
            }

            if (endTime.HasValue)
            {
                parameters.Add(endLabel);
                parameters.Add(endTime.Value.ToUniversalTime().ToString(format));
            }

            return baseUri.AppendParameters(parameters.ToArray());
        }

        /// <summary>
        /// Append date range parameters to a URI following Square V1 specification.
        /// </summary>
        /// <param name="baseUri">Uri on which to append.</param>
        /// <param name="beginTime">Begin time.</param>
        /// <param name="endTime">End time.</param>
        /// <param name="listOrder">Ascending or descending. Descending is default.</param>
        /// <returns>New uri with date-range parameters included with values.</returns>
        public static Uri AppendOrderOrLimit(this Uri baseUri, short? limit, ListOrderType? listOrder)
        {
            var parameters = new List<string>();

            if (listOrder.HasValue)
            {
                parameters.Add("order");
                parameters.Add(listOrder.Value.EnumToString());
            }

            if (limit.HasValue)
            {
                parameters.Add("limit");
                parameters.Add(limit.Value.ToString());
            }

            return baseUri.AppendParameters(parameters.ToArray());
        }

        /// <summary>
        /// Append parameters to a Uri.
        /// </summary>
        /// <param name="baseUri">Uri on which to append.</param>
        /// <param name="nameValuePairs">Any number of name-value pairs. Parameters are entered as <code>"name1", "value1", "name2", "value2" ... "nameN", "valueN"</code></param>
        /// <remarks>If a parameter can be used but needs no value, enter a the name string and then an empty string for the value.
        /// A name or value parameter with a null value will cause the name value pair to be ignored even if there is a value.</remarks>
        /// <returns>New Uri with the name value pairs appended in parametric form: <code>http://mysite?name1=value1&name2=value2</code></returns>
        /// <exception cref="ArgumentException">Number of <paramref name="nameValuePairs"/> are not even.</exception>
        public static Uri AppendParameters(this Uri baseUri, params string[] nameValuePairs)
        {
            if (nameValuePairs == null || nameValuePairs.Length == 0)
                return baseUri;
            else
            {
                if (nameValuePairs.Length % 2 != 0) throw new ArgumentException();

                var output = new StringBuilder(baseUri.AbsoluteUri);

                if (!output.ToString().Contains('?'))
                    output.Append('?');
                else
                    output.Append('&');

                for (var i = 0; i < nameValuePairs.Length - 1; i += 2)
                {
                    if (!String.IsNullOrWhiteSpace(nameValuePairs[i]) || nameValuePairs[i + 1] == null)
                    {
                        if (String.IsNullOrWhiteSpace(nameValuePairs[i + 1]))
                            output.Append($"{nameValuePairs[i]}&");
                        else
                            output.Append($"{nameValuePairs[i]}={nameValuePairs[i + 1]}&");
                    }
                }

                return new Uri(output.ToString().TrimEnd('&'));
            }
        }

        /// <summary>
        /// Append any number of segments to the path of the URI.
        /// </summary>
        /// <param name="baseUri">Base URI which to attach.</param>
        /// <param name="routeValues">Any number of route segments to append in order.</param>
        /// <returns>An absolute URI.</returns>
        public static Uri Append(this Uri baseUri, params string[] routeValues)
        {
            var cleanedvalues = routeValues
                .Where(nvp => !String.IsNullOrWhiteSpace(nvp))
                .Select(nvp => nvp.Trim());

            if (cleanedvalues.Count() < 1)
                return baseUri;
            else
            {
                var joinedvalues = String.Join("/", cleanedvalues);
                var urisections = baseUri.AbsoluteUri.Split('?');
                var output = new StringBuilder(urisections[0].TrimEnd('/'));

                output.AppendFormat("/{0}", joinedvalues);

                if (urisections.Length < 1) output.AppendFormat("?{0}", urisections[1]);

                return new Uri(output.ToString());
            }
        }

        /// <summary>
        /// Exract the next URI from the response headers.
        /// </summary>
        /// <param name="response">The response containing the response headers.</param>
        /// <returns>A string representing a complete URI.</returns>
        public static string ToNextUri(this HttpOperationResponse response)
        {
            var linkheaders = response.Response.Headers.Where(h => h.Key == "Link");
            var nextlink = linkheaders.Count() < 1
                ? null
                : linkheaders.First().Value.FirstOrDefault();

            if (String.IsNullOrWhiteSpace(nextlink))
                return null;
            else
            {
                var parts = nextlink.Split(';');
                var next = parts[0].TrimStart('<').TrimEnd('>');

                return next;
            }
        }
    }
}