/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payout.Definitions
{
    public class PayoutMerchant
    {
        /// <summary>
        /// In case your account has been setup with multiple configurations you can use this property to identify the one you would like to use for the transaction. Note that you can only submit preconfigured values in combination with the Worldline Online Payments Acceptance platform. In case no value is supplied a default value of 0 will be submitted to the Worldline Online Payments Acceptance platform. The Worldline Online Payments Acceptance platform internally refers to this as a PosId.
        /// </summary>
        public string ConfigurationId { get; set; } = null;
    }
}
