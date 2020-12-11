/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions
{
    public class OrderRiskAssessment
    {
        /// <summary>
        /// Object containing additional input on the order
        /// </summary>
        public AdditionalOrderInputAirlineData AdditionalInput { get; set; } = null;

        /// <summary>
        /// Object containing amount and ISO currency code attributes
        /// </summary>
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        /// <summary>
        /// Object containing the details of the customer
        /// </summary>
        public CustomerRiskAssessment Customer { get; set; } = null;

        /// <summary>
        /// Object containing information regarding shipping / delivery
        /// </summary>
        public ShippingRiskAssessment Shipping { get; set; } = null;
    }
}
