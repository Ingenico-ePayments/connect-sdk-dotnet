/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_OrderStatusOutput">OrderStatusOutput</a>
    /// </summary>
    public class OrderStatusOutput
    {
        public IList<APIError> Errors { get; set; } = null;

        public bool? IsCancellable { get; set; } = null;

        public string StatusCategory { get; set; } = null;

        public int? StatusCode { get; set; } = null;

        public string StatusCodeChangeDateTime { get; set; } = null;
    }
}
