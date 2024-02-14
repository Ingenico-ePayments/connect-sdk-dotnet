using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Ingenico.Connect.Sdk.Domain.Errors;
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment;
using Ingenico.Connect.Sdk.Domain.Payout;
using Ingenico.Connect.Sdk.Domain.Refund;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Base class of all Ingenico ePayments platform API resources.
    /// </summary>
    public class ApiResource
    {
        protected readonly Communicator _communicator;
        protected readonly string _clientMetaInfo;

        protected List<RequestHeader> ClientHeaders
        {
            get
            {
                if (_clientMetaInfo != null)
                {

                    List<RequestHeader> clientHeaders = new List<RequestHeader>()
                    {
                        new RequestHeader("X-GCS-ClientMetaInfo", _clientMetaInfo)
                    };
                    return clientHeaders;

                }
                else
                {
                    return null;
                }
            }
        }

        protected ApiResource(ApiResource parent, IDictionary<string, string> pathContext)
        {
            _parent = parent ?? throw new ArgumentException("parent is required");
            _communicator = parent._communicator;
            _pathContext = pathContext;
            _clientMetaInfo = parent._clientMetaInfo;
        }

        protected ApiResource(Communicator communicator, string clientMetaInfo, IDictionary<string, string> pathContext)
        {
            _parent = null;
            _communicator = communicator ?? throw new ArgumentException("communicator is required");
            _pathContext = pathContext;
            _clientMetaInfo = clientMetaInfo;
        }


        protected string InstantiateUri(string uri, IDictionary<string, string> pathContext)
        {
            uri = ReplaceAll(uri, pathContext);
            uri = InstantiateUri(uri);
            return uri;
        }

        protected Exception CreateException(HttpStatusCode statusCode, string responseBody, object errorObject, CallContext context)
        {
            PaymentErrorResponse paymentErrorResponse = errorObject as PaymentErrorResponse;
            if (paymentErrorResponse?.PaymentResult != null)
            {
                return new DeclinedPaymentException(statusCode, responseBody, (PaymentErrorResponse)errorObject);
            }
            PayoutErrorResponse payoutErrorResponse = errorObject as PayoutErrorResponse;
            if (payoutErrorResponse?.PayoutResult != null)
            {
                return new DeclinedPayoutException(statusCode, responseBody, (PayoutErrorResponse)errorObject);
            }
            RefundErrorResponse refundErrorResponse = errorObject as RefundErrorResponse;
            if (refundErrorResponse?.RefundResult != null)
            {
                return new DeclinedRefundException(statusCode, responseBody, (RefundErrorResponse)errorObject);
            }

            string errorId;
            IList<APIError> errors;
            if (paymentErrorResponse != null)
            {
                errorId = paymentErrorResponse.ErrorId;
                errors = paymentErrorResponse.Errors;
            }
            else if (payoutErrorResponse != null)
            {
                errorId = payoutErrorResponse.ErrorId;
                errors = payoutErrorResponse.Errors;
            }
            else if (refundErrorResponse != null)
            {
                errorId = refundErrorResponse.ErrorId;
                errors = refundErrorResponse.Errors;
            }
            else if (errorObject is ErrorResponse errorResponse)
            {
                errorId = errorResponse.ErrorId;
                errors = errorResponse.Errors;
            }
            else {
                throw new ArgumentException("unsupported error object type: " + errorObject.GetType());
            }

            switch (statusCode)
            {
                case HttpStatusCode.BadRequest:
                    return new ValidationException(statusCode, responseBody, errorId, errors);
                case HttpStatusCode.Forbidden:
                    return new AuthorizationException(statusCode, responseBody, errorId, errors);
                case HttpStatusCode.NotFound:
                    return new ReferenceException(statusCode, responseBody, errorId, errors);
                case HttpStatusCode.Conflict:
                    if (IsIdempotenceError(errors, context))
                    {
                        string idempotenceKey = context.IdempotenceKey;
                        long? idempotenceRequestTimestamp = context.IdempotenceRequestTimestamp;
                        return new IdempotenceException(idempotenceKey, idempotenceRequestTimestamp, statusCode, responseBody, errorId, errors);
                    }
                    return new ReferenceException(statusCode, responseBody, errorId, errors);
                case HttpStatusCode.Gone:
                    return new ReferenceException(statusCode, responseBody, errorId, errors);
                case HttpStatusCode.InternalServerError:
                    return new GlobalCollectException(statusCode, responseBody, errorId, errors);
                case HttpStatusCode.BadGateway:
                    return new GlobalCollectException(statusCode, responseBody, errorId, errors);
                case HttpStatusCode.ServiceUnavailable:
                    return new GlobalCollectException(statusCode, responseBody, errorId, errors);
                default:
                    return new ApiException(statusCode, responseBody, errorId, errors);
            }
        }

        readonly ApiResource _parent;
        readonly IDictionary<string, string> _pathContext;

        string InstantiateUri(string uri)
        {
            uri = ReplaceAll(uri, _pathContext);
            if (_parent != null)
            {
                uri = _parent.InstantiateUri(uri);
            }
            return uri;
        }

        static string ReplaceAll(string uri, IDictionary<string, string> pathContext)
        {
            if (pathContext != null)
            {
                foreach (var entry in pathContext)
                {
                    uri = uri.Replace("{" + entry.Key + "}", entry.Value);
                }
            }
            return uri;
        }

        static bool IsIdempotenceError(IEnumerable<APIError> errors, CallContext context)
        {
            return context?.IdempotenceKey != null
                    && errors.Count() == 1
                    && "1409".Equals(errors.ElementAt(0).Code);
        }
    }
}
