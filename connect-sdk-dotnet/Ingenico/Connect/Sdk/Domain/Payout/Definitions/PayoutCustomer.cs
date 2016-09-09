/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payout.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PayoutCustomer">PayoutCustomer</a>
    /// </summary>
    public class PayoutCustomer
    {
        public Address Address { get; set; } = null;

        public CompanyInformation CompanyInformation { get; set; } = null;

        public ContactDetailsBase ContactDetails { get; set; } = null;

        public string MerchantCustomerId { get; set; } = null;

        public PersonalName Name { get; set; } = null;
    }
}
