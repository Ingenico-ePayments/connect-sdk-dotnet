/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class PersonalIdentification
    {
        /// <summary>
        /// ISO 3166-1 alpha-2 country code of the country that issued the identification document
        /// </summary>
        public string IdIssuingCountryCode { get; set; } = null;

        /// <summary>
        /// Indicates the type of identification 
        /// <list type="bullet">
        ///   <item><description>nationalIdentification = The provided idValue is a national identification number.</description></item>
        ///   <item><description>passportNumber = The provided idValue is a passport number.</description></item>
        ///   <item><description>driverLicense = The provided idValue is driving License of the individual.</description></item>
        ///   <item><description>companyRegistrationNumber = The provided idValue is a company identifier. It verifies its legal existence as an incorporated entity.</description></item>
        ///   <item><description>socialSecurityNumber =n The provided idValue is a social security number, issued to an individual by the individual's government.</description></item>
        ///   <item><description>alienRegistrationNumber = The provided idValue is an alien registration number, provided by immigration services of a country.</description></item>
        ///   <item><description>lawEnforcementIdentification = The provided idValue is an alien registration number, provided by immigration services of a country.</description></item>
        ///   <item><description>militaryIdentification = The provided idValue is an identification issued to military personnel of a country.</description></item>
        /// </list>
        /// </summary>
        public string IdType { get; set; } = null;

        /// <summary>
        /// The value of the identification
        /// </summary>
        public string IdValue { get; set; } = null;
    }
}
