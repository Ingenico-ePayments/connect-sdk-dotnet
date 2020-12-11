/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Mandates.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Hostedmandatemanagement.Definitions
{
    public class HostedMandateInfo
    {
        /// <summary>
        /// An alias for the mandate. This can be used to visually represent the mandate.
        /// <br />Do not include any unobfuscated sensitive data in the alias.
        /// <br />Default value if not provided is the obfuscated IBAN of the customer.
        /// </summary>
        public string Alias { get; set; } = null;

        /// <summary>
        /// Customer object containing customer specific inputs
        /// </summary>
        public MandateCustomer Customer { get; set; } = null;

        /// <summary>
        /// The unique identifier of a customer
        /// </summary>
        public string CustomerReference { get; set; } = null;

        /// <summary>
        /// Specifies whether the mandate is for one-off or recurring payments. Possible values are:
        /// <br />
        /// <list type="bullet">
        ///   <item><description>UNIQUE</description></item>
        ///   <item><description>RECURRING</description></item>
        /// </list>
        /// </summary>
        public string RecurrenceType { get; set; } = null;

        /// <summary>
        /// Specifies whether the mandate is unsigned or singed by SMS. Possible values are:
        /// <br />
        /// <list type="bullet">
        ///   <item><description>UNSIGNED</description></item>
        ///   <item><description>SMS</description></item>
        /// </list>
        /// </summary>
        public string SignatureType { get; set; } = null;

        /// <summary>
        /// The unique identifier of the mandate
        /// </summary>
        public string UniqueMandateReference { get; set; } = null;
    }
}
