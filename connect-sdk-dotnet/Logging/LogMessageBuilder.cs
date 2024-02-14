using System;
using System.Text;

namespace Ingenico.Connect.Sdk.Logging
{
    /// <summary>
    /// A utility class to build log messages.
    /// </summary>
    public abstract class LogMessageBuilder
    {
        public abstract string Message { get; }

        public void AddHeader(string name, string value)
        {
            if (_headers.Length > 0)
            {
                _headers.Append(", ");
            }

            _headers.Append(name);
            _headers.Append("=\"");
            if (value != null)
            {
                string obfuscatedValue = HeaderObfuscator.ObfuscateHeader(name, value);
                _headers.Append(obfuscatedValue);
            }
            _headers.Append("\"");
        }

        public void SetBody(string body, string contentType)
        {
            Body = IsBinaryContent(contentType) ? "<binary content>" : BodyObfuscator.ObfuscateBody(body);
            ContentType = contentType;
        }
        public void SetBinaryContentBody(string contentType)
        {
            if (!IsBinaryContent(contentType))
            {
                throw new ArgumentException("Not a binary content type: " + contentType);
            }
            Body = "<binary content>";
            ContentType = contentType;
        }

        protected string RequestId { get; }

        protected string Headers => _headers.ToString();
        readonly StringBuilder _headers = new StringBuilder();

        protected string Body { get; private set; }
        protected string ContentType { get; private set; }
        protected string Charset { get; private set; }

        protected BodyObfuscator BodyObfuscator { get; }
        protected HeaderObfuscator HeaderObfuscator { get; }

        protected LogMessageBuilder(string requestId, BodyObfuscator bodyObfuscator, HeaderObfuscator headerObfuscator)
        {
            if (string.IsNullOrEmpty(requestId))
            {
                throw new ArgumentException("requestId is required");
            }

            RequestId = requestId;
            BodyObfuscator = bodyObfuscator ?? throw new ArgumentException("bodyObfuscator is required");
            HeaderObfuscator = headerObfuscator ?? throw new ArgumentException("headerObfuscator is required");
        }

        [Obsolete("Use the constructor that takes a BodyObfuscator and HeaderObfuscator instead")]
        protected LogMessageBuilder(string requestId)
            : this(requestId, BodyObfuscator.DefaultObfuscator, HeaderObfuscator.DefaultObfuscator)
        {
        }

        protected string EmptyIfNull(string value)
        {
            return value ?? "";
        }

        static bool IsBinaryContent(string contentType)
        {
            return contentType != null
                && !contentType.StartsWith("text/", StringComparison.OrdinalIgnoreCase)
                               && contentType.IndexOf("json", StringComparison.OrdinalIgnoreCase) < 0
                               && contentType.IndexOf("xml", StringComparison.OrdinalIgnoreCase) < 0;
        }
    }
}
