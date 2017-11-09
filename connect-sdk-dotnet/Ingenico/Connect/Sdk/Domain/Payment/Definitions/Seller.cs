/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class Seller
    {
        public Address Address { get; set; } = null;

        public string ChannelCode { get; set; } = null;

        public string Description { get; set; } = null;

        public string Geocode { get; set; } = null;

        public string Id { get; set; } = null;

        public string InvoiceNumber { get; set; } = null;

        public string Mcc { get; set; } = null;

        public string Name { get; set; } = null;

        public string Type { get; set; } = null;
    }
}
