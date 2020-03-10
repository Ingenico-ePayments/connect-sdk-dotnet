/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Errors;
using Ingenico.Connect.Sdk.Domain.Refund;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.Merchant.Refunds
{
    /// <summary>
    /// Refunds client. Thread-safe.
    /// </summary>
    public class RefundsClient : ApiResource
    {
        public RefundsClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/refunds
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/refunds/find.html">Find refunds</a>
        /// </summary>
        /// <param name="query">FindRefundsParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>FindRefundsResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<FindRefundsResponse> Find(FindRefundsParams query, CallContext context = null)
        {
            string uri = InstantiateUri("/v1/{merchantId}/refunds", null);
            try
            {
                return await _communicator.Get<FindRefundsResponse>(
                        uri,
                        ClientHeaders,
                        query,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/refunds/{refundId}
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/refunds/get.html">Get refund</a>
        /// </summary>
        /// <param name="refundId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>RefundResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<RefundResponse> Get(string refundId, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("refundId", refundId);
            string uri = InstantiateUri("/v1/{merchantId}/refunds/{refundId}", pathContext);
            try
            {
                return await _communicator.Get<RefundResponse>(
                        uri,
                        ClientHeaders,
                        null,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/refunds/{refundId}/approve
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/refunds/approve.html">Approve refund</a>
        /// </summary>
        /// <param name="refundId">string</param>
        /// <param name="body">ApproveRefundRequest</param>
        /// <param name="context">CallContext</param>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task Approve(string refundId, ApproveRefundRequest body, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("refundId", refundId);
            string uri = InstantiateUri("/v1/{merchantId}/refunds/{refundId}/approve", pathContext);
            try
            {
                await _communicator.Post<object>(
                        uri,
                        ClientHeaders,
                        null,
                        body,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/refunds/{refundId}/cancel
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/refunds/cancel.html">Cancel refund</a>
        /// </summary>
        /// <param name="refundId">string</param>
        /// <param name="context">CallContext</param>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task Cancel(string refundId, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("refundId", refundId);
            string uri = InstantiateUri("/v1/{merchantId}/refunds/{refundId}/cancel", pathContext);
            try
            {
                await _communicator.Post<object>(
                        uri,
                        ClientHeaders,
                        null,
                        null,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/refunds/{refundId}/cancelapproval
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/refunds/cancelapproval.html">Undo approve refund</a>
        /// </summary>
        /// <param name="refundId">string</param>
        /// <param name="context">CallContext</param>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task Cancelapproval(string refundId, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("refundId", refundId);
            string uri = InstantiateUri("/v1/{merchantId}/refunds/{refundId}/cancelapproval", pathContext);
            try
            {
                await _communicator.Post<object>(
                        uri,
                        ClientHeaders,
                        null,
                        null,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }
    }
}
