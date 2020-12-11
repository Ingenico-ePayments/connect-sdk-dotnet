/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Product
{
    public class GetCustomerDetailsResponse
    {
        /// <summary>
        /// The city in which the customer resides.
        /// </summary>
        public string City { get; set; } = null;

        /// <summary>
        /// The country in which the customer resides.
        /// </summary>
        public string Country { get; set; } = null;

        /// <summary>
        /// The email address registered to the customer.
        /// </summary>
        public string EmailAddress { get; set; } = null;

        /// <summary>
        /// The first name of the customer
        /// </summary>
        public string FirstName { get; set; } = null;

        /// <summary>
        /// The fiscal number (SSN) for the customer.
        /// </summary>
        public string FiscalNumber { get; set; } = null;

        /// <summary>
        /// The code of the language used by the customer.
        /// </summary>
        public string LanguageCode { get; set; } = null;

        /// <summary>
        /// The phone number registered to the customer.
        /// </summary>
        public string PhoneNumber { get; set; } = null;

        /// <summary>
        /// The street on which the customer resides.
        /// </summary>
        public string Street { get; set; } = null;

        /// <summary>
        /// The surname or family name of the customer.
        /// </summary>
        public string Surname { get; set; } = null;

        /// <summary>
        /// The ZIP or postal code for the area in which the customer resides.
        /// </summary>
        public string Zip { get; set; } = null;
    }
}
