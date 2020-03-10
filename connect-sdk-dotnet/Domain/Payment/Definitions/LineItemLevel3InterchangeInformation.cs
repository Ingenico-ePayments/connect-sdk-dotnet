/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class LineItemLevel3InterchangeInformation
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
