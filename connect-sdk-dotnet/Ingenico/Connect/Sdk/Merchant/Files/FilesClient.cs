/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using Ingenico.Connect.Sdk.Domain.Errors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Ingenico.Connect.Sdk.Merchant.Files
{
    /// <summary>
    /// Files client. Thread-safe.
    /// </summary>
    public class FilesClient : ApiResource
    {
        public FilesClient(ApiResource parent, IDictionary<string, string> pathContext) :
            base(parent, pathContext)
        {
        }

        /// <summary>
        /// Resource /{merchantId}/files/{fileId}
        /// - <a href="https://epayments-api.developer-ingenico.com/fileserviceapi/v1/en_US/dotnet/files/getFile.html">Retrieve File</a>
        /// </summary>
        /// <param name="fileId">string</param>
        /// <param name="bodyHandler">A callback that receives the contents of the body as a stream</param>
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
        public async Task GetFile(string fileId, Action<Stream, IEnumerable<IResponseHeader>> bodyHandler, CallContext context = null)
        {
            IDictionary<string, string> pathContext = new Dictionary<string, string>();
            pathContext.Add("fileId", fileId);
            string uri = InstantiateUri("/files/v1/{merchantId}/files/{fileId}", pathContext);
            try
            {
                await _communicator.Get(
                        uri,
                        ClientHeaders,
                        null,
                        bodyHandler,
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
