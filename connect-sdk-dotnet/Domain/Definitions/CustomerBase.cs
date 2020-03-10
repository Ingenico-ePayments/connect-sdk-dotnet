/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class CustomerBase
    {
        public CompanyInformation CompanyInformation { get; set; } = null;

        public string MerchantCustomerId { get; set; } = null;

        [ObsoleteAttribute("Use companyInformation.vatNumber instead")]
        public string VatNumber { get; set; } = null;
    }
}
