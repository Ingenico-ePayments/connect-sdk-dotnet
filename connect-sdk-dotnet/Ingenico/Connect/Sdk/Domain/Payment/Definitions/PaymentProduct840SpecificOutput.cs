/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PaymentProduct840SpecificOutput">PaymentProduct840SpecificOutput</a>
    /// </summary>
    public class PaymentProduct840SpecificOutput
    {
        public PaymentProduct840CustomerAccount CustomerAccount { get; set; } = null;

        public Address CustomerAddress { get; set; } = null;
    }
}
