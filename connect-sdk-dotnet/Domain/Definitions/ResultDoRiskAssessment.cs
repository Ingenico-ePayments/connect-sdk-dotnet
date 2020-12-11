/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class ResultDoRiskAssessment
    {
        /// <summary>
        /// The Risk Services category with the following possible values: 
        /// <list type="bullet">
        ///   <item><description>retaildecisionsCCFraudCheck - checks performed by Retail Decisions</description></item>
        ///   <item><description>globalcollectBlacklistCheckCC - Checked against the blacklist on the GlobalCollect platform</description></item>
        ///   <item><description>authorizationCheck - 0$ auth card account validation check</description></item>
        ///   <item><description>ddFraudCheck - Check performed for German market via InterCard</description></item>
        ///   <item><description>validationbankAccount - Bank account details are algorithmically checked if they could exist</description></item>
        ///   <item><description>globalcollectBlacklistCheckDD - Checked against the blacklist on the GlobalCollect platform</description></item>
        /// </list>
        /// </summary>
        public string Category { get; set; } = null;

        /// <summary>
        /// Risk service result with the following possible results: 
        /// <list type="bullet">
        ///   <item><description>accepted - Based on the checks performed the transaction can be accepted</description></item>
        ///   <item><description>challenged - Based on the checks performed the transaction should be manually reviewed</description></item>
        ///   <item><description>denied - Based on the checks performed the transaction should be rejected</description></item>
        ///   <item><description>no-advice - No fraud check was requested/performed</description></item>
        ///   <item><description>error - The fraud check resulted in an error and the fraud check was thus not performed</description></item>
        /// </list>
        /// </summary>
        public string Result { get; set; } = null;

        /// <summary>
        /// Object containing the results of the fraud checks performed by Retail Decisions
        /// </summary>
        public RetailDecisionsCCFraudCheckOutput RetaildecisionsCCFraudCheckOutput { get; set; } = null;

        /// <summary>
        /// Object containing the results of the fraud checks performed on the bank account data
        /// </summary>
        public ValidationBankAccountOutput ValidationBankAccountOutput { get; set; } = null;
    }
}
