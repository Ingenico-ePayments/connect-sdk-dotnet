/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class PersonalNameBase
    {
        /// <summary>
        /// Given name(s) or first name(s) of the customer
        /// </summary>
        public string FirstName { get; set; } = null;

        public string Surname { get; set; } = null;

        /// <summary>
        /// Middle name - In between first name and surname - of the customer
        /// </summary>
        public string SurnamePrefix { get; set; } = null;
    }
}
