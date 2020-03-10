/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class PaymentStatusOutput : OrderStatusOutput
    {
        public bool? IsAuthorized { get; set; } = null;

        public bool? IsRefundable { get; set; } = null;

        public string ThreeDSecureStatus { get; set; } = null;
    }
}
