/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using System.Collections.Generic;

namespace Ingenico.Connect.Sdk.Domain.Riskassessments
{
    public class RiskAssessmentResponse
    {
        /// <summary>
        /// Object that contains the results of the performed fraudchecks
        /// </summary>
        public IList<ResultDoRiskAssessment> Results { get; set; } = null;
    }
}
