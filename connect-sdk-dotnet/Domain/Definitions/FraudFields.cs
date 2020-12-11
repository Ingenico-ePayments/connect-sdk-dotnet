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
        /// <summary>
        /// Indicates that invoice and shipping addresses are equal.
        /// </summary>
        [ObsoleteAttribute("For risk assessments there is no replacement. For other calls, use Order.shipping.addressIndicator instead")]
        public bool? AddressesAreIdentical { get; set; } = null;

        /// <summary>
        /// Additional black list input
        /// </summary>
        public string BlackListData { get; set; } = null;

        /// <summary>
        /// The address that belongs to the owner of the card
        /// </summary>
        [ObsoleteAttribute("This should be the same as Order.customer.billingAddress")]
        public Address CardOwnerAddress { get; set; } = null;

        /// <summary>
        /// The IP Address of the customer that is making the payment
        /// </summary>
        public string CustomerIpAddress { get; set; } = null;

        /// <summary>
        /// Degree of default form fill, with the following possible values: 
        /// <list type="bullet">
        ///   <item><description>automatically - All fields filled automatically</description></item>
        ///   <item><description>automatically-but-modified - All fields filled automatically, but some fields were modified manually</description></item>
        ///   <item><description>manually - All fields were entered manually</description></item>
        /// </list>
        /// </summary>
        [ObsoleteAttribute("Use Order.customer.device.defaultFormFill instead")]
        public string DefaultFormFill { get; set; } = null;

        /// <summary>
        /// Indicates that the device fingerprint has been used while processing the order.
        /// </summary>
        [ObsoleteAttribute("No replacement")]
        public bool? DeviceFingerprintActivated { get; set; } = null;

        /// <summary>
        /// One must set the deviceFingerprintTransactionId received by the response of the endpoint /{merchant}/products/{paymentProductId}/deviceFingerprint
        /// </summary>
        [ObsoleteAttribute("Use Order.customer.device.deviceFingerprintTransactionId instead")]
        public string DeviceFingerprintTransactionId { get; set; } = null;

        /// <summary>
        /// One of the following gift card types: 
        /// <list type="bullet">
        ///   <item><description>celebrate-fall - Celebrate Fall</description></item>
        ///   <item><description>grandparents-day - Grandparent's Day</description></item>
        ///   <item><description>independence-day - Independence Day</description></item>
        ///   <item><description>anniversary - Anniversary</description></item>
        ///   <item><description>birthday - Birthday</description></item>
        ///   <item><description>congratulations - Congratulations</description></item>
        ///   <item><description>april-fools-day - April Fool's Day</description></item>
        ///   <item><description>easter - Easter</description></item>
        ///   <item><description>fathers-day - Father's Day</description></item>
        ///   <item><description>graduation - Graduation</description></item>
        ///   <item><description>holiday - Holiday</description></item>
        ///   <item><description>seasons-greetings - Season's Greetings</description></item>
        ///   <item><description>passover - Passover</description></item>
        ///   <item><description>kwanzaa - Kwanzaa</description></item>
        ///   <item><description>halloween - Halloween</description></item>
        ///   <item><description>mothers-day - Mother's Day</description></item>
        ///   <item><description>new-years-day - New Year's Day</description></item>
        ///   <item><description>bosses-day - Bosses' Day</description></item>
        ///   <item><description>st-patricks-day - St. Patrick's Day</description></item>
        ///   <item><description>sweetest-day - Sweetest Day</description></item>
        ///   <item><description>christmas - Christmas</description></item>
        ///   <item><description>baby-shower - Baby Shower</description></item>
        ///   <item><description>thanksgiving - Thanksgiving</description></item>
        ///   <item><description>other - Other</description></item>
        ///   <item><description>valentines-day - Valentine's Day</description></item>
        ///   <item><description>wedding - Wedding</description></item>
        ///   <item><description>secretarys-day - Secretary's Day</description></item>
        ///   <item><description>chinese-new-year - Chinese New Year</description></item>
        ///   <item><description>hanukkah - Hanukkah</description></item>
        /// </list>
        /// </summary>
        public string GiftCardType { get; set; } = null;

        /// <summary>
        /// Gift message
        /// </summary>
        public string GiftMessage { get; set; } = null;

        /// <summary>
        /// Specifies if the customer (initially) had forgotten their password 
        /// <list type="bullet">
        ///   <item><description>true - The customer has forgotten their password</description></item>
        ///   <item><description>false - The customer has not forgotten their password</description></item>
        /// </list>
        /// </summary>
        [ObsoleteAttribute("Use Order.customer.account.hasForgottenPassword instead")]
        public bool? HasForgottenPwd { get; set; } = null;

        /// <summary>
        /// Specifies if the customer entered a password to gain access to an account registered with the you 
        /// <list type="bullet">
        ///   <item><description>true - The customer has used a password to gain access</description></item>
        ///   <item><description>false - The customer has not used a password to gain access</description></item>
        /// </list>
        /// </summary>
        [ObsoleteAttribute("Use Order.customer.account.hasPassword instead")]
        public bool? HasPassword { get; set; } = null;

        /// <summary>
        /// Specifies if the customer has a history of online shopping with the merchant 
        /// <list type="bullet">
        ///   <item><description>true - The customer is a known returning customer</description></item>
        ///   <item><description>false - The customer is new/unknown customer</description></item>
        /// </list>
        /// </summary>
        [ObsoleteAttribute("Use Order.customer.isPreviousCustomer instead")]
        public bool? IsPreviousCustomer { get; set; } = null;

        /// <summary>
        /// Timezone in which the order was placed
        /// </summary>
        public string OrderTimezone { get; set; } = null;

        /// <summary>
        /// Comments included during shipping
        /// </summary>
        [ObsoleteAttribute("Use Order.shipping.comments instead")]
        public string ShipComments { get; set; } = null;

        /// <summary>
        /// Shipment tracking number
        /// </summary>
        [ObsoleteAttribute("Use Order.shipping.trackingNumber instead")]
        public string ShipmentTrackingNumber { get; set; } = null;

        /// <summary>
        /// Details on how the order is shipped to the customer
        /// </summary>
        [ObsoleteAttribute("No replacement")]
        public FraudFieldsShippingDetails ShippingDetails { get; set; } = null;

        /// <summary>
        /// Array of up to 16 userData properties, each with a max length of 256 characters, that can be used for fraudscreening
        /// </summary>
        public IList<string> UserData { get; set; } = null;

        /// <summary>
        /// The website from which the purchase was made
        /// </summary>
        [ObsoleteAttribute("Use Merchant.websiteUrl instead")]
        public string Website { get; set; } = null;
    }
}
