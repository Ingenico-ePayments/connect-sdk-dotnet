using System;
using System.Collections.Generic;
using System.Text;

namespace Ingenico.Connect.Sdk
{
    static class StringUtils
    {
        internal static string FromBase64String(this string input)
            => Encoding.GetString(Convert.FromBase64String(input));

        internal static string ToBase64String(this string input)
            => Convert.ToBase64String(Encoding.GetBytes(input));

        internal static Encoding Encoding
            => Encoding.UTF8;

        internal static string NullIfEmpty(this string input)
            => ((IEnumerable<char>)input).NullIfEmpty() as string;
    }
}
