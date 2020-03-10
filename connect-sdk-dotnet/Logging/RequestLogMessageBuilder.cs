namespace Ingenico.Connect.Sdk.Logging
{
    /// <summary>
    /// A utility class to build request log messages.
    /// </summary>
    public class RequestLogMessageBuilder : LogMessageBuilder
    {
        const string messageTemplateWithoutBody = @"Outgoing request (requestId='{0}'):
  method:       '{1}'
  uri:          '{2}'
  headers:      '{3}'";

        const string messageTemplateWithBody = messageTemplateWithoutBody + @"
  content-type: '{4}'
  body:         '{5}'";

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
                    return string.Format(messageTemplateWithoutBody, RequestId,
                        EmptyIfNull(_method),
                        EmptyIfNull(_uri),
                        Headers);

                }

                return string.Format(messageTemplateWithBody, RequestId,
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
