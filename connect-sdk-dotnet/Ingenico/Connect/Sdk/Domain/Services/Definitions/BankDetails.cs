/*
 * This class was auto-generated from the API references found at
 * https://developer.globalcollect.com/documentation/api/server/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Services.Definitions
{
    /// <summary>
    /// Class <a href="https://developer.globalcollect.com/documentation/api/server/#schema_BankDetails">BankDetails</a>
    /// </summary>
    public class BankDetails
    {
        public BankAccountBban BankAccountBban { get; set; } = null;

        public BankAccountIban BankAccountIban { get; set; } = null;
    }
}
