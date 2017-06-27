/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Payment
{
    public class PaymentErrorResponse
    {
        public string ErrorId { get; set; } = null;

        public IList<APIError> Errors { get; set; } = null;

        public CreatePaymentResult PaymentResult { get; set; } = null;
    }
}
