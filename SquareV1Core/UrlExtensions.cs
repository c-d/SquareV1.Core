using System;
using System.Text;

namespace Meyer.Square.V1
{
    public static class UrlExtensions
    {
        public static Uri AppendDateRange(this Uri baseUri, DateTime beginTime, DateTime endTime, DateRangeOrderType dateRangeOrder = DateRangeOrderType.Descending)
        {
            const string format = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffK";

            return baseUri.Append("begin_time", beginTime.ToUniversalTime().ToString(format), "end_time", endTime.ToUniversalTime().ToString(format), "order", dateRangeOrder.EnumToString());
        }

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
