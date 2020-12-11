/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    public class HostedCheckoutSpecificInput
    {
        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true - Only payment products that support recurring payments will be shown. Any transactions created will also be tagged as being a first of a recurring sequence.</description></item>
        ///   <item><description>false - Only payment products that support one-off payments will be shown.</description></item>
        /// </list>The default value for this property is false.
        /// </summary>
        public bool? IsRecurring { get; set; } = null;

        /// <summary>
        /// Locale to use to present the MyCheckout payment pages to the customer. Please make sure that a language pack is configured for the locale you are submitting. If you submit a locale that is not setup on your account we will use the default language pack for your account. You can easily upload additional language packs and set the default language pack in the Configuration Center.
        /// </summary>
        public string Locale { get; set; } = null;

        /// <summary>
        /// Contains the payment product ids and payment product groups that will be used for manipulating the payment products available for the payment to the customer.
        /// </summary>
        public PaymentProductFiltersHostedCheckout PaymentProductFilters { get; set; } = null;

        /// <summary>
        /// This flag affects the status of a Hosted Checkout when a customer presses the cancel button and is returned to you as a result.
        /// <br />If set to true, then the status will be CANCELLED_BY_CONSUMER. If set to false, then the status will be IN_PROGRESS.
        /// <br />The default value is false. This flag was added to introduce the additional CANCELLED_BY_CONSUMER state as a non-breaking change.
        /// </summary>
        public bool? ReturnCancelState { get; set; } = null;

        /// <summary>
        /// The URL that the customer is redirect to after the payment flow has finished. You can add any number of key value pairs in the query string that, for instance help you to identify the customer when they return to your site. Please note that we will also append some additional key value pairs that will also help you with this identification process.
        /// <br />Note: The provided URL should be absolute and contain the protocol to use, e.g. http:// or https://. For use on mobile devices a custom protocol can be used in the form of 
        /// <i>protocol</i>://. This protocol must be registered on the device first.
        /// <br />URLs without a protocol will be rejected.
        /// </summary>
        public string ReturnUrl { get; set; } = null;

        /// <summary>
        /// <list type="bullet">
        ///   <item><description>true - MyCheckout will show a result page to the customer when applicable. Default.</description></item>
        ///   <item><description>false - MyCheckout will redirect the customer back to the provided returnUrl when this is possible.</description></item>
        /// </list>The default value for this property is true.
        /// </summary>
        public bool? ShowResultPage { get; set; } = null;

        /// <summary>
        /// String containing comma separated tokens (no spaces) associated with the customer of this hosted checkout. Valid tokens will be used to present the customer the option to re-use previously used payment details. This means the customer for instance does not have to re-enter their card details again, which a big plus when the customer is using their mobile phone to complete the checkout.
        /// </summary>
        public string Tokens { get; set; } = null;

        /// <summary>
        /// By default, validation is done for all the information required to display the shopping cart. Set this value to false if you would like to turn that feature off for a hosted checkout on the Ogone Payment Platform, in which case the rendering of the shopping cart will be skipped if any required information is missing. Use this when you want fraud-checks to be performed on the shopping cart, but do not want to suply all data needed for displaying it in the hosted checkout. The default value for this property is true.
        /// </summary>
        public bool? ValidateShoppingCart { get; set; } = null;

        /// <summary>
        /// Using the Configuration Center it is possible to create multiple variations of your MyCheckout payment pages. By specifying a specific variant you can force the use of another variant then the default. This allows you to test out the effect of certain changes to your MyCheckout payment pages in a controlled manner. Please note that you need to specify the ID of the variant.
        /// </summary>
        public string Variant { get; set; } = null;
    }
}
