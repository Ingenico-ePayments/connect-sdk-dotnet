/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Services.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Services
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_GetIINDetailsRequest">GetIINDetailsRequest</a>
    /// </summary>
    public class GetIINDetailsRequest
    {
        public string Bin { get; set; } = null;

        public PaymentContext PaymentContext { get; set; } = null;
    }
}
