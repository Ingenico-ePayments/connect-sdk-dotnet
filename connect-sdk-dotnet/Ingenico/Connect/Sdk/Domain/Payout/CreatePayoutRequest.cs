/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Payout.Definitions;
using System;

namespace Ingenico.Connect.Sdk.Domain.Payout
{
    public class CreatePayoutRequest
    {
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        [ObsoleteAttribute("Moved to BankTransferPayoutMethodSpecificInput")]
        public BankAccountBban BankAccountBban { get; set; } = null;

        [ObsoleteAttribute("Moved to BankTransferPayoutMethodSpecificInput")]
        public BankAccountIban BankAccountIban { get; set; } = null;

        public BankTransferPayoutMethodSpecificInput BankTransferPayoutMethodSpecificInput { get; set; } = null;

        public CardPayoutMethodSpecificInput CardPayoutMethodSpecificInput { get; set; } = null;

        [ObsoleteAttribute("Moved to BankTransferPayoutMethodSpecificInput")]
        public PayoutCustomer Customer { get; set; } = null;

        [ObsoleteAttribute("Moved to BankTransferPayoutMethodSpecificInput")]
        public string PayoutDate { get; set; } = null;

        [ObsoleteAttribute("Moved to BankTransferPayoutMethodSpecificInput")]
        public string PayoutText { get; set; } = null;

        public PayoutReferences References { get; set; } = null;

        [ObsoleteAttribute("Moved to BankTransferPayoutMethodSpecificInput")]
        public string SwiftCode { get; set; } = null;
    }
}
