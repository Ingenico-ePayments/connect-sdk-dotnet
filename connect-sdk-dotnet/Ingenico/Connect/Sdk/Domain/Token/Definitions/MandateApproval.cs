/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Token.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_MandateApproval">MandateApproval</a>
    /// </summary>
    public class MandateApproval
    {
        public string MandateSignatureDate { get; set; } = null;

        public string MandateSignaturePlace { get; set; } = null;

        public bool? MandateSigned { get; set; } = null;
    }
}
