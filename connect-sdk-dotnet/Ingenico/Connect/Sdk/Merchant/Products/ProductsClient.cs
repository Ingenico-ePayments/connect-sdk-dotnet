/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Errors;
using Ingenico.Connect.Sdk.Domain.Product;
using Ingenico.Connect.Sdk.Domain.Publickey;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.Merchant.Products
{
    /// <summary>
    /// Products client. Thread-safe.
    /// </summary>
    public class ProductsClient : ApiResource
    {
        public ProductsClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/products
        /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__products_get">Get payment products</a>
        /// </summary>
        /// <param name="query">FindProductsParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>PaymentProducts</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the GlobalCollect platform,
        ///            the GlobalCollect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the GlobalCollect platform returned any other error</exception>
        public async Task<PaymentProducts> Find(FindProductsParams query, CallContext context = null)
        {
            string uri = InstantiateUri("/{apiVersion}/{merchantId}/products", null);
            try
            {
                return await _communicator.Get<PaymentProducts>(
                        uri,
                        ClientHeaders,
                        query,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject;
                switch (e.StatusCode)
                {
                    default:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                }
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/products/{paymentProductId}
        /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__products__paymentProductId__get">Get payment product</a>
        /// </summary>
        /// <param name="paymentProductId">int?</param>
        /// <param name="query">GetProductParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>PaymentProductResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the GlobalCollect platform,
        ///            the GlobalCollect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the GlobalCollect platform returned any other error</exception>
        public async Task<PaymentProductResponse> Get(int? paymentProductId, GetProductParams query, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentProductId", paymentProductId.ToString());
            string uri = InstantiateUri("/{apiVersion}/{merchantId}/products/{paymentProductId}", pathContext);
            try
            {
                return await _communicator.Get<PaymentProductResponse>(
                        uri,
                        ClientHeaders,
                        query,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject;
                switch (e.StatusCode)
                {
                    default:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                }
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/products/{paymentProductId}/directory
        /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__products__paymentProductId__directory_get">Get payment product directory</a>
        /// </summary>
        /// <param name="paymentProductId">int?</param>
        /// <param name="query">DirectoryParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>Directory</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the GlobalCollect platform,
        ///            the GlobalCollect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the GlobalCollect platform returned any other error</exception>
        public async Task<Directory> Directory(int? paymentProductId, DirectoryParams query, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentProductId", paymentProductId.ToString());
            string uri = InstantiateUri("/{apiVersion}/{merchantId}/products/{paymentProductId}/directory", pathContext);
            try
            {
                return await _communicator.Get<Directory>(
                        uri,
                        ClientHeaders,
                        query,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject;
                switch (e.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                    default:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                }
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/products/{paymentProductId}/networks
        /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__products__paymentProductId__networks_get">Get payment product networks</a>
        /// </summary>
        /// <param name="paymentProductId">int?</param>
        /// <param name="query">NetworksParams</param>
        /// <param name="context">CallContext</param>
        /// <returns>PaymentProductNetworksResponse</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the GlobalCollect platform,
        ///            the GlobalCollect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the GlobalCollect platform returned any other error</exception>
        public async Task<PaymentProductNetworksResponse> Networks(int? paymentProductId, NetworksParams query, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentProductId", paymentProductId.ToString());
            string uri = InstantiateUri("/{apiVersion}/{merchantId}/products/{paymentProductId}/networks", pathContext);
            try
            {
                return await _communicator.Get<PaymentProductNetworksResponse>(
                        uri,
                        ClientHeaders,
                        query,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject;
                switch (e.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                    default:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                }
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }

        /// <summary>
        /// Resource /{merchantId}/products/{paymentProductId}/publicKey
        /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__products__paymentProductId__publicKey_get">Get payment product specific public key</a>
        /// </summary>
        /// <param name="paymentProductId">int?</param>
        /// <param name="context">CallContext</param>
        /// <returns>PublicKey</returns>
        /// <exception cref="ValidationException">if the request was not correct and couldn't be processed (HTTP status code BadRequest)</exception>
        /// <exception cref="AuthorizationException">if the request was not allowed (HTTP status code Forbidden)</exception>
        /// <exception cref="IdempotenceException">if an idempotent request caused a conflict (HTTP status code Conflict)</exception>
        /// <exception cref="ReferenceException">if an object was attempted to be referenced that doesn't exist or has been removed,
        ///            or there was a conflict (HTTP status code NotFound, Conflict or Gone)</exception>
        /// <exception cref="GlobalCollectException">if something went wrong at the GlobalCollect platform,
        ///            the GlobalCollect platform was unable to process a message from a downstream partner/acquirer,
        ///            or the service that you're trying to reach is temporary unavailable (HTTP status code InternalServerError, BadGateway or ServiceUnavailable)</exception>
        /// <exception cref="ApiException">if the GlobalCollect platform returned any other error</exception>
        public async Task<PublicKey> PublicKey(int? paymentProductId, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("paymentProductId", paymentProductId.ToString());
            string uri = InstantiateUri("/{apiVersion}/{merchantId}/products/{paymentProductId}/publicKey", pathContext);
            try
            {
                return await _communicator.Get<PublicKey>(
                        uri,
                        ClientHeaders,
                        null,
                        context);
            }
            catch (ResponseException e)
            {
                object errorObject;
                switch (e.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                    default:
                        errorObject = _communicator.Marshaller.Unmarshal<ErrorResponse>(e.Body);
                        break;
                }
                throw CreateException(e.StatusCode, e.Body, errorObject, context);
            }
        }
    }
}
