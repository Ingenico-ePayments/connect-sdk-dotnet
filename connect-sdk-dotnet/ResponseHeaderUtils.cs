using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ingenico.Connect.Sdk
{
    public static class ResponseHeaderUtils
    {
        private static Regex DispositionFilenameRegex { get;  } = new Regex("(?:^|;)\\s*filename\\s*=\\s*(.*?)\\s*(?:;|$)", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        /// <returns>
        /// The value of the header from this with the given name, or <c>null</c> if there was no such header.
        /// </returns>
        public static string GetHeaderValue(this IEnumerable<IResponseHeader> headers, string headerName)
        {
            return headers?.GetHeader(headerName)?.Value;
        }

        /// <returns>
        /// The header from this with the given name, or <c>null</c> if there was no such header.
        /// </returns>
        public static IResponseHeader GetHeader(this IEnumerable<IResponseHeader> headers, string headerName)
        {
            return headers?.FirstOrDefault((h) => h.Name.Equals(headerName, StringComparison.OrdinalIgnoreCase));
        }

        ///
        /// <returns>The value of the <c>filename</c> parameter of the <c>Content-Disposition</c> header from this,
        /// or <c>null</c> if there was no such header or parameter.</returns>
        ///
        public static string GetDispositionFilename(this IEnumerable<ResponseHeader> headers)
        {
            string headerValue = headers.GetHeaderValue("Content-Disposition");
            if (headerValue == null)
            {
                return null;
            }
            Match match = DispositionFilenameRegex.Match(headerValue);
            if (match.Success)
            {
                string filename = match.Groups[1].Value;
                return TrimQuotes(filename);
            }
            return null;
        }
        private static string TrimQuotes(string filename)
        {
            if (filename.Length < 2)
            {
                return filename;
            }
            if ((filename.StartsWith("\"") && filename.EndsWith("\""))
                    || (filename.StartsWith("'") && filename.EndsWith("'")))
            {
                return filename.Substring(1, filename.Length - 1);
            }
            return filename;
        }

    }
}
