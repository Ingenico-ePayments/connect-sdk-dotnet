/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Errors.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_APIError">APIError</a>
    /// </summary>
    public class APIError
    {
        public string Code { get; set; } = null;

        public int? HttpStatusCode { get; set; } = null;

        public string Message { get; set; } = null;

        public string PropertyName { get; set; } = null;

        public string RequestId { get; set; } = null;
    }
}
