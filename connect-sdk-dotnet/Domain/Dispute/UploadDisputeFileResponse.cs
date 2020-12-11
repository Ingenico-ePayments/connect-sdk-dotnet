/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Dispute
{
    public class UploadDisputeFileResponse
    {
        /// <summary>
        /// Dispute ID that is associated with the created dispute.
        /// </summary>
        public string DisputeId { get; set; } = null;

        /// <summary>
        /// The file ID that is associated with the uploaded file. This ID can be used for further communication regarding the file and retrieval of aforementioned property.
        /// </summary>
        public string FileId { get; set; } = null;
    }
}
