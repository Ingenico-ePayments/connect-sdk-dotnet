/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Tokens
{
    /// <summary>
    /// Query parameters for
    /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/tokens/delete.html">Delete token</a>
    /// </summary>
    public class DeleteTokenParams : AbstractParamRequest
    {
        /// <summary>
        /// Date of the mandate cancellation
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string MandateCancelDate { get; set; } = null;

        public override IEnumerable<RequestParam> ToRequestParameters()
        {
            IList<RequestParam> result = new List<RequestParam>();
            if (MandateCancelDate != null)
            {
                result.Add(new RequestParam("mandateCancelDate", MandateCancelDate));
            }
            return result;
        }
    }
}
