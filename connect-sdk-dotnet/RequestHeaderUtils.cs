using System;
using System.Collections.Generic;
using System.Linq;

namespace Ingenico.Connect.Sdk
{
    public static class RequestHeaderUtils
    {
        public static string GetHeaderValue(this IEnumerable<IRequestHeader> headers, string headerName)
        {
            return headers?.GetHeader(headerName)?.Value;
        }
        public static IRequestHeader GetHeader(this IEnumerable<IRequestHeader> headers, string headerName)
        {
            return headers?.FirstOrDefault((h) => h.Name.Equals(headerName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
