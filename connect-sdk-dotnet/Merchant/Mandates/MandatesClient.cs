/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Errors;
using Ingenico.Connect.Sdk.Domain.Mandates;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.Merchant.Mandates
{
    /// <summary>
    /// Mandates client. Thread-safe.
    /// </summary>
    public class MandatesClient : ApiResource
    {
        public MandatesClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/mandates
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/mandates/create.html">Create mandate</a>
        /// </summary>
        /// <param name="body">CreateMandateRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>CreateMandateResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<CreateMandateResponse> Create(CreateMandateRequest body, CallContext context = null)
        {
            string uri = InstantiateUri("/v1/{merchantId}/mandates", null);
            try
            {
                return await _communicator.Post<CreateMandateResponse>(
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
        /// Resource /{merchantId}/mandates/{uniqueMandateReference}
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/mandates/createWithMandateReference.html">Create mandate with mandatereference</a>
        /// </summary>
        /// <param name="uniqueMandateReference">string</param>
        /// <param name="body">CreateMandateRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>CreateMandateResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<CreateMandateResponse> CreateWithMandateReference(string uniqueMandateReference, CreateMandateRequest body, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("uniqueMandateReference", uniqueMandateReference);
            string uri = InstantiateUri("/v1/{merchantId}/mandates/{uniqueMandateReference}", pathContext);
            try
            {
                return await _communicator.Put<CreateMandateResponse>(
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
        /// Resource /{merchantId}/mandates/{uniqueMandateReference}
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/mandates/get.html">Get mandate</a>
        /// </summary>
        /// <param name="uniqueMandateReference">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>GetMandateResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<GetMandateResponse> Get(string uniqueMandateReference, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("uniqueMandateReference", uniqueMandateReference);
            string uri = InstantiateUri("/v1/{merchantId}/mandates/{uniqueMandateReference}", pathContext);
            try
            {
                return await _communicator.Get<GetMandateResponse>(
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
        /// Resource /{merchantId}/mandates/{uniqueMandateReference}/block
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/mandates/block.html">Block mandate</a>
        /// </summary>
        /// <param name="uniqueMandateReference">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>GetMandateResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<GetMandateResponse> Block(string uniqueMandateReference, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("uniqueMandateReference", uniqueMandateReference);
            string uri = InstantiateUri("/v1/{merchantId}/mandates/{uniqueMandateReference}/block", pathContext);
            try
            {
                return await _communicator.Post<GetMandateResponse>(
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
        /// Resource /{merchantId}/mandates/{uniqueMandateReference}/unblock
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/mandates/unblock.html">Unblock mandate</a>
        /// </summary>
        /// <param name="uniqueMandateReference">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>GetMandateResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<GetMandateResponse> Unblock(string uniqueMandateReference, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("uniqueMandateReference", uniqueMandateReference);
            string uri = InstantiateUri("/v1/{merchantId}/mandates/{uniqueMandateReference}/unblock", pathContext);
            try
            {
                return await _communicator.Post<GetMandateResponse>(
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
        /// Resource /{merchantId}/mandates/{uniqueMandateReference}/revoke
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/mandates/revoke.html">Revoke mandate</a>
        /// </summary>
        /// <param name="uniqueMandateReference">string</param>
        /// <param name="context">CallContext</param>
        /// <returns>GetMandateResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<GetMandateResponse> Revoke(string uniqueMandateReference, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("uniqueMandateReference", uniqueMandateReference);
            string uri = InstantiateUri("/v1/{merchantId}/mandates/{uniqueMandateReference}/revoke", pathContext);
            try
            {
                return await _communicator.Post<GetMandateResponse>(
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
