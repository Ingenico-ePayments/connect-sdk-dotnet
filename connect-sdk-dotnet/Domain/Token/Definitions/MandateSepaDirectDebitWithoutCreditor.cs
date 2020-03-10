/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    public class MandateSepaDirectDebitWithoutCreditor
    {
        public BankAccountIban BankAccountIban { get; set; } = null;

        public string CustomerContractIdentifier { get; set; } = null;

        public Debtor Debtor { get; set; } = null;

        public bool? IsRecurring { get; set; } = null;

        public MandateApproval MandateApproval { get; set; } = null;

        public string PreNotification { get; set; } = null;
    }
}
