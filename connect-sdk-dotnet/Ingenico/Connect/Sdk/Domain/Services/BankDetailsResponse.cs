/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;
using Ingenico.Connect.Sdk.Domain.Services.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Services
{
    public class BankDetailsResponse
    {
        public BankAccountBban BankAccountBban { get; set; } = null;

        public BankAccountIban BankAccountIban { get; set; } = null;

        public BankData BankData { get; set; } = null;

        public Swift Swift { get; set; } = null;
    }
}
