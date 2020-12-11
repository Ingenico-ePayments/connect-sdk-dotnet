/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Services.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Services
{
    public class GetIINDetailsRequest
    {
        /// <summary>
        /// The first digits of the credit card number from left to right with a minimum of 6 digits. Providing additional digits can result in more co-brands being returned.
        /// </summary>
        public string Bin { get; set; } = null;

        /// <summary>
        /// Optional payment context to refine the IIN lookup to filter out payment products not applicable to your payment.
        /// </summary>
        public PaymentContext PaymentContext { get; set; } = null;
    }
}
