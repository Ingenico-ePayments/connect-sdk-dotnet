/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Capture.Definitions
{
    public class Capture : AbstractOrderStatus
    {
        public CaptureOutput CaptureOutput { get; set; } = null;

        public string Status { get; set; } = null;

        public CaptureStatusOutput StatusOutput { get; set; } = null;
    }
}
