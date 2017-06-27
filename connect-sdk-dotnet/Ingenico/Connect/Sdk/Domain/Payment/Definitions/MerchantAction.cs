/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class MerchantAction
    {
        public string ActionType { get; set; } = null;

        public RedirectData RedirectData { get; set; } = null;

        public string RenderingData { get; set; } = null;

        public IList<KeyValuePair> ShowData { get; set; } = null;
    }
}
