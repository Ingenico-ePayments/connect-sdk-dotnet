/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_MandateSepaDirectDebitWithoutCreditor">MandateSepaDirectDebitWithoutCreditor</a>
    /// </summary>
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
