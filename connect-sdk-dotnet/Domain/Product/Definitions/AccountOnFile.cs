/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class AccountOnFile
    {
        /// <summary>
        /// Array containing the details of the stored token
        /// </summary>
        public IList<AccountOnFileAttribute> Attributes { get; set; } = null;

        /// <summary>
        /// Object containing information for the client on how best to display this field
        /// </summary>
        public AccountOnFileDisplayHints DisplayHints { get; set; } = null;

        /// <summary>
        /// ID of the account on file record
        /// </summary>
        public int? Id { get; set; } = null;

        /// <summary>
        /// Payment product identifier
        /// <br />Please see 
        /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/paymentproducts.html">payment products</a> for a full overview of possible values.
        /// </summary>
        public int? PaymentProductId { get; set; } = null;
    }
}
