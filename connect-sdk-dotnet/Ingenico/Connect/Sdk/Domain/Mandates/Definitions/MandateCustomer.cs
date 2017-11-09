/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Mandates.Definitions
{
    public class MandateCustomer
    {
        public BankAccountIban BankAccountIban { get; set; } = null;

        public string CompanyName { get; set; } = null;

        public MandateContactDetails ContactDetails { get; set; } = null;

        public MandateAddress MandateAddress { get; set; } = null;

        public MandatePersonalInformation PersonalInformation { get; set; } = null;
    }
}
