using System;

namespace Ingenico.Connect.Sdk.Webhooks
{
    /// <summary>
    /// Represents an error because a webhooks event has an API version that this version of the SDK does not support.
    /// </summary>
    class ApiVersionMismatchException : Exception
    {
        /// <summary>
        /// The Api version from the webhooks event.
        /// </summary>
        public string EventApiVersion { get; }

        /// <summary>
        /// The Api version that this version of the SDK supports.
        /// </summary>
        public string SdkApiVersion { get; }

        public ApiVersionMismatchException(string eventApiVersion, string sdkApiVersion) : base("event API version " + eventApiVersion + " is not compatible with SDK API version " + sdkApiVersion)
        {
            EventApiVersion = eventApiVersion;
            SdkApiVersion = sdkApiVersion;
        }
    }
}
