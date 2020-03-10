/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payout.Definitions
{
    public class BankTransferPayoutMethodSpecificInput : AbstractPayoutMethodSpecificInput
    {
        public BankAccountBban BankAccountBban { get; set; } = null;

        public BankAccountIban BankAccountIban { get; set; } = null;

        public PayoutCustomer Customer { get; set; } = null;

        public string PayoutDate { get; set; } = null;

        public string PayoutText { get; set; } = null;

        public string SwiftCode { get; set; } = null;
    }
}
