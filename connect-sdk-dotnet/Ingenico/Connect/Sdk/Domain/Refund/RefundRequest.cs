/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Refund.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Refund
{
    public class RefundRequest
    {
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        public BankRefundMethodSpecificInput BankRefundMethodSpecificInput { get; set; } = null;

        public RefundCustomer Customer { get; set; } = null;

        public string RefundDate { get; set; } = null;

        public RefundReferences RefundReferences { get; set; } = null;
    }
}
