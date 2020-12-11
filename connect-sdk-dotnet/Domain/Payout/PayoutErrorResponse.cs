/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;
using Ingenico.Connect.Sdk.Domain.Payout.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Payout
{
    public class PayoutErrorResponse
    {
        /// <summary>
        /// Unique reference, for debugging purposes, of this error response
        /// </summary>
        public string ErrorId { get; set; } = null;

        /// <summary>
        /// List of one or more errors
        /// </summary>
        public IList<APIError> Errors { get; set; } = null;

        /// <summary>
        /// Object that contains details on the created payout in case one has been created
        /// </summary>
        public PayoutResult PayoutResult { get; set; } = null;
    }
}
