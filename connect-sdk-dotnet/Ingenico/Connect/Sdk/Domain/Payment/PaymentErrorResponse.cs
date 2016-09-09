/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Payment
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PaymentErrorResponse">PaymentErrorResponse</a>
    /// </summary>
    public class PaymentErrorResponse
    {
        public string ErrorId { get; set; } = null;

        public IList<APIError> Errors { get; set; } = null;

        public CreatePaymentResult PaymentResult { get; set; } = null;
    }
}
