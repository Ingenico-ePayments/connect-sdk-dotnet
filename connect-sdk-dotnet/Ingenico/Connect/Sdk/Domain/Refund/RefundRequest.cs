/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Refund.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Refund
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_RefundRequest">RefundRequest</a>
    /// </summary>
    public class RefundRequest
    {
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        public BankRefundMethodSpecificInput BankRefundMethodSpecificInput { get; set; } = null;

        public RefundCustomer Customer { get; set; } = null;

        public string RefundDate { get; set; } = null;

        public RefundReferences RefundReferences { get; set; } = null;
    }
}
