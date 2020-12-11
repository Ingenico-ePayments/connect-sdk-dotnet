/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class LineItemInvoiceData
    {
        /// <summary>
        /// Shopping cart item description
        /// </summary>
        public string Description { get; set; } = null;

        /// <summary>
        /// Line number for printed invoice or order of items in the cart
        /// <br />Should be a numeric string
        /// </summary>
        public string MerchantLinenumber { get; set; } = null;

        /// <summary>
        /// Page number for printed invoice
        /// <br />Should be a numeric string
        /// </summary>
        public string MerchantPagenumber { get; set; } = null;

        /// <summary>
        /// Quantity of the item
        /// </summary>
        public string NrOfItems { get; set; } = null;

        /// <summary>
        /// Price per item
        /// </summary>
        public long? PricePerItem { get; set; } = null;
    }
}
