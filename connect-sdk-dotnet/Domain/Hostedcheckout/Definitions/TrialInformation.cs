/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Hostedcheckout.Definitions
{
    public class TrialInformation
    {
        /// <summary>
        /// The object containing the amount and ISO currency code attributes of money to be paid after the trial period ends.
        /// <br />
        /// <br />Note:
        /// <br />
        /// <br />The property order.amountOfMoney should be populated with the amount to be paid during or for the trial period (no-cost or discounted time-constrained trial subscription period).
        /// </summary>
        public AmountOfMoney AmountOfMoneyAfterTrial { get; set; } = null;

        /// <summary>
        /// The date that the trial period ends in YYYYMMDD format.
        /// </summary>
        public string EndDate { get; set; } = null;

        /// <summary>
        /// The property specifying if there will be recurring charges throughout the trial period (when the trial period involves a temporary discounted rate).
        /// <br />True = there will be recurring charges during the trial period
        /// <br />False = there will not be recurring charges during the trial period
        /// </summary>
        public bool? IsRecurring { get; set; } = null;

        /// <summary>
        /// The object containing information on the trial period duration and the interval between payments during that period.
        /// </summary>
        public TrialPeriod TrialPeriod { get; set; } = null;

        /// <summary>
        /// The object containing the frequency and interval between recurring payments.
        /// <br />
        /// <br />Note:
        /// <br />
        /// <br />This object should only be populated if the frequency of recurring payments between the trial and regular periods is different.
        /// <br />
        /// <br />If you do not populated this object, then the same interval frequency and interval of recurringPaymentsData.recurringInterval will be used
        /// </summary>
        public Frequency TrialPeriodRecurring { get; set; } = null;
    }
}
