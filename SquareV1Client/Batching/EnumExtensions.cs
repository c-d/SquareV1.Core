using System;

namespace MeyerCorp.Square.V1.Batching
{
    /// <summary>
    /// Helper methods which make conversion of enum to and from string values required for HTTP/JSON more convenient.
    /// </summary>
    public static class EnumExtensions
    {
        //public static string EnumToString(this RangeOrderType type)
        //{
        //    switch (type)
        //    {
        //        case RangeOrderType.Ascending:
        //            return "ASC";
        //        case RangeOrderType.Descending:
        //            return "DESC";
        //        default:
        //            throw new ArgumentOutOfRangeException();
        //    }
        //}

        //public static RangeOrderType ToDateRangeOrderType(this string value)
        //{
        //    switch (value)
        //    {
        //        case "ASC":
        //            return RangeOrderType.Ascending;
        //        case "DESC":
        //            return RangeOrderType.Descending;
        //        default:
        //            throw new ArgumentOutOfRangeException();
        //    }
        //}
    }
}