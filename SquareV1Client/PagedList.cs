using System;
using System.Collections.Generic;

namespace MeyerCorp.Square.V1
{
    public class PagedList<T>
    {
        public IList<T> List { get; set; }

        public Uri Next { get; set; }
    }
}
