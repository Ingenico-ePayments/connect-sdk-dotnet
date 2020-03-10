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
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        public string ContactPerson { get; set; } = null;

        public DisputeCreationDetail CreationDetails { get; set; } = null;

        public string EmailAddress { get; set; } = null;

        public IList<HostedFile> Files { get; set; } = null;

        public DisputeReference Reference { get; set; } = null;

        public string ReplyTo { get; set; } = null;

        public string RequestMessage { get; set; } = null;

        public string ResponseMessage { get; set; } = null;
    }
}
