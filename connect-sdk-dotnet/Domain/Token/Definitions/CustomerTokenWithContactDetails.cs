/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    public class CustomerTokenWithContactDetails : CustomerToken
    {
        /// <summary>
        /// Object containing contact details like email address and phone number
        /// </summary>
        public ContactDetailsToken ContactDetails { get; set; } = null;
    }
}
