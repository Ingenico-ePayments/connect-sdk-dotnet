/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Product
{
    public class DeviceFingerprintResponse
    {
        /// <summary>
        /// Contains the unique id which is used by the device fingerprint collector script. This must be used to set the property fraudFields.deviceFingerprintTransactionId in either in the CreatePayment.order.customer.device.deviceFingerprintTransactionId, the CreateRiskAssessmentCards.order.customer.device.deviceFingerprintTransactionId or the CreateRiskAssessmentBankaccounts.order.customer.device.deviceFingerprintTransactionId.
        /// </summary>
        public string DeviceFingerprintTransactionId { get; set; } = null;

        /// <summary>
        /// Contains the ready-to-use device fingerprint collector script. You have to inject it into your page and call it when the customer presses the final payment submit button. You should only call it once per payment request.
        /// </summary>
        public string Html { get; set; } = null;
    }
}
