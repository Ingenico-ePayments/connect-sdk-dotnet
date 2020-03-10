/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Errors;
using Ingenico.Connect.Sdk.Domain.Product;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.Merchant.Productgroups
{
    /// <summary>
    /// Productgroups client. Thread-safe.
    /// </summary>
    public class ProductgroupsClient : ApiResource
    {
        public ProductgroupsClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/productgroups
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/productgroups/find.html">Get payment product groups</a>
        /// </summary>
        /// <param name="query">FindProductgroupsParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>PaymentProductGroups</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<PaymentProductGroups> Find(FindProductgroupsParams query, CallContext context = null)
        {
            string uri = InstantiateUri("/v1/{merchantId}/productgroups", null);
            try
            {
                return await _communicator.Get<PaymentProductGroups>(
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
        /// Resource /{merchantId}/productgroups/{paymentProductGroupId}
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/productgroups/get.html">Get payment product group</a>
        /// </summary>
        /// <param name="paymentProductGroupId">string</param>
        /// <param name="query">GetProductgroupParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>PaymentProductGroupResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<PaymentProductGroupResponse> Get(string paymentProductGroupId, GetProductgroupParams query, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentProductGroupId", paymentProductGroupId);
            string uri = InstantiateUri("/v1/{merchantId}/productgroups/{paymentProductGroupId}", pathContext);
            try
            {
                return await _communicator.Get<PaymentProductGroupResponse>(
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
        /// Resource /{merchantId}/productgroups/{paymentProductGroupId}/deviceFingerprint
        /// - <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/productgroups/deviceFingerprint.html">Get device fingerprint</a>
        /// </summary>
        /// <param name="paymentProductGroupId">string</param>
        /// <param name="body">DeviceFingerprintRequest</param>
        /// <param name="context">CallContext</param>
        /// <returns>DeviceFingerprintResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the Ingenico ePayments platform,
        ///            the Ingenico ePayments platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the Ingenico ePayments platform returned any other error</exception>
        public async Task<DeviceFingerprintResponse> DeviceFingerprint(string paymentProductGroupId, DeviceFingerprintRequest body, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentProductGroupId", paymentProductGroupId);
            string uri = InstantiateUri("/v1/{merchantId}/productgroups/{paymentProductGroupId}/deviceFingerprint", pathContext);
            try
            {
                return await _communicator.Post<DeviceFingerprintResponse>(
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
    }
}
