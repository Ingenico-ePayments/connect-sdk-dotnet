/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Dispute
{
    public class CreateDisputeRequest
    {
        /// <summary>
        /// The amount of money that is to be disputed.
        /// </summary>
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        /// <summary>
        /// The name of the person on your side who can be contacted regarding this dispute.
        /// </summary>
        public string ContactPerson { get; set; } = null;

        /// <summary>
        /// The email address of the contact person.
        /// </summary>
        public string EmailAddress { get; set; } = null;

        /// <summary>
        /// The email address to which the reply message will be sent.
        /// </summary>
        public string ReplyTo { get; set; } = null;

        /// <summary>
        /// The message sent from you to Ingenico ePayments.
        /// </summary>
        public string RequestMessage { get; set; } = null;
    }
}
