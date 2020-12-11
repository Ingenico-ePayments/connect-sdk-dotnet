/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Mandates.Definitions
{
    public class MandatePersonalInformation
    {
        /// <summary>
        /// Object containing the name details of the customer
        /// </summary>
        public MandatePersonalName Name { get; set; } = null;

        /// <summary>
        /// Object containing the title of the customer (Mr, Miss or Mrs)
        /// </summary>
        public string Title { get; set; } = null;
    }
}
