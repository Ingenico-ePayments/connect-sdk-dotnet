using Ingenico.Connect.Sdk.Domain.Payout;
using Ingenico.Connect.Sdk.Domain.Payout.Definitions;

namespace Ingenico.Connect.Sdk
{
    /// <summary>
    /// Represents an error response from a create payout call.
    /// </summary>
    public class DeclinedPayoutException : DeclinedTransactionException
    {
        /// <summary>
        /// Gets the result of creating a payout if available, otherwise <c>null</c>.
        /// </summary>
        public PayoutResult PayoutResult => _errors?.PayoutResult;

        public DeclinedPayoutException(System.Net.HttpStatusCode statusCode, string responseBody, PayoutErrorResponse errors)
            : base(BuildMessage(errors), statusCode, responseBody, errors?.ErrorId, errors?.Errors)
        {
            _errors = errors;
        }

        readonly PayoutErrorResponse _errors;

        static string BuildMessage(PayoutErrorResponse errors)
        {
            PayoutResult payout = errors?.PayoutResult;
            if (payout != null)
            {
                return "declined payout '" + payout.Id + "' with status '" + payout.Status + "'";
            }
            return "the Ingenico ePayments platform returned a declined refund response";
        }
    }
}
