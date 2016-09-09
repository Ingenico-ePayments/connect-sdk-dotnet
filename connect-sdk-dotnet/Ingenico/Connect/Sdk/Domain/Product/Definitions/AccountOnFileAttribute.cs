/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_AccountOnFileAttribute">AccountOnFileAttribute</a>
    /// </summary>
    public class AccountOnFileAttribute : KeyValuePair
    {
        public string MustWriteReason { get; set; } = null;

        public string Status { get; set; } = null;
    }
}
