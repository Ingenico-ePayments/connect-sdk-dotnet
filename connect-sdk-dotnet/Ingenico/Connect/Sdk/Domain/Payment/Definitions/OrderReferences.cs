/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_OrderReferences">OrderReferences</a>
    /// </summary>
    public class OrderReferences
    {
        public string Descriptor { get; set; } = null;

        public OrderInvoiceData InvoiceData { get; set; } = null;

        public long? MerchantOrderId { get; set; } = null;

        public string MerchantReference { get; set; } = null;
    }
}
