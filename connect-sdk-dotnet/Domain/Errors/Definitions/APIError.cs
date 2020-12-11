/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Errors.Definitions
{
    public class APIError
    {
        /// <summary>
        /// Category the error belongs to. The category should give an indication of the type of error you are dealing with. Possible values: 
        /// <list type="bullet">
        ///   <item><description>CONNECT_PLATFORM_ERROR - indicating that a functional error has occurred in the Connect platform.</description></item>
        ///   <item><description>PAYMENT_PLATFORM_ERROR - indicating that a functional error has occurred in the Payment platform.</description></item>
        ///   <item><description>IO_ERROR - indicating that a technical error has occurred within the Connect platform or between Connect and any of the payment platforms or third party systems.</description></item>
        /// </list>
        /// </summary>
        public string Category { get; set; } = null;

        /// <summary>
        /// Error code
        /// </summary>
        public string Code { get; set; } = null;

        /// <summary>
        /// HTTP status code for this error that can be used to determine the type of error
        /// </summary>
        public int? HttpStatusCode { get; set; } = null;

        /// <summary>
        /// ID of the error. This is a short human-readable message that briefly describes the error.
        /// </summary>
        public string Id { get; set; } = null;

        /// <summary>
        /// Human-readable error message that is not meant to be relayed to customer as it might tip off people who are trying to commit fraud
        /// </summary>
        public string Message { get; set; } = null;

        /// <summary>
        /// Returned only if the error relates to a value that was missing or incorrect.
        /// <br />Contains a location path to the value as a 
        /// <a href="http://docs.jsonata.org/basic.html">JSonata query</a>.
        /// <br />Some common examples: 
        /// <list type="bullet">
        ///   <item><description>a.b selects the value of property b of root property a,</description></item>
        ///   <item><description>a[1] selects the first element of the array in root property a,</description></item>
        ///   <item><description>a[b='some value'] selects all elements of the array in root property a that have a property b with value 'some value'.</description></item>
        /// </list>
        /// </summary>
        public string PropertyName { get; set; } = null;

        /// <summary>
        /// ID of the request that can be used for debugging purposes
        /// </summary>
        public string RequestId { get; set; } = null;
    }
}
