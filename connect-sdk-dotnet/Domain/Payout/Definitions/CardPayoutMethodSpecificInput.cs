/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Payout.Definitions
{
    public class CardPayoutMethodSpecificInput : AbstractPayoutMethodSpecificInput
    {
        public Card Card { get; set; } = null;

        public int? PaymentProductId { get; set; } = null;

        public string Token { get; set; } = null;
    }
}
