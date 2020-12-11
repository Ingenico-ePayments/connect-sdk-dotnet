/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.File.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Dispute.Definitions
{
    public class DisputeOutput
    {
        /// <summary>
        /// Object containing amount and ISO currency code attributes
        /// </summary>
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        /// <summary>
        /// The name of the person on your side who can be contacted regarding this dispute.
        /// </summary>
        public string ContactPerson { get; set; } = null;

        /// <summary>
        /// Object containing various details related to this dispute&#8217;s creation.
        /// </summary>
        public DisputeCreationDetail CreationDetails { get; set; } = null;

        /// <summary>
        /// The email address of the contact person.
        /// </summary>
        public string EmailAddress { get; set; } = null;

        /// <summary>
        /// An array containing all files related to this dispute.
        /// </summary>
        public IList<HostedFile> Files { get; set; } = null;

        /// <summary>
        /// A collection of reference information related to this dispute.
        /// </summary>
        public DisputeReference Reference { get; set; } = null;

        /// <summary>
        /// The email address to which the reply message will be sent.
        /// </summary>
        public string ReplyTo { get; set; } = null;

        /// <summary>
        /// The message sent from you to Ingenico ePayments.
        /// </summary>
        public string RequestMessage { get; set; } = null;

        /// <summary>
        /// The return message sent from the GlobalCollect platform to you.
        /// </summary>
        public string ResponseMessage { get; set; } = null;
    }
}
