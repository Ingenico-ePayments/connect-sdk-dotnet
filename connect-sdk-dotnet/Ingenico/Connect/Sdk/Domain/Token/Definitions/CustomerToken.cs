/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_CustomerToken">CustomerToken</a>
    /// </summary>
    public class CustomerToken : CustomerBase
    {
        public Address BillingAddress { get; set; } = null;

        public PersonalInformationToken PersonalInformation { get; set; } = null;
    }
}
