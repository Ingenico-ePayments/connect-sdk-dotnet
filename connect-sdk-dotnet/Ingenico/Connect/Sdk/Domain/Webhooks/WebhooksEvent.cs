using System;
using Ingenico.Connect.Sdk.Domain.Payment;
using Ingenico.Connect.Sdk.Domain.Refund;
using Ingenico.Connect.Sdk.Domain.Payout;
using Ingenico.Connect.Sdk.Domain.Token;

namespace Ingenico.Connect.Sdk
{
    public class WebhooksEvent
    {
        public String ApiVersion { get; set; }

        public String Id { get; set; }

        public String Created { get; set; }

        public String MerchantId { get; set; }

        public String Type { get; set; }

        public PaymentResponse Payment { get; set; }

        public RefundResponse Refund { get; set; }

        public PayoutResponse Payout { get; set; }

        public TokenResponse Token { get; set; }
    }
}
