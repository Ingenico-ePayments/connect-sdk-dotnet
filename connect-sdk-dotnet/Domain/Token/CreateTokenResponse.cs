/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Token
{
    public class CreateTokenResponse
    {
        /// <summary>
        /// Indicates if a new token was created 
        /// <list type="bullet">
        ///   <item><description>true - A new token was created</description></item>
        ///   <item><description>false - A token with the same card number already exists and is returned. Please note that the existing token has not been updated. When you want to update other data then the card number, you need to use the update API call, as data is never updated during the creation of a token.</description></item>
        /// </list>
        /// </summary>
        public bool? IsNewToken { get; set; } = null;

        /// <summary>
        /// The initial Payment ID of the transaction from which the token has been created
        /// </summary>
        public string OriginalPaymentId { get; set; } = null;

        /// <summary>
        /// ID of the token
        /// </summary>
        public string Token { get; set; } = null;
    }
}
