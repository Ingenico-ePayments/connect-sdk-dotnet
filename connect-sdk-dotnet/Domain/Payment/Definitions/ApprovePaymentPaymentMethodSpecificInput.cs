/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class ApprovePaymentPaymentMethodSpecificInput
    {
        /// <summary>
        /// The desired date for the collection
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string DateCollect { get; set; } = null;

        /// <summary>
        /// Token containing tokenized bank account details
        /// </summary>
        public string Token { get; set; } = null;
    }
}
