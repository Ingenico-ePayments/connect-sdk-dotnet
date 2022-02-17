/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class CashPaymentMethodSpecificInput : AbstractCashPaymentMethodSpecificInput
    {
        /// <summary>
        /// Object that holds the specific data for Boleto Bancario in Brazil (payment product 1503)
        /// </summary>
        [ObsoleteAttribute("No replacement")]
        public CashPaymentProduct1503SpecificInput PaymentProduct1503SpecificInput { get; set; } = null;

        /// <summary>
        /// Object that holds the specific data for Konbini in Japan (payment product 1504)
        /// </summary>
        public CashPaymentProduct1504SpecificInput PaymentProduct1504SpecificInput { get; set; } = null;

        /// <summary>
        /// Object that holds the specific data for e-Pay (payment product 1521).
        /// </summary>
        public CashPaymentProduct1521SpecificInput PaymentProduct1521SpecificInput { get; set; } = null;

        /// <summary>
        /// Object that holds the specific data for Tesco - Paysbuy Cash (payment product 1522).
        /// </summary>
        public CashPaymentProduct1522SpecificInput PaymentProduct1522SpecificInput { get; set; } = null;

        /// <summary>
        /// Object that holds the specific data for ATM Transfers Indonesia(payment product 1523).
        /// </summary>
        public CashPaymentProduct1523SpecificInput PaymentProduct1523SpecificInput { get; set; } = null;

        /// <summary>
        /// Object that holds the specific data for DragonPay (payment product 1524).
        /// </summary>
        public CashPaymentProduct1524SpecificInput PaymentProduct1524SpecificInput { get; set; } = null;

        /// <summary>
        /// Object that holds the specific data for 7-11 MOLPay Cash (payment product 1526).
        /// </summary>
        public CashPaymentProduct1526SpecificInput PaymentProduct1526SpecificInput { get; set; } = null;
    }
}
