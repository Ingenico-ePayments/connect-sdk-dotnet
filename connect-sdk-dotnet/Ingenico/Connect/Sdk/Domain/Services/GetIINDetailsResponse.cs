/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Services.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Services
{
    public class GetIINDetailsResponse
    {
        public IList<IINDetail> CoBrands { get; set; } = null;

        public string CountryCode { get; set; } = null;

        public bool? IsAllowedInContext { get; set; } = null;

        public int? PaymentProductId { get; set; } = null;
    }
}
