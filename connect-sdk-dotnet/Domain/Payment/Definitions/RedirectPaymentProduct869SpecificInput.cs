/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RedirectPaymentProduct869SpecificInput
    {
        /// <summary>
        /// ID of the issuing bank of the customer. A list of available issuerIDs can be obtained by using the retrieve payment product directory API.
        /// </summary>
        public string IssuerId { get; set; } = null;

        /// <summary>
        /// The name as described on the Resident Identity Card of the People's Republic of China.
        /// </summary>
        public string ResidentIdName { get; set; } = null;

        /// <summary>
        /// The identification number as described on the Resident Identity Card of the People's Republic of China.
        /// </summary>
        public string ResidentIdNumber { get; set; } = null;
    }
}
