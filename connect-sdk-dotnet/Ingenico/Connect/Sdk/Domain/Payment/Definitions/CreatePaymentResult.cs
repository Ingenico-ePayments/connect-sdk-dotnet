/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_CreatePaymentResult">CreatePaymentResult</a>
    /// </summary>
    public class CreatePaymentResult
    {
        public PaymentCreationOutput CreationOutput { get; set; } = null;

        public MerchantAction MerchantAction { get; set; } = null;

        public Payment Payment { get; set; } = null;
    }
}
