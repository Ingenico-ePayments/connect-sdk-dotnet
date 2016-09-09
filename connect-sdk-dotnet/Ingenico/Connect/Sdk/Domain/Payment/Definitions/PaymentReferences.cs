/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PaymentReferences">PaymentReferences</a>
    /// </summary>
    public class PaymentReferences
    {
        public long? MerchantOrderId { get; set; } = null;

        public string MerchantReference { get; set; } = null;

        public string PaymentReference { get; set; } = null;

        public string ProviderId { get; set; } = null;

        public string ProviderReference { get; set; } = null;

        public string ReferenceOrigPayment { get; set; } = null;
    }
}
