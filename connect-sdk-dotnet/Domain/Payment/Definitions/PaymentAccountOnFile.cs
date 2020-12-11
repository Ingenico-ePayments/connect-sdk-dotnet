/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class PaymentAccountOnFile
    {
        /// <summary>
        /// The date (YYYYMMDD) when the payment account on file was first created. 
        /// <p>In case a token is used for the transaction we will use the creation date of the token in our system in case you leave this property empty.</p>
        /// </summary>
        public string CreateDate { get; set; } = null;

        /// <summary>
        /// Number of attempts made to add new card to the customer account in the last 24 hours
        /// </summary>
        public int? NumberOfCardOnFileCreationAttemptsLast24Hours { get; set; } = null;
    }
}
