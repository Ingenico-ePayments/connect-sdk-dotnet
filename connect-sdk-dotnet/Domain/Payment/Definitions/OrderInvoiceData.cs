/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class OrderInvoiceData
    {
        public string AdditionalData { get; set; } = null;

        public string InvoiceDate { get; set; } = null;

        public string InvoiceNumber { get; set; } = null;

        public IList<string> TextQualifiers { get; set; } = null;
    }
}
