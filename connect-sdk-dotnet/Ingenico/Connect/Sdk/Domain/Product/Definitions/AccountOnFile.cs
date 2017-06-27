/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class AccountOnFile
    {
        public IList<AccountOnFileAttribute> Attributes { get; set; } = null;

        public AccountOnFileDisplayHints DisplayHints { get; set; } = null;

        public int? Id { get; set; } = null;

        public int? PaymentProductId { get; set; } = null;
    }
}
