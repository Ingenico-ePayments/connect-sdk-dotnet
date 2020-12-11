/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Mandates.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Hostedmandatemanagement
{
    public class GetHostedMandateManagementResponse
    {
        /// <summary>
        /// When a mandate has been created during the hosted mandate management session this object will return the details.
        /// </summary>
        public MandateResponse Mandate { get; set; } = null;

        /// <summary>
        /// This is the status of the hosted mandate management. Possible values are: 
        /// <list type="bullet">
        ///   <item><description>IN_PROGRESS - The session has been created, but no mandate has been created yet.</description></item>
        ///   <item><description>MANDATE_CREATED - A mandate has been created, the customer might still need to sign the mandate.</description></item>
        ///   <item><description>FAILED - There was an error while creating the mandate, the session can not continue.</description></item>
        ///   <item><description>CANCELLED_BY_CONSUMER - The session was cancelled before a mandate was created</description></item>
        /// </list>.
        /// </summary>
        public string Status { get; set; } = null;
    }
}
