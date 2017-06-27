/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Refund.Definitions
{
    public class BankRefundMethodSpecificInput
    {
        public BankAccountBbanRefund BankAccountBban { get; set; } = null;

        public BankAccountIban BankAccountIban { get; set; } = null;

        public string CountryCode { get; set; } = null;
    }
}
