/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_LineItemInvoiceData">LineItemInvoiceData</a>
    /// </summary>
    public class LineItemInvoiceData
    {
        public string Description { get; set; } = null;

        public string MerchantLinenumber { get; set; } = null;

        public string MerchantPagenumber { get; set; } = null;

        public string NrOfItems { get; set; } = null;

        public long? PricePerItem { get; set; } = null;
    }
}
