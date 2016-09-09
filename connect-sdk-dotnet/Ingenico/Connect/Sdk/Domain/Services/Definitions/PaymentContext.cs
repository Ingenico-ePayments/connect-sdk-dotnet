/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Services.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_PaymentContext">PaymentContext</a>
    /// </summary>
    public class PaymentContext
    {
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        public string CountryCode { get; set; } = null;

        public bool? IsRecurring { get; set; } = null;
    }
}
