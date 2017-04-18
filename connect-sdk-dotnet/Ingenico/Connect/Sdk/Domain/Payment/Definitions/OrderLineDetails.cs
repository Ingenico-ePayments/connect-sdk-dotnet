/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_OrderLineDetails">OrderLineDetails</a>
    /// </summary>
    public class OrderLineDetails
    {
        public long? DiscountAmount { get; set; } = null;

        public long? LineAmountTotal { get; set; } = null;

        public string ProductCode { get; set; } = null;

        public long? ProductPrice { get; set; } = null;

        public string ProductType { get; set; } = null;

        public long? Quantity { get; set; } = null;

        public long? TaxAmount { get; set; } = null;

        public string Unit { get; set; } = null;
    }
}
