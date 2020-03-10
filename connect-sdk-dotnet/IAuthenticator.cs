using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Used to sign requests to the Ingenico ePayments platform. Thread-safe.
    /// </summary>
    public interface IAuthenticator
    {
        /// <summary>
        /// Creates a signature for the simple security model.
        /// </summary>
        /// <returns>The simple authentication signature.</returns>
        /// <param name="httpMethod">HTTP method.</param>
        /// <param name="resourceUri">Resource URI.</param>
        /// <param name="requestHeaders">A list of request headers.</param>
        /// <remarks>The list of Request headers may not be modified and may not contain headers with
        /// the same name.</remarks>
        string CreateSimpleAuthenticationSignature(HttpMethod httpMethod, Uri resourceUri, IEnumerable<IRequestHeader> requestHeaders);
    }
}
