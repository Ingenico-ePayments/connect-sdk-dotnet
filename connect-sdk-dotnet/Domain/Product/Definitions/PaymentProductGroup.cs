/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class PaymentProductGroup
    {
        public IList<AccountOnFile> AccountsOnFile { get; set; } = null;

        public bool? DeviceFingerprintEnabled { get; set; } = null;

        public PaymentProductDisplayHints DisplayHints { get; set; } = null;

        public IList<PaymentProductField> Fields { get; set; } = null;

        public string Id { get; set; } = null;
    }
}
