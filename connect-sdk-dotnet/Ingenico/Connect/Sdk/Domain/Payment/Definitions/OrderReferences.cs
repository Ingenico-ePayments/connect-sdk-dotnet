/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class OrderReferences
    {
        public string Descriptor { get; set; } = null;

        public OrderInvoiceData InvoiceData { get; set; } = null;

        public long? MerchantOrderId { get; set; } = null;

        public string MerchantReference { get; set; } = null;
    }
}
