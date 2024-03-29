using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Ingenico.Connect.Sdk
{
    internal static class StringUtils
    {
        internal static string FromBase64String(this string input)
            => Encoding.GetString(Convert.FromBase64String(input));

        internal static string ToBase64String(this string input)
            => Convert.ToBase64String(Encoding.GetBytes(input));

        internal static Encoding Encoding
            => Encoding.UTF8;

        internal static string NullIfEmpty(this string input)
            => ((IEnumerable<char>)input).NullIfEmpty() as string;

        internal static bool CompareWithoutTimingLeak(this string input, string expected)
        {
            int length = input.Length;
            int expectedLength = expected.Length;
            int limit = Math.Max(Math.Max(length, expectedLength), 256);
            bool result = true;
            for (int i = 0; i < limit; i++)
            {
                if (i < length && i < expectedLength)
                {
                    result &= input.ElementAt(i) == expected.ElementAt(i);
                }
                else if (i >= length && i >= expectedLength)
                {
                    result &= true;
                }
                else
                {
                    result &= false;
                }
            }
            return result;
        }
    }
}
