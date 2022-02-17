/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class Installments
    {
        /// <summary>
        /// The amount that will be paid per installment. The total amount of amountOfMoneyPerInstallment x numberOfInstallments can not be higher than the total amount of this transaction, although we will not validate that.
        /// </summary>
        public AmountOfMoney AmountOfMoneyPerInstallment { get; set; } = null;

        /// <summary>
        /// The frequency in which the installments will be collected from the customer. The possible values are: 
        /// <list type="bullet">
        ///   <item><description>daily</description></item>
        ///   <item><description>weekly</description></item>
        ///   <item><description>monthly (default)</description></item>
        ///   <item><description>quarterly</description></item>
        /// </list>
        /// </summary>
        public string FrequencyOfInstallments { get; set; } = null;

        /// <summary>
        /// The code for the installment plan. The possible values are: 
        /// <list type="bullet">
        ///   <item><description>
        ///   <b>43</b> No-interest, 3 month Installmentplan</description></item>
        ///   <item><description>
        ///   <b>46</b>No-interest, 6 month Installmentplan</description></item>
        ///   <item><description>
        ///   <b>49</b>No-interest, 9 month Installmentplan</description></item>
        ///   <item><description>
        ///   <b>52</b>No-interest, 12 month Installmentplan</description></item>
        /// </list>
        /// </summary>
        public int? InstallmentPlanCode { get; set; } = null;

        /// <summary>
        /// The interest rate paid for installments expressed in percentage. So for example 5.75 means 5.75%
        /// </summary>
        public string InterestRate { get; set; } = null;

        /// <summary>
        /// The number of installments in which this transaction will be paid, which can be used for card payments. Only used with some acquirers. In case you send in the details of this object, only the combination of card products and acquirers that do support installments will be shown on the MyCheckout hosted payment pages.If this property is not provided the customer will not see details on the installment plan in a HostedCheckout.
        /// </summary>
        public long? NumberOfInstallments { get; set; } = null;
    }
}
