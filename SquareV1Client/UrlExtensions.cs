﻿using System;
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
        /// <param name="dateRangeOrder">Ascending or descending. Descending is default.</param>
        /// <returns>New uri with date-range parameters included with values.</returns>
        public static Uri AppendDateRange(this Uri baseUri, DateTime beginTime, DateTime endTime, DateRangeOrderType dateRangeOrder = DateRangeOrderType.Descending)
        {
            const string format = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffK";

            return baseUri.Append("begin_time", beginTime.ToUniversalTime().ToString(format), "end_time", endTime.ToUniversalTime().ToString(format), "order", dateRangeOrder.EnumToString());
        }

        /// <summary>
        /// Append parameters to a Uri.
        /// </summary>
        /// <param name="baseUri">Uri on which to append.</param>
        /// <param name="nameValuePairs">Any number of name-value pairs. Parameters are entered as <code>"name1", "value1", "name2", "value2" ... "nameN", "valueN"</code></param>
        /// <remarks>If a parameter can be used but needs no value, enter a the name string and then a null for the value.
        /// A name parameter with a null value will cause the name value pair to be ignored even if there is a value.</remarks>
        /// <returns>New Uri with the name value pairs appended in parametric form: <code>http://mysite?name1=value1&name2=value2</code></returns>
        /// <exception cref="ArgumentException">Number of <paramref name="nameValuePairs"/> are not even.</exception>
        public static Uri Append(this Uri baseUri, params string[] nameValuePairs)
        {
            if (nameValuePairs == null || nameValuePairs.Length == 0)
                return baseUri;
            else
            {
                if (nameValuePairs.Length % 2 != 0) throw new ArgumentException();

                var output = new StringBuilder(baseUri.AbsoluteUri);

                output.Append('?');

                for (var i = 0; i < nameValuePairs.Length - 1; i += 2)
                {
                    if (!String.IsNullOrWhiteSpace(nameValuePairs[i]))
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
    }
}