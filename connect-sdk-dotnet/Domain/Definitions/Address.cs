/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class Address
    {
        /// <summary>
        /// Additional address information
        /// </summary>
        public string AdditionalInfo { get; set; } = null;

        /// <summary>
        /// City
        /// <br />Note: For payments with product 1503 the maximum length is not 40 but 20.
        /// </summary>
        public string City { get; set; } = null;

        /// <summary>
        /// ISO 3166-1 alpha-2 country code
        /// </summary>
        public string CountryCode { get; set; } = null;

        /// <summary>
        /// House number
        /// </summary>
        public string HouseNumber { get; set; } = null;

        /// <summary>
        /// Full name of the state or province
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
        /// Streetname
        /// </summary>
        public string Street { get; set; } = null;

        /// <summary>
        /// Zip code
        /// <br />Note: For payments with product 1503 the maximum length is not 10 but 8.
        /// </summary>
        public string Zip { get; set; } = null;
    }
}
