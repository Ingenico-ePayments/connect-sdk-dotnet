/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PaymentProduct">PaymentProduct</a>
    /// </summary>
    public class PaymentProduct
    {
        public IList<AccountOnFile> AccountsOnFile { get; set; } = null;

        public bool? AllowsRecurring { get; set; } = null;

        public bool? AllowsTokenization { get; set; } = null;

        public bool? AutoTokenized { get; set; } = null;

        public PaymentProductDisplayHints DisplayHints { get; set; } = null;

        public IList<PaymentProductField> Fields { get; set; } = null;

        public int? Id { get; set; } = null;

        public long? MaxAmount { get; set; } = null;

        public long? MinAmount { get; set; } = null;

        public string MobileIntegrationLevel { get; set; } = null;

        public string PaymentMethod { get; set; } = null;

        public string PaymentProductGroup { get; set; } = null;

        public bool? UsesRedirectionTo3rdParty { get; set; } = null;
    }
}
