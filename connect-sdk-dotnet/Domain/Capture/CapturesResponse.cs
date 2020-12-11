/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Capture
{
    public class CapturesResponse
    {
        /// <summary>
        /// The list of all captures performed on the requested payment.
        /// </summary>
        public IList<Definitions.Capture> Captures { get; set; } = null;
    }
}
