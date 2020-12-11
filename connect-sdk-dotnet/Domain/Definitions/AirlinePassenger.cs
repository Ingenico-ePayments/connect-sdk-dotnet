/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class AirlinePassenger
    {
        /// <summary>
        /// First name of the passenger (this property is used for fraud screening on the Ogone Payment Platform)
        /// </summary>
        public string FirstName { get; set; } = null;

        /// <summary>
        /// Surname of the passenger (this property is used for fraud screening on the Ogone Payment Platform)
        /// </summary>
        public string Surname { get; set; } = null;

        /// <summary>
        /// Surname prefix of the passenger (this property is used for fraud screening on the Ogone Payment Platform)
        /// </summary>
        public string SurnamePrefix { get; set; } = null;

        /// <summary>
        /// Title of the passenger (this property is used for fraud screening on the Ogone Payment Platform)
        /// </summary>
        public string Title { get; set; } = null;
    }
}
