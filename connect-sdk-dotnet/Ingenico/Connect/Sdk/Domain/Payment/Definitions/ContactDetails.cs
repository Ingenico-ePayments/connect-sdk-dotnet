/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class ContactDetails : ContactDetailsBase
    {
        public string FaxNumber { get; set; } = null;

        public string MobilePhoneNumber { get; set; } = null;

        public string PhoneNumber { get; set; } = null;

        public string WorkPhoneNumber { get; set; } = null;
    }
}
