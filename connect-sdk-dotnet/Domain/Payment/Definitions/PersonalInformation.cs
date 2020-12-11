/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class PersonalInformation
    {
        /// <summary>
        /// The date of birth of the customer
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string DateOfBirth { get; set; } = null;

        /// <summary>
        /// The gender of the customer, possible values are: 
        /// <list type="bullet">
        ///   <item><description>male</description></item>
        ///   <item><description>female</description></item>
        ///   <item><description>unknown or empty</description></item>
        /// </list>
        /// </summary>
        public string Gender { get; set; } = null;

        /// <summary>
        /// Object containing the name details of the customer
        /// </summary>
        public PersonalName Name { get; set; } = null;
    }
}
