/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class PaymentProduct
    {
        /// <summary>
        /// List of tokens for that payment product
        /// </summary>
        public IList<AccountOnFile> AccountsOnFile { get; set; } = null;

        /// <summary>
        /// ISO 3166-1 alpha-2 country code which indicates the most likely country code of the acquirer that will process the transaction. For Google Pay (paymentProductId 320) transactions this acquirerCountry is should be provided in the 
        /// <a href="https://developers.google.com/pay/api/web/reference/request-objects#TransactionInfo">transactionInfo.countryCode</a> for merchants that use an acquirer that is based in one of the European Economic Area (EEA) countries to make sure the transaction is compliant with the PSD2 Strong Customer Authentication (SCA) requirements. More information on Strong Customer Authentication compliance for Google Pay can be found at 
        /// <a href="https://developers.google.com/pay/api/web/guides/resources/sca">https://developers.google.com/pay/api/web/guides/resources/sca</a>
        /// </summary>
        public string AcquirerCountry { get; set; } = null;

        /// <summary>
        /// Indicates if the product supports installments 
        /// <list type="bullet">
        ///   <item><description>true - This payment supports installments</description></item>
        ///   <item><description>false - This payment does not support installments</description></item>
        /// </list>
        /// </summary>
        public bool? AllowsInstallments { get; set; } = null;

        /// <summary>
        /// Indicates if the product supports recurring payments 
        /// <list type="bullet">
        ///   <item><description>true - This payment product supports recurring payments</description></item>
        ///   <item><description>false - This payment product does not support recurring transactions and can only be used for one-off payments</description></item>
        /// </list>
        /// </summary>
        public bool? AllowsRecurring { get; set; } = null;

        /// <summary>
        /// Indicates if the payment details can be tokenized for future re-use 
        /// <list type="bullet">
        ///   <item><description>true - Payment details from payments done with this payment product can be tokenized for future re-use</description></item>
        ///   <item><description>false - Payment details from payments done with this payment product can not be tokenized</description></item>
        /// </list>
        /// </summary>
        public bool? AllowsTokenization { get; set; } = null;

        /// <summary>
        /// Indicates if the payment product supports 3D Security (mandatory, optional or not needed).
        /// </summary>
        public AuthenticationIndicator AuthenticationIndicator { get; set; } = null;

        /// <summary>
        /// Indicates if the payment details can be automatically tokenized for future re-use 
        /// <list type="bullet">
        ///   <item><description>true - Payment details from payments done with this payment product can be automatically tokenized for future re-use</description></item>
        ///   <item><description>false - Payment details from payments done with this payment product can not be automatically tokenized</description></item>
        /// </list>
        /// </summary>
        public bool? AutoTokenized { get; set; } = null;

        /// <summary>
        /// This property is only relevant for payment products that use third party redirects. This property indicates if the third party disallows their payment pages to be embedded in an iframe using the X-Frame-Options header. 
        /// <list type="bullet">
        ///   <item><description>true - the third party allows their payment pages to be embedded in an iframe.</description></item>
        ///   <item><description>false - the third party disallows their payment pages to be embedded in an iframe.</description></item>
        /// </list>
        /// </summary>
        public bool? CanBeIframed { get; set; } = null;

        /// <summary>
        /// Indicates if device fingerprint is enabled for the product 
        /// <list type="bullet">
        ///   <item><description>true</description></item>
        ///   <item><description>false</description></item>
        /// </list>
        /// </summary>
        public bool? DeviceFingerprintEnabled { get; set; } = null;

        /// <summary>
        /// Object containing display hints like the order in which the product should be shown, the name of the product and the logo
        /// </summary>
        public PaymentProductDisplayHints DisplayHints { get; set; } = null;

        /// <summary>
        /// Object containing all the fields and their details that are associated with this payment product. If you are not interested in the data in the fields you should have us filter them out (using filter=fields in the query-string)
        /// </summary>
        public IList<PaymentProductField> Fields { get; set; } = null;

        /// <summary>
        /// If one or more of the payment product fields could not be constructed, no payment product fields will be returned and a message will be present in this property stating why.
        /// </summary>
        public string FieldsWarning { get; set; } = null;

        /// <summary>
        /// The ID of the payment product in our system
        /// </summary>
        public int? Id { get; set; } = null;

        /// <summary>
        /// This property indicates if the payment product requires JavaScript to be enabled on the customer's browser. This is usually only true if the payment product depends on a third party JavaScript integration. 
        /// <list type="bullet">
        ///   <item><description>true - the payment product requires JavaScript to be enabled.</description></item>
        ///   <item><description>false - the payment product does not require JavaScript to be enabled. This is the default value if the property is not present.</description></item>
        /// </list>
        /// </summary>
        public bool? IsJavaScriptRequired { get; set; } = null;

        /// <summary>
        /// Maximum amount in EUR cents (using 2 decimals, so 1 EUR becomes 100 cents) for transactions done with this payment product
        /// </summary>
        public long? MaxAmount { get; set; } = null;

        /// <summary>
        /// Minimum amount in EUR cents (using 2 decimals, so 1 EUR becomes 100 cents) for transactions done with this payment product
        /// </summary>
        public long? MinAmount { get; set; } = null;

        /// <summary>
        /// This provides insight into the level of support for payments using a device with a smaller screen size. You can for instance use this to rank payment products differently on devices with a smaller screen. Possible values are: 
        /// <list type="bullet">
        ///   <item><description>NO_SUPPORT - The payment product does not work at all on a mobile device</description></item>
        ///   <item><description>BASIC_SUPPORT - The payment product has not optimized its user experience for devices with smaller screens</description></item>
        ///   <item><description>OPTIMISED_SUPPORT - The payment product offers a user experience that has been optimized for devices with smaller screens</description></item>
        /// </list>
        /// </summary>
        public string MobileIntegrationLevel { get; set; } = null;

        /// <summary>
        /// Indicates which payment method will be used for this payment product. Payment method is one of: 
        /// <list type="bullet">
        ///   <item><description>bankTransfer</description></item>
        ///   <item><description>card</description></item>
        ///   <item><description>cash</description></item>
        ///   <item><description>directDebit</description></item>
        ///   <item><description>eInvoice</description></item>
        ///   <item><description>invoice</description></item>
        ///   <item><description>redirect</description></item>
        /// </list>
        /// </summary>
        public string PaymentMethod { get; set; } = null;

        /// <summary>
        /// Apple Pay (payment product 302) specific details.
        /// </summary>
        public PaymentProduct302SpecificData PaymentProduct302SpecificData { get; set; } = null;

        /// <summary>
        /// Google Pay (payment product 320) specific details.
        /// </summary>
        public PaymentProduct320SpecificData PaymentProduct320SpecificData { get; set; } = null;

        /// <summary>
        /// WeChat Pay (payment product 863) specific details.
        /// </summary>
        public PaymentProduct863SpecificData PaymentProduct863SpecificData { get; set; } = null;

        /// <summary>
        /// The payment product group that has this payment product, if there is any. Not populated otherwise. Currently only one payment product group is supported: 
        /// <list type="bullet">
        ///   <item><description>cards</description></item>
        /// </list>
        /// </summary>
        public string PaymentProductGroup { get; set; } = null;

        /// <summary>
        /// Indicates whether the payment product requires redirection to a third party to complete the payment. You can use this to filter out products that require a redirect if you don't want to support that. 
        /// <list type="bullet">
        ///   <item><description>true - Redirection is required</description></item>
        ///   <item><description>false - No redirection is required</description></item>
        /// </list>
        /// </summary>
        public bool? UsesRedirectionTo3rdParty { get; set; } = null;
    }
}
