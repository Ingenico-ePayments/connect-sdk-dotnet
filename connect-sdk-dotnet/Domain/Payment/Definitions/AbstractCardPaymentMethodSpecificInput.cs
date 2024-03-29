/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using System;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class AbstractCardPaymentMethodSpecificInput : AbstractPaymentMethodSpecificInput
    {
        public string AcquirerPromotionCode { get; set; } = null;

        public string AuthorizationMode { get; set; } = null;

        public string CustomerReference { get; set; } = null;

        public string InitialSchemeTransactionId { get; set; } = null;

        public CardRecurrenceDetails Recurring { get; set; } = null;

        [Obsolete("Use recurring.recurringPaymentSequenceIndicator instead")]
        public string RecurringPaymentSequenceIndicator { get; set; } = null;

        public bool? RequiresApproval { get; set; } = null;

        [Obsolete("Use threeDSecure.skipAuthentication instead")]
        public bool? SkipAuthentication { get; set; } = null;

        public bool? SkipFraudService { get; set; } = null;

        public string Token { get; set; } = null;

        public bool? Tokenize { get; set; } = null;

        public string TransactionChannel { get; set; } = null;

        [Obsolete("Use unscheduledCardOnFileSequenceIndicator instead")]
        public string UnscheduledCardOnFileIndicator { get; set; } = null;

        public string UnscheduledCardOnFileRequestor { get; set; } = null;

        public string UnscheduledCardOnFileSequenceIndicator { get; set; } = null;
    }
}
