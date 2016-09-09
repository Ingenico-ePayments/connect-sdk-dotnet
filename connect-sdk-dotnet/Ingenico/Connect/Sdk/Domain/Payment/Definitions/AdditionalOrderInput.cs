/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_AdditionalOrderInput">AdditionalOrderInput</a>
    /// </summary>
    public class AdditionalOrderInput
    {
        public AirlineData AirlineData { get; set; } = null;

        public Level3SummaryData Level3SummaryData { get; set; } = null;

        public long? NumberOfInstallments { get; set; } = null;

        public string OrderDate { get; set; } = null;

        public OrderTypeInformation TypeInformation { get; set; } = null;
    }
}
