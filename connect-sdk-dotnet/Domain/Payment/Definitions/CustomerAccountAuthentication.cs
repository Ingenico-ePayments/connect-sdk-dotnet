/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class CustomerAccountAuthentication
    {
        /// <summary>
        /// Data that documents and supports a specific authentication process submitted using the order.customer.account.authentication.method property. The data submitted using this property will be used by the issuer to validate the used authentication method. 
        /// <br />For example, if the order.customer.account.authentication.method is: 
        /// <list type="bullet">
        ///   <item><description>federated-id, then this element can carry information about the provider of the federated ID and related information.</description></item>
        ///   <item><description>fido-authentication, then this element can carry the FIDO attestation data (including the signature).</description></item>
        ///   <item><description>fido-authentication-with-signed-assurance-data, then this element can carry FIDO Attestation data with the FIDO assurance data signed.</description></item>
        ///   <item><description>src-assurance-data, then this element can carry the SRC assurance data</description></item>
        /// </list>
        /// </summary>
        public string Data { get; set; } = null;

        /// <summary>
        /// Authentication used by the customer on your website or app 
        /// <br />Possible values : 
        /// <list type="bullet">
        ///   <item><description>guest = no login occurred, customer is 'logged in' as guest</description></item>
        ///   <item><description>merchant-credentials = the customer logged in using credentials that are specific to you</description></item>
        ///   <item><description>federated-id = the customer logged in using a federated ID</description></item>
        ///   <item><description>issuer-credentials = the customer logged in using credentials from the card issuer (of the card used in this transaction)</description></item>
        ///   <item><description>third-party-authentication = the customer logged in using third-party authentication</description></item>
        ///   <item><description>fido-authentication = the customer logged in using a FIDO authenticator</description></item>
        ///   <item><description>fido-authentication-with-signed-assurance-data = the customer logged in using a FIDO authenticator which also provides signed assurance data</description></item>
        ///   <item><description>src-assurance-data = the customer authenticated themselves during a Secure Remote Commerce session</description></item>
        /// </list>
        /// </summary>
        public string Method { get; set; } = null;

        /// <summary>
        /// Timestamp (YYYYMMDDHHmm) of the authentication of the customer to their account with you
        /// </summary>
        public string UtcTimestamp { get; set; } = null;
    }
}
