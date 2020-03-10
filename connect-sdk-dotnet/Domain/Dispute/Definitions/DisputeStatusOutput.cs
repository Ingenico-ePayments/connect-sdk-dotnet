/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Dispute.Definitions
{
    public class DisputeStatusOutput
    {
        public bool? IsCancellable { get; set; } = null;

        public string StatusCategory { get; set; } = null;

        public int? StatusCode { get; set; } = null;

        public string StatusCodeChangeDateTime { get; set; } = null;
    }
}
