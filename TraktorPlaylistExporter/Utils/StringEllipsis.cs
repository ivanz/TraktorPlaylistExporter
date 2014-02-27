using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TraktorPlaylistExporter.Utils
{
    internal static class StringEllipsis
    {
        public static string Ellipsize(this String str, int maxLength)
        {
            if (String.IsNullOrEmpty(str))
                throw new ArgumentException("str is null or empty.", "str");

            maxLength = Math.Min(str.Length, maxLength);
            return String.Format("{0}...{1}", str.Substring(0, maxLength), str.Substring((str.Length - maxLength), maxLength));
        }
    }
}
