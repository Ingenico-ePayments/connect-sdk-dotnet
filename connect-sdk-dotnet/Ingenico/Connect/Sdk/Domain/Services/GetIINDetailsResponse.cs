/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Services.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Services
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_GetIINDetailsResponse">GetIINDetailsResponse</a>
    /// </summary>
    public class GetIINDetailsResponse
    {
        public IList<IINDetail> CoBrands { get; set; } = null;

        public string CountryCode { get; set; } = null;

        public bool? IsAllowedInContext { get; set; } = null;

        public int? PaymentProductId { get; set; } = null;
    }
}
