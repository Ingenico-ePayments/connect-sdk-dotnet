/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_AccountOnFile">AccountOnFile</a>
    /// </summary>
    public class AccountOnFile
    {
        public IList<AccountOnFileAttribute> Attributes { get; set; } = null;

        public AccountOnFileDisplayHints DisplayHints { get; set; } = null;

        public int? Id { get; set; } = null;

        public int? PaymentProductId { get; set; } = null;
    }
}
