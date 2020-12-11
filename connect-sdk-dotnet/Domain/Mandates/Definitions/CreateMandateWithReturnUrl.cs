/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Mandates.Definitions
{
    public class CreateMandateWithReturnUrl : CreateMandateBase
    {
        /// <summary>
        /// Return URL to use if the mandate signing requires redirection.
        /// </summary>
        public string ReturnUrl { get; set; } = null;
    }
}
