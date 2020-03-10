/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class CashPaymentMethodSpecificInput : AbstractCashPaymentMethodSpecificInput
    {
        [ObsoleteAttribute("No replacement")]
        public CashPaymentProduct1503SpecificInput PaymentProduct1503SpecificInput { get; set; } = null;

        public CashPaymentProduct1504SpecificInput PaymentProduct1504SpecificInput { get; set; } = null;

        public CashPaymentProduct1521SpecificInput PaymentProduct1521SpecificInput { get; set; } = null;

        public CashPaymentProduct1522SpecificInput PaymentProduct1522SpecificInput { get; set; } = null;

        public CashPaymentProduct1523SpecificInput PaymentProduct1523SpecificInput { get; set; } = null;

        public CashPaymentProduct1524SpecificInput PaymentProduct1524SpecificInput { get; set; } = null;

        public CashPaymentProduct1526SpecificInput PaymentProduct1526SpecificInput { get; set; } = null;
    }
}
