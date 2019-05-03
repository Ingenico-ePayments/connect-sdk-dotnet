/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class CustomerAccount
    {
        public CustomerAccountAuthentication Authentication { get; set; } = null;

        public string ChangeDate { get; set; } = null;

        public bool? ChangedDuringCheckout { get; set; } = null;

        public string CreateDate { get; set; } = null;

        public bool? HadSuspiciousActivity { get; set; } = null;

        public bool? HasForgottenPassword { get; set; } = null;

        public bool? HasPassword { get; set; } = null;

        public string PasswordChangeDate { get; set; } = null;

        public bool? PasswordChangedDuringCheckout { get; set; } = null;

        public PaymentAccountOnFile PaymentAccountOnFile { get; set; } = null;

        public string PaymentAccountOnFileType { get; set; } = null;

        public CustomerPaymentActivity PaymentActivity { get; set; } = null;
    }
}
