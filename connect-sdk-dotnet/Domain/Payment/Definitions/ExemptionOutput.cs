/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class ExemptionOutput
    {
        /// <summary>
        /// Type of strong customer authentication (SCA) exemption that was raised towards the acquirer for this transaction.
        /// </summary>
        public string ExemptionRaised { get; set; } = null;

        /// <summary>
        /// The request exemption could not be granted. The reason why is returned in this property.
        /// </summary>
        public string ExemptionRejectionReason { get; set; } = null;

        /// <summary>
        /// Type of strong customer authentication (SCA) exemption requested by you for this transaction.
        /// </summary>
        public string ExemptionRequest { get; set; } = null;
    }
}
