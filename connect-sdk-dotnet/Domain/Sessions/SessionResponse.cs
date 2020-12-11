/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Sessions
{
    public class SessionResponse
    {
        /// <summary>
        /// The datacenter-specific base url for assets. This value needs to be passed to the Client SDK to make sure that the client software connects to the right datacenter.
        /// </summary>
        public string AssetUrl { get; set; } = null;

        /// <summary>
        /// The datacenter-specific base url for client requests. This value needs to be passed to the Client SDK to make sure that the client software connects to the right datacenter.
        /// </summary>
        public string ClientApiUrl { get; set; } = null;

        /// <summary>
        /// The identifier of the session that has been created.
        /// </summary>
        public string ClientSessionId { get; set; } = null;

        /// <summary>
        /// The session is build up around the customer in the form of the customerId. All of the Client APIs use this customerId in the URI to identify the customer.
        /// </summary>
        public string CustomerId { get; set; } = null;

        /// <summary>
        /// Tokens that are submitted in the request are validated. In case any of the tokens can't be used anymore they are returned in this array. You should most likely remove those tokens from your system.
        /// </summary>
        public IList<string> InvalidTokens { get; set; } = null;

        /// <summary>
        /// Possible values: 
        /// <list type="bullet">
        ///   <item><description>EU - datacenter located in Amsterdam</description></item>
        ///   <item><description>US - datacenter located in Miami</description></item>
        ///   <item><description>AMS - datacenter located in Amsterdam</description></item>
        ///   <item><description>PAR - datacenter located in Paris</description></item>
        /// </list>When a session is created it is created in a specific datacenter. Any subsequent calls using the Client API need to be datacenter specific. The datacenters are identified by this region value. This value needs to be passed to the Client SDK to make sure that the client software connects to the right datacenter. This only applies if your clients use a version older than the ones listed below: 
        /// <list type="bullet">
        ///   <item><description>JavaScript Client SDK v3.6.0</description></item>
        ///   <item><description>iOS ObjectiveC Client SDK v3.10.0</description></item>
        ///   <item><description>iOS Swift Client SDK v2.2.0</description></item>
        ///   <item><description>Android Client SDK v3.10.0</description></item>
        /// </list>In case of the iOS and Android SDKs the version of the SDK used will be tightly coupled with the versions of your app that is still in active use. You are advised to pass this value to your clients in case you are unsure of the version used in your clients.
        /// </summary>
        public string Region { get; set; } = null;
    }
}
