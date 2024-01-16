/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    public class Frequency
    {
        /// <summary>
        /// The interval between recurring payments specified as days, weeks, quarters, or years.
        /// </summary>
        public string Interval { get; set; } = null;

        /// <summary>
        /// The number of days, weeks, months, quarters, or years between recurring payments.
        /// </summary>
        public int? IntervalFrequency { get; set; } = null;
    }
}
