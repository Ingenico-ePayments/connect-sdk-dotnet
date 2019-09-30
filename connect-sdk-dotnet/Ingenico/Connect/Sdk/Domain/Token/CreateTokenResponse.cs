/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Token
{
    public class CreateTokenResponse
    {
        public bool? IsNewToken { get; set; } = null;

        public string OriginalPaymentId { get; set; } = null;

        public string Token { get; set; } = null;
    }
}
