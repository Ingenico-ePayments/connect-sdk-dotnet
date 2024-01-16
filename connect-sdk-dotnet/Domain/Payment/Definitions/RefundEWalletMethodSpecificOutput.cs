/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RefundEWalletMethodSpecificOutput : RefundMethodSpecificOutput
    {
        /// <summary>
        /// PayPal (payment product 840) specific details
        /// </summary>
        public RefundPaymentProduct840SpecificOutput PaymentProduct840SpecificOutput { get; set; } = null;
    }
}
