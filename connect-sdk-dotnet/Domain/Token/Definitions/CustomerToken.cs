/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    public class CustomerToken : CustomerBase
    {
        /// <summary>
        /// Object containing the billing address details
        /// </summary>
        public Address BillingAddress { get; set; } = null;

        /// <summary>
        /// Object containing personal information of the customer
        /// </summary>
        public PersonalInformationToken PersonalInformation { get; set; } = null;
    }
}
