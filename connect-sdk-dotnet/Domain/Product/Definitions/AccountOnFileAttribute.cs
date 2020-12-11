/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Product.Definitions
{
    public class AccountOnFileAttribute : KeyValuePair
    {
        /// <summary>
        /// The reason why the status is MUST_WRITE. Currently only "IN_THE_PAST" is possible as value (for expiry date), but this can be extended with new values in the future.
        /// </summary>
        public string MustWriteReason { get; set; } = null;

        /// <summary>
        /// Possible values: 
        /// <list type="bullet">
        ///   <item><description>READ_ONLY - attribute cannot be updated and should be presented in that way to the user</description></item>
        ///   <item><description>CAN_WRITE - attribute can be updated and should be presented as an editable field, for example an expiration date that will expire very soon</description></item>
        ///   <item><description>MUST_WRITE - attribute should be updated and must be presented as an editable field, for example an expiration date that has already expired</description></item>
        /// </list>Any updated values that are entered for CAN_WRITE or MUST_WRITE will be used to update the values stored in the token.
        /// </summary>
        public string Status { get; set; } = null;
    }
}
