/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Payment.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions
{
    public class ShippingRiskAssessment
    {
        public AddressPersonal Address { get; set; } = null;

        public string Comments { get; set; } = null;

        public string TrackingNumber { get; set; } = null;
    }
}
