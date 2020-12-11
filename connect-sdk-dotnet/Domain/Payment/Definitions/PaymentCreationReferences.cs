/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class PaymentCreationReferences
    {
        /// <summary>
        /// The additional reference identifier for this transaction. Data in this property will also be returned in our report files, allowing you to reconcile them.
        /// </summary>
        public string AdditionalReference { get; set; } = null;

        /// <summary>
        /// The external reference identifier for this transaction. Data in this property will also be returned in our report files, allowing you to reconcile them.
        /// </summary>
        public string ExternalReference { get; set; } = null;
    }
}
