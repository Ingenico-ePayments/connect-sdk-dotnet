/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class OrderStatusOutput
    {
        public IList<APIError> Errors { get; set; } = null;

        public bool? IsCancellable { get; set; } = null;

        public string StatusCategory { get; set; } = null;

        public int? StatusCode { get; set; } = null;

        public string StatusCodeChangeDateTime { get; set; } = null;
    }
}
