/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class RedirectionData
    {
        /// <summary>
        /// The URL that the customer is redirect to after the payment flow has finished. You can add any number of key value pairs in the query string that, for instance help you to identify the customer when they return to your site. Please note that we will also append some additional key value pairs that will also help you with this identification process.
        /// <br />Note: The provided URL should be absolute and contain the protocol to use, e.g. http:// or https://. For use on mobile devices a custom protocol can be used in the form of 
        /// <i>protocol</i>://. This protocol must be registered on the device first.
        /// <br />URLs without a protocol will be rejected.
        /// </summary>
        public string ReturnUrl { get; set; } = null;

        /// <summary>
        /// Using the Configuration Center it is possible to create multiple variations of your MyCheckout payment pages. The redirection flow for 3-D Secure uses the MyCheckout payment pages to display the following types of pages: 
        /// <list type="bullet">
        ///   <item><description>Redirection page - All redirection using a POST method will load a page in the browser of the customer that performs the actual redirection. This page contains a message to the customer explaining what is happening.</description></item>
        ///   <item><description>MethodURL page - Certain Issuers will use a specific flow in case of 3-D Secure version 2 to directly collect information from the customer browser. This page contains a spinner indicating that this process is going on in.</description></item>
        /// </list>By specifying a specific variant you can force the use of another variant than the default. This allows you to test out the effect of certain changes to your MyCheckout payment pages in a controlled manner. Please note that you need to specify the ID instead of the name of the variant.
        /// <br />Note: In case you have defined a Dynamic 3D Secure rule that takes the variant into account this will only work if you explicitly specify the ID using this property.
        /// </summary>
        public string Variant { get; set; } = null;
    }
}
