/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Payout.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payout
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_CreatePayoutRequest">CreatePayoutRequest</a>
    /// </summary>
    public class CreatePayoutRequest
    {
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        public BankAccountBban BankAccountBban { get; set; } = null;

        public BankAccountIban BankAccountIban { get; set; } = null;

        public PayoutCustomer Customer { get; set; } = null;

        public string PayoutDate { get; set; } = null;

        public string PayoutText { get; set; } = null;

        public PayoutReferences References { get; set; } = null;

        public string SwiftCode { get; set; } = null;
    }
}
