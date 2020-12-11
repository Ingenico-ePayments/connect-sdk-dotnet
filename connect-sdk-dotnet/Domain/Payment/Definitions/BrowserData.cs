/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class BrowserData
    {
        /// <summary>
        /// ColorDepth in bits. Value is returned from the screen.colorDepth property. 
        /// <p>If you use the latest version of our JavaScript Client SDK, we will collect this data and include it in the encryptedCustomerInput property. We will then automatically populate this data if available.</p>
        /// <p>Note: This data can only be collected if JavaScript is enabled in the browser. This means that 3-D Secure version 2.1 requires the use of JavaScript to enabled. In the upcoming version 2.2 of the specification this is no longer a requirement. As we currently support version 2.1 it means that this property is required when cardPaymentMethodSpecifInput.threeDSecure.authenticationFlow is set to "browser".</p>
        /// </summary>
        public int? ColorDepth { get; set; } = null;

        /// <summary>
        /// The innerHeight of the frame in case you are capturing your payments in a frame. We will use this to validate if the height provided in the cardPaymentMethodSpecifInput.threeDSecure.challengeCanvasSize will actually fit in the iFrame you use.
        /// </summary>
        public string InnerHeight { get; set; } = null;

        /// <summary>
        /// The innerWidth of the frame in case you are capturing your payments in a frame. We will use this to validate if the width provided in the cardPaymentMethodSpecifInput.threeDSecure.challengeCanvasSize will actually fit in the iFrame you use.
        /// </summary>
        public string InnerWidth { get; set; } = null;

        /// <summary>
        /// true =Java is enabled in the browser 
        /// <p>false = Java is not enabled in the browser</p>
        /// <p>Value is returned from the navigator.javaEnabled property.</p>
        /// <p>If you use the latest version of our JavaScript Client SDK, we will collect this data and include it in the encryptedCustomerInput property. We will then automatically populate this data if available.</p>
        /// <p>Note: This data can only be collected if JavaScript is enabled in the browser. This means that 3-D Secure version 2.1 requires the use of JavaScript to enabled. In the upcoming version 2.2 of the specification this is no longer a requirement. As we currently support version 2.1 it means that this property is required when cardPaymentMethodSpecifInput.threeDSecure.authenticationFlow is set to "browser".</p>
        /// </summary>
        public bool? JavaEnabled { get; set; } = null;

        /// <summary>
        /// true = JavaScript is enabled in the browser 
        /// <p>false = JavaScript is not enabled in the browser</p>
        /// <p>Note: Required in future 3-D Secure version 2.2.</p>
        /// </summary>
        public bool? JavaScriptEnabled { get; set; } = null;

        /// <summary>
        /// Height of the screen in pixels. Value is returned from the screen.height property. 
        /// <p>If you use the latest version of our JavaScript Client SDK, we will collect this data and include it in the encryptedCustomerInput property. We will then automatically populate this data if available.</p>
        /// <p>Note: This data can only be collected if JavaScript is enabled in the browser. This means that 3-D Secure version 2.1 requires the use of JavaScript to enabled. In the upcoming version 2.2 of the specification this is no longer a requirement. As we currently support version 2.1 it means that this property is required when cardPaymentMethodSpecifInput.threeDSecure.authenticationFlow is set to "browser".</p>
        /// </summary>
        public string ScreenHeight { get; set; } = null;

        /// <summary>
        /// Width of the screen in pixels. Value is returned from the screen.width property. 
        /// <p>If you use the latest version of our JavaScript Client SDK, we will collect this data and include it in the encryptedCustomerInput property. We will then automatically populate this data if available.</p>
        /// <p>Note: This data can only be collected if JavaScript is enabled in the browser. This means that 3-D Secure version 2.1 requires the use of JavaScript to enabled. In the upcoming version 2.2 of the specification this is no longer a requirement. As we currently support version 2.1 it means that this property is required when cardPaymentMethodSpecifInput.threeDSecure.authenticationFlow is set to "browser".</p>
        /// </summary>
        public string ScreenWidth { get; set; } = null;
    }
}
