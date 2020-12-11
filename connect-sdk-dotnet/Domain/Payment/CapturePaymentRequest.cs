/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment
{
    public class CapturePaymentRequest
    {
        /// <summary>
        /// Here you can specify the amount that you want to capture (specified in cents, where single digit currencies are presumed to have 2 digits).
        /// <br />The amount can be lower than the amount that was authorized, but not higher.
        /// <br />If left empty, the full amount will be captured and the request will be final.
        /// <br />If the full amount is captured, the request will also be final.
        /// </summary>
        public long? Amount { get; set; } = null;

        /// <summary>
        /// This property indicates whether this will be the final capture of this transaction. The default value for this property is false.
        /// </summary>
        public bool? IsFinal { get; set; } = null;
    }
}
