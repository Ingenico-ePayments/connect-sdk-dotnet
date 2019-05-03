/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using System;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class FraudFields
    {
        [ObsoleteAttribute("For risk assessments there is no replacement. For other calls, use Order.shipping.addressIndicator instead")]
        public bool? AddressesAreIdentical { get; set; } = null;

        public string BlackListData { get; set; } = null;

        [ObsoleteAttribute("This should be the same as Order.customer.billingAddress")]
        public Address CardOwnerAddress { get; set; } = null;

        public string CustomerIpAddress { get; set; } = null;

        [ObsoleteAttribute("Use Order.customer.device.defaultFormFill instead")]
        public string DefaultFormFill { get; set; } = null;

        [ObsoleteAttribute("No replacement")]
        public bool? DeviceFingerprintActivated { get; set; } = null;

        [ObsoleteAttribute("Use Order.customer.device.deviceFingerprintTransactionId instead")]
        public string DeviceFingerprintTransactionId { get; set; } = null;

        public string GiftCardType { get; set; } = null;

        public string GiftMessage { get; set; } = null;

        [ObsoleteAttribute("Use Order.customer.account.hasForgottenPassword instead")]
        public bool? HasForgottenPwd { get; set; } = null;

        [ObsoleteAttribute("Use Order.customer.account.hasPassword instead")]
        public bool? HasPassword { get; set; } = null;

        [ObsoleteAttribute("Use Order.customer.isPreviousCustomer instead")]
        public bool? IsPreviousCustomer { get; set; } = null;

        public string OrderTimezone { get; set; } = null;

        [ObsoleteAttribute("Use Order.shipping.comments instead")]
        public string ShipComments { get; set; } = null;

        [ObsoleteAttribute("Use Order.shipping.trackingNumber instead")]
        public string ShipmentTrackingNumber { get; set; } = null;

        [ObsoleteAttribute("No replacement")]
        public FraudFieldsShippingDetails ShippingDetails { get; set; } = null;

        public IList<string> UserData { get; set; } = null;

        [ObsoleteAttribute("Use Merchant.websiteUrl instead")]
        public string Website { get; set; } = null;
    }
}
