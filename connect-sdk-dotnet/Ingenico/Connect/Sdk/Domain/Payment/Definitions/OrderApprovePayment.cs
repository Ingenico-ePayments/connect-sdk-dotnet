/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class OrderApprovePayment
    {
        public AdditionalOrderInputAirlineData AdditionalInput { get; set; } = null;

        public CustomerApprovePayment Customer { get; set; } = null;

        public OrderReferencesApprovePayment References { get; set; } = null;
    }
}
