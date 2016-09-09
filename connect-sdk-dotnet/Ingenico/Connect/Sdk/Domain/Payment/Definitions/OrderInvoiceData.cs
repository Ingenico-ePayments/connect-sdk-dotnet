/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_OrderInvoiceData">OrderInvoiceData</a>
    /// </summary>
    public class OrderInvoiceData
    {
        public string AdditionalData { get; set; } = null;

        public string InvoiceDate { get; set; } = null;

        public string InvoiceNumber { get; set; } = null;

        public IList<string> TextQualifiers { get; set; } = null;
    }
}
