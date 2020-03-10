/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Capture;
using Ingenico.Connect.Sdk.Domain.Dispute;
using Ingenico.Connect.Sdk.Domain.Errors;
using Ingenico.Connect.Sdk.Domain.Payment;
using Ingenico.Connect.Sdk.Domain.Refund;
using Ingenico.Connect.Sdk.Domain.Token;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.Merchant.Payments
{
    /// <summary>
    /// Payments client. Thread-safe.
    /// </summary>
    public class PaymentsClient : ApiResource
    {
        public PaymentsClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/payments
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/create.html">Create payment</a>
        /// </summary>
        /// <param name="body">CreatePaymentRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>CreatePaymentResponse</returns>
        /// <exception cref="DeclinedPaymentException">if the Ingenico ePayments platform declined / rejected the payment. The payment result will be available from the exception.</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<CreatePaymentResponse> Create(CreatePaymentRequest body, CallContext context = null)
        {
            string uri = InstantiateUri("/v1/{merchantId}/payments", null);
            try
            {
                return await _communicator.Post<CreatePaymentResponse>(
                        uri,
                        ClientHeaders,
                        null,
                        body,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject = _communicator.Marshaller.Unmarshal<PaymentErrorResponse>(e.Body);
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/payments
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/find.html">Find payments</a>
        /// </summary>
        /// <param name="query">FindPaymentsParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>FindPaymentsResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<FindPaymentsResponse> Find(FindPaymentsParams query, CallContext context = null)
        {
            string uri = InstantiateUri("/v1/{merchantId}/payments", null);
            try
            {
                return await _communicator.Get<FindPaymentsResponse>(
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
        /// Resource /{merchantId}/payments/{paymentId}
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/get.html">Get payment</a>
        /// </summary>
        /// <param name="paymentId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>PaymentResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<PaymentResponse> Get(string paymentId, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentId", paymentId);
            string uri = InstantiateUri("/v1/{merchantId}/payments/{paymentId}", pathContext);
            try
            {
                return await _communicator.Get<PaymentResponse>(
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
        /// Resource /{merchantId}/payments/{paymentId}/complete
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/complete.html">Complete payment</a>
        /// </summary>
        /// <param name="paymentId">string</param>
        /// <param name="body">CompletePaymentRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>CompletePaymentResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<CompletePaymentResponse> Complete(string paymentId, CompletePaymentRequest body, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentId", paymentId);
            string uri = InstantiateUri("/v1/{merchantId}/payments/{paymentId}/complete", pathContext);
            try
            {
                return await _communicator.Post<CompletePaymentResponse>(
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
        /// Resource /{merchantId}/payments/{paymentId}/thirdpartystatus
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/thirdPartyStatus.html">Third party status poll</a>
        /// </summary>
        /// <param name="paymentId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>ThirdPartyStatusResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<ThirdPartyStatusResponse> ThirdPartyStatus(string paymentId, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentId", paymentId);
            string uri = InstantiateUri("/v1/{merchantId}/payments/{paymentId}/thirdpartystatus", pathContext);
            try
            {
                return await _communicator.Get<ThirdPartyStatusResponse>(
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
        /// Resource /{merchantId}/payments/{paymentId}/tokenize
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/tokenize.html">Create a token from payment</a>
        /// </summary>
        /// <param name="paymentId">string</param>
        /// <param name="body">TokenizePaymentRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>CreateTokenResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<CreateTokenResponse> Tokenize(string paymentId, TokenizePaymentRequest body, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentId", paymentId);
            string uri = InstantiateUri("/v1/{merchantId}/payments/{paymentId}/tokenize", pathContext);
            try
            {
                return await _communicator.Post<CreateTokenResponse>(
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
        /// Resource /{merchantId}/payments/{paymentId}/processchallenged
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/processchallenged.html">Approves challenged payment</a>
        /// </summary>
        /// <param name="paymentId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>PaymentResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<PaymentResponse> Processchallenged(string paymentId, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentId", paymentId);
            string uri = InstantiateUri("/v1/{merchantId}/payments/{paymentId}/processchallenged", pathContext);
            try
            {
                return await _communicator.Post<PaymentResponse>(
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
        /// Resource /{merchantId}/payments/{paymentId}/approve
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/approve.html">Approve payment</a>
        /// </summary>
        /// <param name="paymentId">string</param>
        /// <param name="body">ApprovePaymentRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>PaymentApprovalResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<PaymentApprovalResponse> Approve(string paymentId, ApprovePaymentRequest body, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentId", paymentId);
            string uri = InstantiateUri("/v1/{merchantId}/payments/{paymentId}/approve", pathContext);
            try
            {
                return await _communicator.Post<PaymentApprovalResponse>(
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
        /// Resource /{merchantId}/payments/{paymentId}/capture
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/capture.html">Capture payment</a>
        /// </summary>
        /// <param name="paymentId">string</param>
        /// <param name="body">CapturePaymentRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>CaptureResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<CaptureResponse> Capture(string paymentId, CapturePaymentRequest body, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentId", paymentId);
            string uri = InstantiateUri("/v1/{merchantId}/payments/{paymentId}/capture", pathContext);
            try
            {
                return await _communicator.Post<CaptureResponse>(
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
        /// Resource /{merchantId}/payments/{paymentId}/cancelapproval
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/cancelapproval.html">Undo capture payment</a>
        /// </summary>
        /// <param name="paymentId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>CancelApprovalPaymentResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<CancelApprovalPaymentResponse> Cancelapproval(string paymentId, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentId", paymentId);
            string uri = InstantiateUri("/v1/{merchantId}/payments/{paymentId}/cancelapproval", pathContext);
            try
            {
                return await _communicator.Post<CancelApprovalPaymentResponse>(
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
        /// Resource /{merchantId}/payments/{paymentId}/captures
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/captures.html">Get captures of payment</a>
        /// </summary>
        /// <param name="paymentId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>CapturesResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<CapturesResponse> Captures(string paymentId, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentId", paymentId);
            string uri = InstantiateUri("/v1/{merchantId}/payments/{paymentId}/captures", pathContext);
            try
            {
                return await _communicator.Get<CapturesResponse>(
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
        /// Resource /{merchantId}/payments/{paymentId}/refund
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/refund.html">Create refund</a>
        /// </summary>
        /// <param name="paymentId">string</param>
        /// <param name="body">RefundRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>RefundResponse</returns>
        /// <exception cref="DeclinedRefundException">if the Ingenico ePayments platform declined / rejected the refund. The refund result will be available from the exception.</exception>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<RefundResponse> Refund(string paymentId, RefundRequest body, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentId", paymentId);
            string uri = InstantiateUri("/v1/{merchantId}/payments/{paymentId}/refund", pathContext);
            try
            {
                return await _communicator.Post<RefundResponse>(
                        uri,
                        ClientHeaders,
                        null,
                        body,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject = _communicator.Marshaller.Unmarshal<RefundErrorResponse>(e.Body);
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/payments/{paymentId}/refunds
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/refunds.html">Get refunds of payment</a>
        /// </summary>
        /// <param name="paymentId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>RefundsResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<RefundsResponse> Refunds(string paymentId, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentId", paymentId);
            string uri = InstantiateUri("/v1/{merchantId}/payments/{paymentId}/refunds", pathContext);
            try
            {
                return await _communicator.Get<RefundsResponse>(
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
        /// Resource /{merchantId}/payments/{paymentId}/cancel
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/cancel.html">Cancel payment</a>
        /// </summary>
        /// <param name="paymentId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>CancelPaymentResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<CancelPaymentResponse> Cancel(string paymentId, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentId", paymentId);
            string uri = InstantiateUri("/v1/{merchantId}/payments/{paymentId}/cancel", pathContext);
            try
            {
                return await _communicator.Post<CancelPaymentResponse>(
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
        /// Resource /{merchantId}/payments/{paymentId}/dispute
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/dispute.html">Create dispute</a>
        /// </summary>
        /// <param name="paymentId">string</param>
        /// <param name="body">CreateDisputeRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>DisputeResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<DisputeResponse> Dispute(string paymentId, CreateDisputeRequest body, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentId", paymentId);
            string uri = InstantiateUri("/v1/{merchantId}/payments/{paymentId}/dispute", pathContext);
            try
            {
                return await _communicator.Post<DisputeResponse>(
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
        /// Resource /{merchantId}/payments/{paymentId}/disputes
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/payments/disputes.html">Get disputes</a>
        /// </summary>
        /// <param name="paymentId">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>DisputesResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<DisputesResponse> Disputes(string paymentId, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentId", paymentId);
            string uri = InstantiateUri("/v1/{merchantId}/payments/{paymentId}/disputes", pathContext);
            try
            {
                return await _communicator.Get<DisputesResponse>(
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
    }
}
