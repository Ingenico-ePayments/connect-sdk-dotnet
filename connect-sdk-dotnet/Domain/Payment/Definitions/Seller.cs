/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class Seller
    {
        /// <summary>
        /// Object containing the seller address details
        /// </summary>
        public Address Address { get; set; } = null;

        /// <summary>
        /// This property is specific to Visa Argentina. Channelcode according to Prisma. Please contact the acquirer to get the full list you need to use.
        /// </summary>
        public string ChannelCode { get; set; } = null;

        /// <summary>
        /// Description of the seller
        /// </summary>
        public string Description { get; set; } = null;

        /// <summary>
        /// The sellers geocode
        /// </summary>
        public string Geocode { get; set; } = null;

        /// <summary>
        /// The sellers identifier
        /// </summary>
        public string Id { get; set; } = null;

        /// <summary>
        /// Invoice number of the payment
        /// </summary>
        public string InvoiceNumber { get; set; } = null;

        /// <summary>
        /// Merchant category code
        /// </summary>
        public string Mcc { get; set; } = null;

        /// <summary>
        /// Name of the seller
        /// </summary>
        public string Name { get; set; } = null;

        /// <summary>
        /// Seller type. Possible values: 
        /// <list type="bullet">
        ///   <item><description>passport</description></item>
        ///   <item><description>dni</description></item>
        ///   <item><description>arg-identity-card</description></item>
        ///   <item><description>civic-notebook</description></item>
        ///   <item><description>enrollment-book</description></item>
        ///   <item><description>cuil</description></item>
        ///   <item><description>cuit</description></item>
        ///   <item><description>general-register</description></item>
        ///   <item><description>election-title</description></item>
        ///   <item><description>cpf</description></item>
        ///   <item><description>cnpj</description></item>
        ///   <item><description>ssn</description></item>
        ///   <item><description>citizen-ship</description></item>
        ///   <item><description>col-identity-card</description></item>
        ///   <item><description>alien-registration</description></item>
        /// </list>
        /// </summary>
        public string Type { get; set; } = null;
    }
}
