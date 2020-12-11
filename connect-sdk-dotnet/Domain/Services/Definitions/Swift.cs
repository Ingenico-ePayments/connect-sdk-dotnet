/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Services.Definitions
{
    public class Swift
    {
        /// <summary>
        /// The BIC is the Business Identifier Code, also known as SWIFT or Bank Identifier code. It is a code with an internationally agreed format to Identify a specific bank or even branch. The BIC contains 8 or 11 positions: the first 4 contain the bank code, followed by the country code and location code.
        /// </summary>
        public string Bic { get; set; } = null;

        /// <summary>
        /// SWIFT category
        /// </summary>
        public string Category { get; set; } = null;

        /// <summary>
        /// Clearing House Interbank Payments System (CHIPS) UID
        /// <br />CHIPS is one half of the primary US network of large-value domestic and international payments.
        /// </summary>
        public string ChipsUID { get; set; } = null;

        /// <summary>
        /// SWIFT extra information
        /// </summary>
        public string ExtraInfo { get; set; } = null;

        /// <summary>
        /// Institution PO Box country
        /// </summary>
        public string PoBoxCountry { get; set; } = null;

        /// <summary>
        /// Institution PO Box location
        /// </summary>
        public string PoBoxLocation { get; set; } = null;

        /// <summary>
        /// Institution PO Box number
        /// </summary>
        public string PoBoxNumber { get; set; } = null;

        /// <summary>
        /// Institution PO Box ZIP
        /// </summary>
        public string PoBoxZip { get; set; } = null;

        /// <summary>
        /// Payment routing BIC
        /// </summary>
        public string RoutingBic { get; set; } = null;

        /// <summary>
        /// SWIFT services
        /// </summary>
        public string Services { get; set; } = null;
    }
}
