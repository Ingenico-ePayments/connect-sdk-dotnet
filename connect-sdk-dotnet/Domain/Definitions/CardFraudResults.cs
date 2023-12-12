/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Definitions
{
    public class CardFraudResults : FraudResults
    {
        /// <summary>
        /// Result of the Address Verification Service checks. Possible values are: 
        /// <list type="bullet">
        ///   <item><description>A - Address (Street) matches, Zip does not</description></item>
        ///   <item><description>B - Street address match for international transactions&#8212;Postal code not verified due to incompatible formats</description></item>
        ///   <item><description>C - Street address and postal code not verified for international transaction due to incompatible formats</description></item>
        ///   <item><description>D - Street address and postal code match for international transaction, cardholder name is incorrect</description></item>
        ///   <item><description>E - AVS error</description></item>
        ///   <item><description>F - Address does match and five digit ZIP code does match (UK only)</description></item>
        ///   <item><description>G - Address information is unavailable; international transaction; non-AVS participant</description></item>
        ///   <item><description>H - Billing address and postal code match, cardholder name is incorrect (Amex)</description></item>
        ///   <item><description>I - Address information not verified for international transaction</description></item>
        ///   <item><description>K - Cardholder name matches (Amex)</description></item>
        ///   <item><description>L - Cardholder name and postal code match (Amex)</description></item>
        ///   <item><description>M - Cardholder name, street address, and postal code match for international transaction</description></item>
        ///   <item><description>N - No Match on Address (Street) or Zip</description></item>
        ///   <item><description>O - Cardholder name and address match (Amex)</description></item>
        ///   <item><description>P - Postal codes match for international transaction&#8212;Street address not verified due to incompatible formats</description></item>
        ///   <item><description>Q - Billing address matches, cardholder is incorrect (Amex)</description></item>
        ///   <item><description>R - Retry, System unavailable or Timed out</description></item>
        ///   <item><description>S - Service not supported by issuer</description></item>
        ///   <item><description>U - Address information is unavailable</description></item>
        ///   <item><description>W - 9 digit Zip matches, Address (Street) does not</description></item>
        ///   <item><description>X - Exact AVS Match</description></item>
        ///   <item><description>Y - Address (Street) and 5 digit Zip match</description></item>
        ///   <item><description>Z - 5 digit Zip matches, Address (Street) does not</description></item>
        ///   <item><description>0 - No service available</description></item>
        /// </list>
        /// </summary>
        public string AvsResult { get; set; } = null;

        /// <summary>
        /// Result of the Card Verification Value checks. Possible values are: 
        /// <list type="bullet">
        ///   <item><description>M - CVV check performed and valid value</description></item>
        ///   <item><description>N - CVV checked and no match</description></item>
        ///   <item><description>P - CVV check not performed, not requested</description></item>
        ///   <item><description>S - Cardholder claims no CVV code on card, issuer states CVV-code should be on card</description></item>
        ///   <item><description>U - Issuer not certified for CVV2</description></item>
        ///   <item><description>Y - Server provider did not respond</description></item>
        ///   <item><description>0 - No service available</description></item>
        /// </list>
        /// </summary>
        public string CvvResult { get; set; } = null;

        /// <summary>
        /// Results of Fraugster fraud prevention check. Fraugster collects transaction data points such as name, email address, billing, etc. to analyze whether or not the transaction is fraudulent.
        /// </summary>
        public FraugsterResults Fraugster { get; set; } = null;

        /// <summary>
        /// Additional response data returned by RetailDecisions
        /// </summary>
        public FraudResultsRetailDecisions RetailDecisions { get; set; } = null;
    }
}
