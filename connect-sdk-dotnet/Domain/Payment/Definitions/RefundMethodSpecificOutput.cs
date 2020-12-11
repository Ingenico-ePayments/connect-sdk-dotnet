/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RefundMethodSpecificOutput
    {
        /// <summary>
        /// Refund product identifier
        /// <br />Please see 
        /// <a href="https://epayments-api.developer-ingenico.com/s2sapi/v1/en_US/dotnet/refundproducts.html">refund products</a> for a full overview of possible values.
        /// </summary>
        public int? RefundProductId { get; set; } = null;

        /// <summary>
        /// Total paid amount (in cents and always with 2 decimals)
        /// </summary>
        public long? TotalAmountPaid { get; set; } = null;

        public long? TotalAmountRefunded { get; set; } = null;
    }
}
