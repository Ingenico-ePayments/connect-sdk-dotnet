/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Services.Definitions
{
    public class PaymentContext
    {
        public AmountOfMoney AmountOfMoney { get; set; } = null;

        public string CountryCode { get; set; } = null;

        public bool? IsRecurring { get; set; } = null;
    }
}
