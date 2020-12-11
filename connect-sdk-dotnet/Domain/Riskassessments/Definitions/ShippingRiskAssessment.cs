/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions
{
    public class ShippingRiskAssessment
    {
        /// <summary>
        /// Object containing address information
        /// </summary>
        public AddressPersonal Address { get; set; } = null;

        /// <summary>
        /// Comments included during shipping
        /// </summary>
        public string Comments { get; set; } = null;

        /// <summary>
        /// Shipment tracking number
        /// </summary>
        public string TrackingNumber { get; set; } = null;
    }
}
