/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class OrderInvoiceData
    {
        /// <summary>
        /// Additional data for printed invoices
        /// </summary>
        public string AdditionalData { get; set; } = null;

        /// <summary>
        /// Date and time on invoice
        /// <br />Format: YYYYMMDDHH24MISS
        /// </summary>
        public string InvoiceDate { get; set; } = null;

        /// <summary>
        /// Your invoice number (on printed invoice) that is also returned in our report files
        /// </summary>
        public string InvoiceNumber { get; set; } = null;

        /// <summary>
        /// Array of 3 text qualifiers, each with a max length of 10 characters
        /// </summary>
        public IList<string> TextQualifiers { get; set; } = null;
    }
}
