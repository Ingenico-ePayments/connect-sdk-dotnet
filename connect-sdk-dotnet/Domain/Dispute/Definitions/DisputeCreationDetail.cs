/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Dispute.Definitions
{
    public class DisputeCreationDetail
    {
        /// <summary>
        /// The date and time of creation of this dispute, in yyyyMMddHHmmss format.
        /// </summary>
        public string DisputeCreationDate { get; set; } = null;

        /// <summary>
        /// The originator of this dispute, which is either Ingenico ePayments or you as our client.
        /// </summary>
        public string DisputeOriginator { get; set; } = null;

        /// <summary>
        /// The user account name of the dispute creator.
        /// </summary>
        public string UserName { get; set; } = null;
    }
}
