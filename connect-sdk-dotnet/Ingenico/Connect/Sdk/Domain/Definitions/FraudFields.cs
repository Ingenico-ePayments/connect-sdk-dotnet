/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class FraudFields
    {
        public bool? AddressesAreIdentical { get; set; } = null;

        public string BlackListData { get; set; } = null;

        public Address CardOwnerAddress { get; set; } = null;

        public string CustomerIpAddress { get; set; } = null;

        public string DefaultFormFill { get; set; } = null;

        public bool? DeviceFingerprintActivated { get; set; } = null;

        public string DeviceFingerprintTransactionId { get; set; } = null;

        public string GiftCardType { get; set; } = null;

        public string GiftMessage { get; set; } = null;

        public bool? HasForgottenPwd { get; set; } = null;

        public bool? HasPassword { get; set; } = null;

        public bool? IsPreviousCustomer { get; set; } = null;

        public string OrderTimezone { get; set; } = null;

        public string ShipComments { get; set; } = null;

        public string ShipmentTrackingNumber { get; set; } = null;

        public FraudFieldsShippingDetails ShippingDetails { get; set; } = null;

        public IList<string> UserData { get; set; } = null;

        public string Website { get; set; } = null;
    }
}
