/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;
using KeyValuePair = Ingenico.Connect.Sdk.Domain.Definitions.KeyValuePair;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    public class DisplayedData
    {
        /// <summary>
        /// Action merchants needs to take in the online payment process. Possible values are:
        /// <br />
        /// <list type="bullet">
        ///   <item><description>SHOW_INSTRUCTIONS - The customer needs to be shown payment instruction using the details found in showData. Alternatively the instructions can be rendered by us using the renderingData</description></item>
        ///   <item><description>SHOW_TRANSACTION_RESULTS - The customer needs to be shown the transaction results using the details found in showData. Alternatively the instructions can be rendered by us using the renderingData</description></item>
        /// </list>
        /// </summary>
        public string DisplayedDataType { get; set; } = null;

        /// <summary>
        /// This property contains the blob with data for the instructions rendering service. 
        /// <p>This service will be available at the following endpoint: http(s)://{{merchant specific subdomain}}.{{base MyCheckout hosted payment pages domain}}/instructions/{{merchantId}}/{{clientSessionId}}</p>
        /// <p>This instructions page rendering service accepts the following parameters:</p>
        /// <list type="bullet">
        ///   <item><description>renderingData (required, the content of this property)</description></item>
        ///   <item><description>locale (optional, if present overrides default locale, e.g. "en_GB")</description></item>
        ///   <item><description>variant (optional, code of a variant, if present overrides default variant, e.g. "100")</description></item>
        /// </list>You can offer a link to a customer to see an instructions page for a payment done earlier. Because of the size of the renderingData this will need to be set in a web form as a value of a hidden field. Before presenting the link you need to obtain a clientSessionId by creating a session using the S2S API. You will need to use the MyCheckout hosted payment pages domain hosted in the same region as the API domain used for the createClientSession call. 
        /// <p>The renderingData is a String blob that is presented to you via the Server API as part of the merchantAction (if available, and non-redirect) in the JSON return values for the createPayment call or the getHostedCheckoutStatus call (merchantAction inside createdPaymentOutput when available). You are responsible to store the renderingData blob in order to be able to present the instructions page at a later time, when this information might no longer be available through Server API calls.</p>
        /// </summary>
        public string RenderingData { get; set; } = null;

        /// <summary>
        /// Array of key value pairs of data that needs to be shown to the customer. This is returned for both the SHOW_INSTRUCTION as well as the SHOW_TRANSACTION_RESULTS actionType.
        /// <br />Note: The returned value for the key BARCODE is a base64 encoded gif image. By prepending 'data:image/gif;base64,' this value can be used as the source of an HTML inline image.
        /// </summary>
        public IList<KeyValuePair> ShowData { get; set; } = null;
    }
}
