/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Tokens
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://developer.globalcollect.com/documentation/api/server/#__merchantId__tokens__tokenId__delete">Delete token</a>
    /// </summary>
    public class DeleteTokenParams : AbstractParamRequest
    {
        public string MandateCancelDate { get; set; } = null;

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            IList<RequestParam> result = new List<RequestParam>();
            AddParameter(result, "mandateCancelDate", MandateCancelDate);
            return result;
        }
    }
}
