/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PaymentProductGroup">PaymentProductGroup</a>
    /// </summary>
    public class PaymentProductGroup
    {
        public IList<AccountOnFile> AccountsOnFile { get; set; } = null;

        public PaymentProductDisplayHints DisplayHints { get; set; } = null;

        public IList<PaymentProductField> Fields { get; set; } = null;

        public string Id { get; set; } = null;
    }
}
