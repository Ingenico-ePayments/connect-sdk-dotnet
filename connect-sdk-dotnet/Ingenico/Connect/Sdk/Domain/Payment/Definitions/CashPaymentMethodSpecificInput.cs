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
    }
}
