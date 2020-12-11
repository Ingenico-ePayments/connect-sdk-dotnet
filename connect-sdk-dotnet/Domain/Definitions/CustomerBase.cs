/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class CustomerBase
    {
        /// <summary>
        /// Object containing company information
        /// </summary>
        public CompanyInformation CompanyInformation { get; set; } = null;

        /// <summary>
        /// Your identifier for the customer. It can be used as a search criteria in the GlobalCollect Payment Console and is also included in the GlobalCollect report files. It is used in the fraud-screening process for payments on the Ogone Payment Platform.
        /// </summary>
        public string MerchantCustomerId { get; set; } = null;

        /// <summary>
        /// Local VAT number of the company
        /// </summary>
        [ObsoleteAttribute("Use companyInformation.vatNumber instead")]
        public string VatNumber { get; set; } = null;
    }
}
