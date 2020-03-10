using System;
using Ingenico.Connect.Sdk.Domain.Dispute;
using Ingenico.Connect.Sdk.Domain.Payment;
using Ingenico.Connect.Sdk.Domain.Refund;
using Ingenico.Connect.Sdk.Domain.Payout;
using Ingenico.Connect.Sdk.Domain.Token;

namespace Ingenico.Connect.Sdk
{
    public class WebhooksEvent
    {
        public string ApiVersion { get; set; }

        public string Id { get; set; }

        public string Created { get; set; }

        public string MerchantId { get; set; }

        public string Type { get; set; }

        public PaymentResponse Payment { get; set; }

        public RefundResponse Refund { get; set; }

        public PayoutResponse Payout { get; set; }

        public TokenResponse Token { get; set; }

        public DisputeResponse Dispute { get; set; }
    }
}
