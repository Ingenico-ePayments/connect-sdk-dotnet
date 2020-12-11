/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class PaymentProduct863ThirdPartyData
    {
        /// <summary>
        /// The appId to use in third party calls to WeChat.
        /// </summary>
        public string AppId { get; set; } = null;

        /// <summary>
        /// The nonceStr to use in third party calls to WeChat
        /// </summary>
        public string NonceStr { get; set; } = null;

        /// <summary>
        /// The packageSign to use in third party calls to WeChat
        /// </summary>
        public string PackageSign { get; set; } = null;

        /// <summary>
        /// The paySign to use in third party calls to WeChat
        /// </summary>
        public string PaySign { get; set; } = null;

        /// <summary>
        /// The prepayId to use in third party calls to WeChat.
        /// </summary>
        public string PrepayId { get; set; } = null;

        /// <summary>
        /// The signType to use in third party calls to WeChat
        /// </summary>
        public string SignType { get; set; } = null;

        /// <summary>
        /// The timeStamp to use in third party calls to WeChat
        /// </summary>
        public string TimeStamp { get; set; } = null;
    }
}
