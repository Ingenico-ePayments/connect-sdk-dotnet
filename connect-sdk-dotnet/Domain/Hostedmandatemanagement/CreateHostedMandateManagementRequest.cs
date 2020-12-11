/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Hostedmandatemanagement.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Hostedmandatemanagement
{
    public class CreateHostedMandateManagementRequest
    {
        /// <summary>
        /// Object containing partial information needed for the creation of the mandate. The recurrencetype, signature type of the mandate and reference to the customer are mandatory. You can also supply any personal information you already know about the customer so they have to fill in less details.
        /// </summary>
        public HostedMandateInfo CreateMandateInfo { get; set; } = null;

        /// <summary>
        /// Object containing hosted mandate management specific data
        /// </summary>
        public HostedMandateManagementSpecificInput HostedMandateManagementSpecificInput { get; set; } = null;
    }
}
