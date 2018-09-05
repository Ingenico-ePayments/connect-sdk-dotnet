/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Refund.Definitions
{
    public class BankAccountBbanRefund : BankAccountBban
    {
        public string BankCity { get; set; } = null;

        public string PatronymicName { get; set; } = null;

        public string SwiftCode { get; set; } = null;
    }
}
