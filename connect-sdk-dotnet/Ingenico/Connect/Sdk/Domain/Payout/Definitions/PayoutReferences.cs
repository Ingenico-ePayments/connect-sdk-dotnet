/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Payout.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PayoutReferences">PayoutReferences</a>
    /// </summary>
    public class PayoutReferences
    {
        public string InvoiceNumber { get; set; } = null;

        public long? MerchantOrderId { get; set; } = null;

        public string MerchantReference { get; set; } = null;
    }
}
