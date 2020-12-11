/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    public class MandateApproval
    {
        /// <summary>
        /// The date when the mandate was signed
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string MandateSignatureDate { get; set; } = null;

        /// <summary>
        /// The city where the mandate was signed
        /// </summary>
        public string MandateSignaturePlace { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true = Mandate is signed</description></item>
        ///   <item><description>false = Mandate is not signed</description></item>
        /// </list>
        /// </summary>
        public bool? MandateSigned { get; set; } = null;
    }
}
