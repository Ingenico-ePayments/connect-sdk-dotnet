using System;
using System.Net;

namespace Ingenico.Connect.Sdk.Logging
{
    /// <summary>
    /// A utility class to build response log messages.
    /// </summary>
    public class ResponseLogMessageBuilder : LogMessageBuilder
    {
        const string messageTemplate = @"Incoming response (requestId='{0}' + '{1}' ms):
  status-code:  '{2}'
  headers:      '{3}'
  content-type: '{4}'
  body:         '{5}'";

        public ResponseLogMessageBuilder(string requestId, HttpStatusCode statusCode)
            : base(requestId)
        {
            _statusCode = statusCode;
        }

        [ObsoleteAttribute("Ignores the duration argument. Set the Duration property instead")]
        public ResponseLogMessageBuilder(string requestId, HttpStatusCode statusCode, long duration)
            : base(requestId)
        {
            _statusCode = statusCode;
        }

        public override string Message
        {
            get
            {
                return string.Format(messageTemplate, RequestId, (long)Duration.TotalMilliseconds,
                    (int)_statusCode,
                    Headers,
                    EmptyIfNull(ContentType),
                    EmptyIfNull(Body));
            }
        }

        public TimeSpan Duration { get; set; }

        readonly HttpStatusCode _statusCode;
    }
}
