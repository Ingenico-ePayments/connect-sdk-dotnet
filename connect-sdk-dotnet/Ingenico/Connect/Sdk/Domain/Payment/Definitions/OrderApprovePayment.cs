/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_OrderApprovePayment">OrderApprovePayment</a>
    /// </summary>
    public class OrderApprovePayment
    {
        public AdditionalOrderInputAirlineData AdditionalInput { get; set; } = null;

        public OrderReferencesApprovePayment References { get; set; } = null;
    }
}
