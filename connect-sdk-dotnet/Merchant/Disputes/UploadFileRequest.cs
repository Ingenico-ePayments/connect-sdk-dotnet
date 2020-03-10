/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Merchant.Disputes
{
    /// <summary>
    /// Multipart/form-data parameters for
    /// <a href="https://epayments-api.developer-ingenico.com/fileserviceapi/v1/en_US/dotnet/disputes/uploadFile.html">Upload File</a>
    /// </summary>
    public class UploadFileRequest : IMultipartFormDataRequest
    {
        public UploadableFile File { get; set; } = null;

        public MultipartFormDataObject ToMultipartFormDataObject()
        {
            MultipartFormDataObject result = new MultipartFormDataObject();
            if (File != null)
            {
                result.AddFile("file", File);
            }
            return result;
        }
    }
}
