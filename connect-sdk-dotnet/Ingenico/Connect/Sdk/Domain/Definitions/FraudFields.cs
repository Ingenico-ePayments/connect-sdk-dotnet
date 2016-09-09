/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_FraudFields">FraudFields</a>
    /// </summary>
    public class FraudFields
    {
        public string CustomerIpAddress { get; set; } = null;

        public string DefaultFormFill { get; set; } = null;

        public string GiftCardType { get; set; } = null;

        public string GiftMessage { get; set; } = null;

        public bool? HasForgottenPwd { get; set; } = null;

        public bool? HasPassword { get; set; } = null;

        public bool? IsPreviousCustomer { get; set; } = null;

        public string OrderTimezone { get; set; } = null;

        public string ShipComments { get; set; } = null;

        public string ShipmentTrackingNumber { get; set; } = null;

        public IList<string> UserData { get; set; } = null;

        public string Website { get; set; } = null;
    }
}
