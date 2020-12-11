/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Mandates.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Mandates
{
    public class CreateMandateResponse
    {
        /// <summary>
        /// Object containing information on a mandate
        /// </summary>
        public MandateResponse Mandate { get; set; } = null;

        /// <summary>
        /// Object that contains the action, including the needed data, that you should perform next, showing the redirect to a third party to complete the payment or like showing instructions
        /// </summary>
        public MandateMerchantAction MerchantAction { get; set; } = null;
    }
}
