/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class AddressPersonal : Address
    {
        /// <summary>
        /// Object that holds the name elements
        /// </summary>
        public PersonalName Name { get; set; } = null;
    }
}
