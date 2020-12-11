/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class AmountBreakdown
    {
        /// <summary>
        /// Amount in cents and always having 2 decimals
        /// </summary>
        public long? Amount { get; set; } = null;

        /// <summary>
        /// Type of the amount. Each type is only allowed to be provided once. Allowed values: 
        /// <list type="bullet">
        ///   <item><description>AIRPORT_TAX - The amount of tax paid for the airport, with the last 2 digits implied as decimal places.</description></item>
        ///   <item><description>CONSUMPTION_TAX - The amount of consumption tax paid by the customer, with the last 2 digits implied as decimal places.</description></item>
        ///   <item><description>DISCOUNT - Discount on the entire transaction, with the last 2 digits implied as decimal places.</description></item>
        ///   <item><description>DUTY - Duty on the entire transaction, with the last 2 digits implied as decimal places.</description></item>
        ///   <item><description>HANDLING - Handling cost on the entire transaction, with the last 2 digits implied as decimal places.</description></item>
        ///   <item><description>SHIPPING - Shipping cost on the entire transaction, with the last 2 digits implied as decimal places.</description></item>
        ///   <item><description>TAX - Total tax paid on the entire transaction, with the last 2 digits implied as decimal places.</description></item>
        ///   <item><description>VAT - Total amount of VAT paid on the transaction, with the last 2 digits implied as decimal places.</description></item>
        ///   <item><description>BASE_AMOUNT - Order amount excluding all taxes, discount &amp; shipping costs, with the last 2 digits implied as decimal places. Note: BASE_AMOUNT is only supported by the Ogone Payment Platform.</description></item>
        /// </list>
        /// </summary>
        public string Type { get; set; } = null;
    }
}
