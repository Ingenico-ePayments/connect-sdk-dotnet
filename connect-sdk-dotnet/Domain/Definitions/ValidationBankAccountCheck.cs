/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class ValidationBankAccountCheck
    {
        /// <summary>
        /// Code of the bank account validation check
        /// </summary>
        public string Code { get; set; } = null;

        /// <summary>
        /// Description of check performed
        /// </summary>
        public string Description { get; set; } = null;

        /// <summary>
        /// Result of the bank account validation check performed, with the following possible results: 
        /// <list type="bullet">
        ///   <item><description>PASSED - The check passed</description></item>
        ///   <item><description>ERROR - The check did not pass</description></item>
        ///   <item><description>WARNING - Depending on your needs this either needs to be treated as a passed or error response. It depends on your business logic and for what purpose you want to use the validated bank account details.</description></item>
        ///   <item><description>NOTCHECKED - This check was not performed, usually because one of the earlier checks already caused an error response to be triggered</description></item>
        /// </list>
        /// </summary>
        public string Result { get; set; } = null;
    }
}
