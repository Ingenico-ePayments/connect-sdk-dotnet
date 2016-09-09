/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Errors.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Errors
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_ErrorResponse">ErrorResponse</a>
    /// </summary>
    public class ErrorResponse
    {
        public string ErrorId { get; set; } = null;

        public IList<APIError> Errors { get; set; } = null;
    }
}
