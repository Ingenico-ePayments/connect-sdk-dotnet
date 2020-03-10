/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;
using KeyValuePair = Ingenico.Connect.Sdk.Domain.Definitions.KeyValuePair;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    public class DisplayedData
    {
        public string DisplayedDataType { get; set; } = null;

        public string RenderingData { get; set; } = null;

        public IList<KeyValuePair> ShowData { get; set; } = null;
    }
}
