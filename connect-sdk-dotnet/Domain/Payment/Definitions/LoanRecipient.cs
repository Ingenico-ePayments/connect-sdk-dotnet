/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
namespace Ingenico.Connect.Sdk.Domain.Payment.Definitions
{
    public class LoanRecipient
    {
        /// <summary>
        /// Should be filled with the last 10 digits of the bank account number of the recipient of the loan.
        /// </summary>
        public string AccountNumber { get; set; } = null;

        /// <summary>
        /// The date of birth of the customer of the recipient of the loan.
        /// <br />Format: YYYYMMDD
        /// </summary>
        public string DateOfBirth { get; set; } = null;

        /// <summary>
        /// Should be filled with the first 6 and last 4 digits of the PAN number of the recipient of the loan.
        /// </summary>
        public string PartialPan { get; set; } = null;

        /// <summary>
        /// Surname of the recipient of the loan.
        /// </summary>
        public string Surname { get; set; } = null;

        /// <summary>
        /// Zip code of the recipient of the loan
        /// </summary>
        public string Zip { get; set; } = null;
    }
}
