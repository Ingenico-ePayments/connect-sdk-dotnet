/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    public class Debtor
    {
        /// <summary>
        /// Additional information about the debtor's address, like Suite II, Apartment 2a
        /// </summary>
        public string AdditionalAddressInfo { get; set; } = null;

        /// <summary>
        /// City of the debtor's address
        /// </summary>
        public string City { get; set; } = null;

        /// <summary>
        /// ISO 3166-1 alpha-2 country code of the debtor's address
        /// </summary>
        public string CountryCode { get; set; } = null;

        /// <summary>
        /// Debtor first name
        /// </summary>
        public string FirstName { get; set; } = null;

        /// <summary>
        /// House number of the debtor's address
        /// </summary>
        public string HouseNumber { get; set; } = null;

        /// <summary>
        /// State of debtor address
        /// </summary>
        public string State { get; set; } = null;

        /// <summary>
        /// ISO 3166-2 alpha-3 state code
        /// <br />Notes:
        /// <br />
        /// <list type="bullet">
        ///   <item><description>The maximum length for 3-D Secure version 2 is AN3.</description></item>
        ///   <item><description>The maximum length for paymentProductId 1503 (Boleto) is AN2.</description></item>
        /// </list>
        /// </summary>
        public string StateCode { get; set; } = null;

        /// <summary>
        /// Street of debtor's address
        /// </summary>
        public string Street { get; set; } = null;

        /// <summary>
        /// Debtor's last name
        /// </summary>
        public string Surname { get; set; } = null;

        /// <summary>
        /// Prefix of the debtor's last name
        /// </summary>
        public string SurnamePrefix { get; set; } = null;

        /// <summary>
        /// ZIP code of the debtor's address
        /// </summary>
        public string Zip { get; set; } = null;
    }
}
