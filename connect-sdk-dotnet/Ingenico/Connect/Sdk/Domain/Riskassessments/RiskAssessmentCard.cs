/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Riskassessments.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Riskassessments
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_RiskAssessmentCard">RiskAssessmentCard</a>
    /// </summary>
    public class RiskAssessmentCard : RiskAssessment
    {
        public Card Card { get; set; } = null;
    }
}
