/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class CustomerAccount
    {
        /// <summary>
        /// Object containing data on the authentication used by the customer to access their account
        /// </summary>
        public CustomerAccountAuthentication Authentication { get; set; } = null;

        /// <summary>
        /// The last date (YYYYMMDD) on which the customer made changes to their account with you. These are changes to billing &amp; shipping address details, new payment account (tokens), or new users(s) added.
        /// </summary>
        public string ChangeDate { get; set; } = null;

        /// <summary>
        /// true = the customer made changes to their account during this checkout 
        /// <p>false = the customer didn't change anything to their account during this checkout/n</p>
        /// <p>The changes ment here are changes to billing &amp; shipping address details, new payment account (tokens), or new users(s) added.</p>
        /// </summary>
        public bool? ChangedDuringCheckout { get; set; } = null;

        /// <summary>
        /// The date (YYYYMMDD) on which the customer created their account with you
        /// </summary>
        public string CreateDate { get; set; } = null;

        /// <summary>
        /// Specifies if you have experienced suspicious activity on the account of the customer 
        /// <p>true = you have experienced suspicious activity (including previous fraud) on the customer account used for this transaction</p>
        /// <p>false = you have experienced no suspicious activity (including previous fraud) on the customer account used for this transaction</p>
        /// </summary>
        public bool? HadSuspiciousActivity { get; set; } = null;

        /// <summary>
        /// Specifies if the customer (initially) had forgotten their password 
        /// <list type="bullet">
        ///   <item><description>true - The customer has forgotten their password</description></item>
        ///   <item><description>false - The customer has not forgotten their password</description></item>
        /// </list>
        /// </summary>
        public bool? HasForgottenPassword { get; set; } = null;

        /// <summary>
        /// Specifies if the customer entered a password to gain access to an account registered with the you 
        /// <list type="bullet">
        ///   <item><description>true - The customer has used a password to gain access</description></item>
        ///   <item><description>false - The customer has not used a password to gain access</description></item>
        /// </list>
        /// </summary>
        public bool? HasPassword { get; set; } = null;

        /// <summary>
        /// The last date (YYYYMMDD) on which the customer changed their password for the account used in this transaction
        /// </summary>
        public string PasswordChangeDate { get; set; } = null;

        /// <summary>
        /// Indicates if the password of an account is changed during this checkout 
        /// <p>true = the customer made changes to their password of the account used during this checkout</p>
        /// <p>alse = the customer didn't change anything to their password of the account used during this checkout</p>
        /// </summary>
        public bool? PasswordChangedDuringCheckout { get; set; } = null;

        /// <summary>
        /// Object containing information on the payment account data on file (tokens)
        /// </summary>
        public PaymentAccountOnFile PaymentAccountOnFile { get; set; } = null;

        /// <summary>
        /// Indicates the type of account. For example, for a multi-account card product. 
        /// <list type="bullet">
        ///   <item><description>not-applicable = the card used doesn't support multiple card products</description></item>
        ///   <item><description>credit = the card used is a credit card</description></item>
        ///   <item><description>debit = the card used is a debit card</description></item>
        /// </list>
        /// </summary>
        public string PaymentAccountOnFileType { get; set; } = null;

        /// <summary>
        /// Object containing data on the purchase history of the customer with you
        /// </summary>
        public CustomerPaymentActivity PaymentActivity { get; set; } = null;
    }
}
