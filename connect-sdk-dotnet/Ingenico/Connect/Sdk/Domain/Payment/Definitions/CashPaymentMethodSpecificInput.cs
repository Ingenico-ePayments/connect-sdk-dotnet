/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_CashPaymentMethodSpecificInput">CashPaymentMethodSpecificInput</a>
    /// </summary>
    public class CashPaymentMethodSpecificInput : CashPaymentMethodSpecificInputBase
    {
        public CashPaymentProduct1503SpecificInput PaymentProduct1503SpecificInput { get; set; } = null;

        public CashPaymentProduct1504SpecificInput PaymentProduct1504SpecificInput { get; set; } = null;
    }
}
