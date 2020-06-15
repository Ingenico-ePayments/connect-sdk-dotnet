/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class PaymentProduct
    {
        public IList<AccountOnFile> AccountsOnFile { get; set; } = null;

        public bool? AllowsInstallments { get; set; } = null;

        public bool? AllowsRecurring { get; set; } = null;

        public bool? AllowsTokenization { get; set; } = null;

        public AuthenticationIndicator AuthenticationIndicator { get; set; } = null;

        public bool? AutoTokenized { get; set; } = null;

        public bool? CanBeIframed { get; set; } = null;

        public bool? DeviceFingerprintEnabled { get; set; } = null;

        public PaymentProductDisplayHints DisplayHints { get; set; } = null;

        public IList<PaymentProductField> Fields { get; set; } = null;

        public string FieldsWarning { get; set; } = null;

        public int? Id { get; set; } = null;

        public bool? IsJavaScriptRequired { get; set; } = null;

        public long? MaxAmount { get; set; } = null;

        public long? MinAmount { get; set; } = null;

        public string MobileIntegrationLevel { get; set; } = null;

        public string PaymentMethod { get; set; } = null;

        public PaymentProduct302SpecificData PaymentProduct302SpecificData { get; set; } = null;

        public PaymentProduct320SpecificData PaymentProduct320SpecificData { get; set; } = null;

        public PaymentProduct863SpecificData PaymentProduct863SpecificData { get; set; } = null;

        public string PaymentProductGroup { get; set; } = null;

        public bool? UsesRedirectionTo3rdParty { get; set; } = null;
    }
}
