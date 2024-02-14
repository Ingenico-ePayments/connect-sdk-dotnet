using System;

namespace Ingenico.Connect.Sdk.Logging
{
    /// <summary>
    /// A utility class to build request log messages.
    /// </summary>
    public class RequestLogMessageBuilder : LogMessageBuilder
    {
        const string MessageTemplateWithoutBody = @"Outgoing request (requestId='{0}'):
  method:       '{1}'
  uri:          '{2}'
  headers:      '{3}'";

        const string MessageTemplateWithBody = MessageTemplateWithoutBody + @"
  content-type: '{4}'
  body:         '{5}'";

        public RequestLogMessageBuilder(string requestId, string method, string uri, BodyObfuscator bodyObfuscator, HeaderObfuscator headerObfuscator)
            : base(requestId, bodyObfuscator, headerObfuscator)
        {
            _method = method;
            _uri = uri;
        }

        [Obsolete("Use the constructor that takes a BodyObfuscator and HeaderObfuscator instead")]
        public RequestLogMessageBuilder(string requestId, string method, string uri)
            : base(requestId)
        {

            _method = method;
            _uri = uri;
        }

        public override string Message
        {
            get
            {
                string body = Body;
                if (body == null)
                {
                    return string.Format(MessageTemplateWithoutBody, RequestId,
                        EmptyIfNull(_method),
                        EmptyIfNull(_uri),
                        Headers);

                }

                return string.Format(MessageTemplateWithBody, RequestId,
                    EmptyIfNull(_method),
                    EmptyIfNull(_uri),
                    Headers,
                    EmptyIfNull(ContentType),
                    body);
            }
        }

        readonly string _method;
        readonly string _uri;
    }
}
